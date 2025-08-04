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

namespace Personal_
{
    public partial class Form1 : Form
    {
        private Stack<string> backHistory = new Stack<string>();
        private Stack<string> forwardHistory = new Stack<string>();
        private string currentPath;
        private ImageList imageList = new ImageList();

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
        }

        private void button8_Click(object sender, EventArgs e)
        {

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
                try
                {
                    var icon = Icon.ExtractAssociatedIcon(drive.Name);
                    if (icon != null && !imageList.Images.ContainsKey(drive.Name))
                        imageList.Images.Add(drive.Name, icon);
                }
                catch { }
                var item = new ListViewItem(drive.Name)
                {
                    Tag = new FileItem { DisplayName = drive.Name, Path = drive.Name, IsDirectory = true },
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
                    try
                    {
                        var pIcon = Icon.ExtractAssociatedIcon(parentPath);
                        if (pIcon != null && !imageList.Images.ContainsKey(parentPath))
                            imageList.Images.Add(parentPath, pIcon);
                    }
                    catch { }
                    var parentItem = new ListViewItem("..")
                    {
                        Tag = new FileItem { DisplayName = "..", Path = parentPath, IsDirectory = true },
                        ImageKey = parentPath
                    };
                    listView1.Items.Add(parentItem);
                }
                foreach (var subDir in dir.GetDirectories())
                {
                    try
                    {
                        var dIcon = Icon.ExtractAssociatedIcon(subDir.FullName);
                        if (dIcon != null && !imageList.Images.ContainsKey(subDir.FullName))
                            imageList.Images.Add(subDir.FullName, dIcon);
                    }
                    catch { }
                    var dirItem = new ListViewItem(subDir.Name)
                    {
                        Tag = new FileItem { DisplayName = subDir.Name, Path = subDir.FullName, IsDirectory = true },
                        ImageKey = subDir.FullName
                    };
                    listView1.Items.Add(dirItem);
                }
                foreach (var file in dir.GetFiles())
                {
                    try
                    {
                        var fIcon = Icon.ExtractAssociatedIcon(file.FullName);
                        if (fIcon != null && !imageList.Images.ContainsKey(file.FullName))
                            imageList.Images.Add(file.FullName, fIcon);
                    }
                    catch { }
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
