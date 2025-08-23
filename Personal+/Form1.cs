using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Personal_
{
    public partial class Form1 : Form
    {
        private Stack<string> backHistory = new Stack<string>();
        private Stack<string> forwardHistory = new Stack<string>();
        private string currentPath;
        private ImageList imageList = new ImageList();

        [DllImport("Shell32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        private const uint SHGFI_ICON = 0x000000100;
        private const uint SHGFI_LARGEICON = 0x000000000;
        private const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
        private const uint FILE_ATTRIBUTE_NORMAL = 0x00000080;

        private Icon GetIcon(string path, bool isDirectory)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            uint flags = SHGFI_ICON | SHGFI_LARGEICON;
            uint attr = isDirectory ? FILE_ATTRIBUTE_DIRECTORY : FILE_ATTRIBUTE_NORMAL;
            IntPtr hImg = SHGetFileInfo(path, attr, ref shinfo, (uint)Marshal.SizeOf(shinfo), flags);
            if (hImg == IntPtr.Zero)
                return SystemIcons.WinLogo;
            Icon icon = (Icon)Icon.FromHandle(shinfo.hIcon).Clone();
            DestroyIcon(shinfo.hIcon);
            return icon;
        }

        private class FileItem
        {
            public string DisplayName { get; set; }
            public string Path { get; set; }
            public bool IsDirectory { get; set; }
            public override string ToString() => DisplayName;
        }

        public Form1()
        {
            InitializeComponent();
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(32, 32);
            listView1.LargeImageList = imageList;
            listView1.TileSize = new Size(150, 36);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDrives();
            if (Login.Session.CurrentUser != null)
                NotificationService.CheckNotifications(this, Login.Session.CurrentUser);
        }

        private string Prompt(string text)
        {
            using (var form = new Form())
            {
                var label = new Label { Left = 10, Top = 10, Text = text, Width = 260 };
                var box = new TextBox { Left = 10, Top = 40, Width = 260 };
                var buttonOk = new Button { Text = "OK", Left = 200, Width = 70, Top = 70, DialogResult = DialogResult.OK };
                form.Text = "Ввід";
                form.ClientSize = new Size(280, 110);
                form.Controls.AddRange(new Control[] { label, box, buttonOk });
                form.AcceptButton = buttonOk;
                return form.ShowDialog() == DialogResult.OK ? box.Text : null;
            }
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            var user = Login.Session.CurrentUser;
            if (user != null && user.IsAdmin)
            {
                var text = Prompt("Текст сповіщення:");
                if (!string.IsNullOrWhiteSpace(text))
                    NotificationService.CreateNotification(text, user.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new PersonnelOpen())
            {
                form.ShowDialog();
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Tag is FileItem item)
            {
                if (item.IsDirectory)
                {
                    backHistory.Push(currentPath ?? string.Empty);
                    forwardHistory.Clear();
                    LoadPath(item.Path);
                }
                else
                {
                    try
                    {
                        Process.Start(item.Path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (backHistory.Count > 0)
            {
                forwardHistory.Push(currentPath ?? string.Empty);
                var path = backHistory.Pop();
                if (string.IsNullOrEmpty(path))
                    LoadDrives();
                else
                    LoadPath(path);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (forwardHistory.Count > 0)
            {
                backHistory.Push(currentPath ?? string.Empty);
                var path = forwardHistory.Pop();
                if (string.IsNullOrEmpty(path))
                    LoadDrives();
                else
                    LoadPath(path);
            }
        }

        private void LoadDrives()
        {
            listView1.Items.Clear();
            imageList.Images.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                var displayName = string.IsNullOrEmpty(drive.VolumeLabel)
                    ? drive.Name
                    : $"{drive.VolumeLabel} ({drive.Name.TrimEnd('\\')})";
                var icon = GetIcon(drive.Name, true);
                if (!imageList.Images.ContainsKey(drive.Name))
                    imageList.Images.Add(drive.Name, icon);
                var item = new ListViewItem(displayName)
                {
                    Tag = new FileItem { DisplayName = displayName, Path = drive.Name, IsDirectory = true },
                    ImageKey = drive.Name
                };
                listView1.Items.Add(item);
            }
            currentPath = null;
            UpdateNavButtons();
        }

        private void LoadPath(string path)
        {
            listView1.Items.Clear();
            imageList.Images.Clear();
            try
            {
                var dir = new DirectoryInfo(path);
                if (dir.Parent != null)
                {
                    var parentPath = dir.Parent.FullName;
                    var pIcon = GetIcon(parentPath, true);
                    if (!imageList.Images.ContainsKey(parentPath))
                        imageList.Images.Add(parentPath, pIcon);
                    var parentItem = new ListViewItem("..")
                    {
                        Tag = new FileItem { DisplayName = "..", Path = parentPath, IsDirectory = true },
                        ImageKey = parentPath
                    };
                    listView1.Items.Add(parentItem);
                }
                foreach (var subDir in dir.GetDirectories())
                {
                    var dIcon = GetIcon(subDir.FullName, true);
                    if (!imageList.Images.ContainsKey(subDir.FullName))
                        imageList.Images.Add(subDir.FullName, dIcon);
                    var dirItem = new ListViewItem(subDir.Name)
                    {
                        Tag = new FileItem { DisplayName = subDir.Name, Path = subDir.FullName, IsDirectory = true },
                        ImageKey = subDir.FullName
                    };
                    listView1.Items.Add(dirItem);
                }
                foreach (var file in dir.GetFiles())
                {
                    var fIcon = GetIcon(file.FullName, false);
                    if (!imageList.Images.ContainsKey(file.FullName))
                        imageList.Images.Add(file.FullName, fIcon);
                    var fileItem = new ListViewItem(file.Name)
                    {
                        Tag = new FileItem { DisplayName = file.Name, Path = file.FullName, IsDirectory = false },
                        ImageKey = file.FullName
                    };
                    listView1.Items.Add(fileItem);
                }
                currentPath = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateNavButtons();
        }

        private void UpdateNavButtons()
        {
            btnBack.Enabled = backHistory.Count > 0;
            btnForward.Enabled = forwardHistory.Count > 0;
        }

    }
}
