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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox4.DisplayMember = "DisplayName";
            LoadDrives();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox4.SelectedItem is FileItem item)
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
            listBox4.Items.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                listBox4.Items.Add(new FileItem { DisplayName = drive.Name, Path = drive.Name, IsDirectory = true });
            }
            currentPath = null;
            UpdateNavButtons();
        }

        private void LoadPath(string path)
        {
            listBox4.Items.Clear();
            try
            {
                var dir = new DirectoryInfo(path);
                if (dir.Parent != null)
                {
                    listBox4.Items.Add(new FileItem { DisplayName = "..", Path = dir.Parent.FullName, IsDirectory = true });
                }
                foreach (var subDir in dir.GetDirectories())
                {
                    listBox4.Items.Add(new FileItem { DisplayName = subDir.Name, Path = subDir.FullName, IsDirectory = true });
                }
                foreach (var file in dir.GetFiles())
                {
                    listBox4.Items.Add(new FileItem { DisplayName = file.Name, Path = file.FullName, IsDirectory = false });
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
