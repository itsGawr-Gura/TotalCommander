using System;
using System.IO;
using System.Windows.Forms;

namespace TotalCommander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDrives();
            LoadDrives1();
        }

        private void LoadDrives()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                leftTW.Nodes.Add(node);
            }
        }
        private void LoadDrives1()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                rightTW.Nodes.Add(node);
            }
        }
        private void leftTW_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            PopulateTreeView(e.Node, path);
        }
        private void PopulateTreeView(TreeNode parentNode, System.Windows.Forms.TextBox textBox)
        {
            try
            {
                DirectoryInfo directory = (DirectoryInfo)parentNode.Tag;
                parentNode.Nodes.Clear();

                foreach (var dir in directory.GetDirectories())
                {
                    TreeNode node = new TreeNode(dir.Name);
                    node.Tag = dir;
                    parentNode.Nodes.Add(node);
                }

                foreach (var file in directory.GetFiles())
                {
                    TreeNode node = new TreeNode(file.Name);
                    node.Tag = file;
                    parentNode.Nodes.Add(node);
                }

                textBox.Text = directory.FullName; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void leftTW_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                PopulateTreeView(e.Node, path);
            }
            else if (e.Node.Tag is FileInfo)
            {
                
                FileInfo file = (FileInfo)e.Node.Tag;
                System.Diagnostics.Process.Start(file.FullName);
            }
        }

        private void CreateDir_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = leftTW.SelectedNode;
            if (selectedNode != null && selectedNode.Tag is DirectoryInfo)
            {
                string newDirPath = Path.Combine(((DirectoryInfo)selectedNode.Tag).FullName, "New Directory");
                if (!Directory.Exists(newDirPath))
                {
                    Directory.CreateDirectory(newDirPath);
                    PopulateTreeView(selectedNode, path);
                }
                else
                {
                    MessageBox.Show("Directory already exists.");
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = leftTW.SelectedNode;
            if (selectedNode != null)
            {
                if (selectedNode.Tag is DirectoryInfo)
                {
                    Directory.Delete(((DirectoryInfo)selectedNode.Tag).FullName, true);
                }
                else if (selectedNode.Tag is FileInfo)
                {
                    File.Delete(((FileInfo)selectedNode.Tag).FullName);
                }
                TreeNode parentNode = selectedNode.Parent;
                selectedNode.Remove();
                if (parentNode != null)
                {
                    PopulateTreeView(parentNode, path);
                }
            }
        }

        private void rename_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = leftTW.SelectedNode;
            if (selectedNode != null)
            {
                leftTW.LabelEdit = true;
                if (!selectedNode.IsEditing)
                {
                    selectedNode.BeginEdit();
                }
            }
        }

        private void leftTW_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node != null)
            {
                string newPath = Path.Combine(Path.GetDirectoryName(((FileSystemInfo)e.Node.Tag).FullName), e.Label);
                try
                {
                    if (e.Node.Tag is DirectoryInfo)
                    {
                        Directory.Move(((DirectoryInfo)e.Node.Tag).FullName, newPath);
                    }
                    else if (e.Node.Tag is FileInfo)
                    {
                        File.Move(((FileInfo)e.Node.Tag).FullName, newPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                e.CancelEdit = true;
                e.Node.EndEdit(false);
                e.Node.Tag = new DirectoryInfo(newPath);
            }
        }

        private void rightTW_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PopulateTreeView(e.Node, path1);
        }

        private void rightTW_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                PopulateTreeView(e.Node, path);
            }
            else if (e.Node.Tag is FileInfo)
            {

                FileInfo file = (FileInfo)e.Node.Tag;
                System.Diagnostics.Process.Start(file.FullName);
            }
        }
    }
}
