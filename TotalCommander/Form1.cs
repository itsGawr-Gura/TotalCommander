using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;

namespace TotalCommander
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadDrives();
            ContextMenuStrip leftContextMenu = new ContextMenuStrip();
            leftContextMenu.Items.Add("Создать папку", null, CreateDir_Click);
            leftContextMenu.Items.Add("Удалить", null, delete_Click);
            leftContextMenu.Items.Add("Переименовать", null, rename_Click);
            leftContextMenu.Items.Add("Копировать", null, copy_Click);
            leftContextMenu.Items.Add("Просмотреть свойства файла", null, ShowFilePropertiesLeft);
            leftContextMenu.Items.Add("Сжать файл в архив", null, LeftCompressFile_Click);
            leftTW.ContextMenuStrip = leftContextMenu;

            ContextMenuStrip rightContextMenu = new ContextMenuStrip();
            rightContextMenu.Items.Add("Создать папку", null, CreateDir_Click);
            rightContextMenu.Items.Add("Удалить", null, delete_Click);
            rightContextMenu.Items.Add("Переименовать", null, rename_Click);
            rightContextMenu.Items.Add("Копировать", null, copyRight);
            rightContextMenu.Items.Add("Просмотреть свойства файла", null, ShowFilePropertiesRight);
            rightContextMenu.Items.Add("Сжать файл в архив", null, RightCompressFile_Click);
            rightTW.ContextMenuStrip = rightContextMenu;
        }
        
        private void ShowFilePropertiesLeft(object sender, EventArgs e)
        {
            string filePath = path.Text;
            GetFileInformation(filePath);
        }
        private void ShowFilePropertiesRight(object sender, EventArgs e)
        {
            string filePath = path1.Text;
            GetFileInformation(filePath);
        }
        private void GetFileInformation(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            try
            {
                string message = $"Имя файла: {fileInfo.Name}\n" +
                         $"Полный путь: {fileInfo.FullName}\n" +
                         $"Дата создания: {fileInfo.CreationTime}\n" +
                         $"Последний доступ: {fileInfo.LastAccessTime}\n" +
                         $"Последнее изменение: {fileInfo.LastWriteTime}\n" +
                         $"Размер файла: {fileInfo.Length} байт";

                MessageBox.Show(message, "Информация о файле", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Вы выбрали не файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void LeftCompressFile_Click(object sender, EventArgs e)
        {
            string filePath = path.Text;
            string zipPath = Path.ChangeExtension(filePath, ".zip");

            using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
            {
                if (File.Exists(filePath))
                {
                    zip.AddFile(filePath, "");
                }
                else if (Directory.Exists(filePath))
                {
                    zip.AddDirectory(filePath, "");
                }

                zip.Save(zipPath);
            }

            MessageBox.Show("Файл(ы) успешно сжат(ы) в архив!", "Сжатие", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void RightCompressFile_Click(object sender, EventArgs e)
        {
            string filePath = path1.Text;
            string zipPath = Path.ChangeExtension(filePath, ".zip");

            using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
            {
                if (File.Exists(filePath))
                {
                    zip.AddFile(filePath, "");
                }
                else if (Directory.Exists(filePath))
                {
                    zip.AddDirectory(filePath, "");
                }

                zip.Save(zipPath);
            }

            MessageBox.Show("Файл(ы) успешно сжат(ы) в архив!", "Сжатие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDrives()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                leftTW.Nodes.Add(node);

            }
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                rightTW.Nodes.Add(node);
            }
        }

        private void UpdateTreeView(TreeView treeView, TreeNode selectedNode)
        {
            if (selectedNode != null)
            {
                PopulateTreeView(selectedNode, treeView == leftTW ? path : path1);
            }
        }
        private void leftTW_AfterSelect(object sender, TreeViewEventArgs e)
        {

            UpdateTreeView(leftTW, e.Node);
        }
        private void PopulateTreeView(TreeNode parentNode, System.Windows.Forms.TextBox textBox)
        {
            try
            {
                if (parentNode.Tag is DirectoryInfo directory)
                {
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
                else if (parentNode.Tag is FileInfo file)
                {

                    textBox.Text = file.FullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void leftTW_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                UpdateTreeView(leftTW, e.Node);
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
                string newDirPath = Path.Combine(((DirectoryInfo)selectedNode.Tag).FullName, "Новая папка");
                if (!Directory.Exists(newDirPath))
                {
                    Directory.CreateDirectory(newDirPath);
                    PopulateTreeView(selectedNode, path);
                }
                else
                {
                    MessageBox.Show("Папка с таким названием уже существует.");
                }


            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы подтверждаете удаление?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        }

        private void rename_Click(object sender, EventArgs e)
        {
            if (leftTW.Focused)
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
            else
            {
                TreeNode selectedNode = rightTW.SelectedNode;
                if (selectedNode != null)
                {
                    rightTW.LabelEdit = true;
                    if (!selectedNode.IsEditing)
                    {
                        selectedNode.BeginEdit();
                    }

                }
            }



        }

        private void leftTW_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node != null)
            {
                try
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
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                    e.CancelEdit = true;
                    e.Node.EndEdit(false);
                    e.Node.Tag = new DirectoryInfo(newPath);
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void rightTW_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateTreeView(rightTW, e.Node);
        }

        private void rightTW_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                UpdateTreeView(rightTW, e.Node);
            }
            else if (e.Node.Tag is FileInfo)
            {

                FileInfo file = (FileInfo)e.Node.Tag;
                System.Diagnostics.Process.Start(file.FullName);
            }
        }

        private void fileCreate_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = leftTW.SelectedNode;
            if (selectedNode != null && selectedNode.Tag is DirectoryInfo)
            {
                string newFilePath = Path.Combine(((DirectoryInfo)selectedNode.Tag).FullName, "НовыйФайл.txt");
                if (!File.Exists(newFilePath))
                {
                    try
                    {

                        using (File.Create(newFilePath)) { }


                        PopulateTreeView(selectedNode, path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при создании файла: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Файл с таким названием уже существует.");
                }
            }
        }
        private void CopyFiles(TreeNodeCollection nodes)
        {
            if (nodes == leftTW.SelectedNode.Nodes)
            {
                foreach (TreeNode node in nodes)
                {
                    if (node.Tag is DirectoryInfo sourceDir)
                    {

                        string targetDirPath = Path.Combine(rightTW.SelectedNode.FullPath, sourceDir.Name);
                        if (!Directory.Exists(targetDirPath))
                        {
                            Directory.CreateDirectory(targetDirPath);
                        }
                        CopyFiles(node.Nodes);
                    }
                    else if (node.Tag is FileInfo sourceFile)
                    {

                        string targetFilePath = Path.Combine(rightTW.SelectedNode.FullPath, sourceFile.Name);
                        File.Copy(sourceFile.FullName, targetFilePath, true);
                    }
                }
            }
            else
            {
                foreach (TreeNode node in nodes)
                {
                    if (node.Tag is DirectoryInfo sourceDir)
                    {

                        string targetDirPath = Path.Combine(leftTW.SelectedNode.FullPath, sourceDir.Name);
                        if (!Directory.Exists(targetDirPath))
                        {
                            Directory.CreateDirectory(targetDirPath);
                        }
                        CopyFiles(node.Nodes);
                    }
                    else if (node.Tag is FileInfo sourceFile)
                    {

                        string targetFilePath = Path.Combine(leftTW.SelectedNode.FullPath, sourceFile.Name);
                        File.Copy(sourceFile.FullName, targetFilePath, true);
                    }
                }
            }

        }
        private void copy_Click(object sender, EventArgs e)
        {
            CopyFiles(leftTW.SelectedNode.Nodes);
            UpdateTreeView(rightTW, rightTW.SelectedNode);
        }
        private void copyRight(object sender, EventArgs e)
        {
            CopyFiles(rightTW.SelectedNode.Nodes);
            UpdateTreeView(leftTW, leftTW.SelectedNode);
        }

        private void папкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = leftTW.SelectedNode;
            if (selectedNode != null && selectedNode.Tag is DirectoryInfo)
            {
                string newDirPath = Path.Combine(((DirectoryInfo)selectedNode.Tag).FullName, "Новая папка");
                if (!Directory.Exists(newDirPath))
                {
                    Directory.CreateDirectory(newDirPath);
                    PopulateTreeView(selectedNode, path);
                }
                else
                {
                    MessageBox.Show("Папка с таким названием уже существует.");
                }
            }
        }
    }

}
