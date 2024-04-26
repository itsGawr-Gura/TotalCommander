namespace TotalCommander
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftTW = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createDir = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.ToolStripButton();
            this.rename = new System.Windows.Forms.ToolStripButton();
            this.fileCreate = new System.Windows.Forms.ToolStripButton();
            this.path = new System.Windows.Forms.TextBox();
            this.path1 = new System.Windows.Forms.TextBox();
            this.rightTW = new System.Windows.Forms.TreeView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.copy = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftTW
            // 
            this.leftTW.Location = new System.Drawing.Point(12, 226);
            this.leftTW.Name = "leftTW";
            this.leftTW.Size = new System.Drawing.Size(758, 831);
            this.leftTW.TabIndex = 0;
            this.leftTW.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.leftTW_AfterLabelEdit);
            this.leftTW.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.leftTW_AfterSelect);
            this.leftTW.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.leftTW_NodeMouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDir,
            this.fileCreate,
            this.rename,
            this.delete,
            this.copy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(296, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createDir
            // 
            this.createDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createDir.Image = ((System.Drawing.Image)(resources.GetObject("createDir.Image")));
            this.createDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createDir.Name = "createDir";
            this.createDir.Size = new System.Drawing.Size(46, 44);
            this.createDir.Text = "Создать папку";
            this.createDir.Click += new System.EventHandler(this.CreateDir_Click);
            // 
            // delete
            // 
            this.delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(46, 44);
            this.delete.Text = "Удалить";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // rename
            // 
            this.rename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rename.Image = ((System.Drawing.Image)(resources.GetObject("rename.Image")));
            this.rename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(46, 44);
            this.rename.Text = "Переименовать";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // fileCreate
            // 
            this.fileCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileCreate.Image = ((System.Drawing.Image)(resources.GetObject("fileCreate.Image")));
            this.fileCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileCreate.Name = "fileCreate";
            this.fileCreate.Size = new System.Drawing.Size(46, 44);
            this.fileCreate.Text = "Создать файл";
            this.fileCreate.Click += new System.EventHandler(this.fileCreate_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(26, 177);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(654, 31);
            this.path.TabIndex = 2;
            // 
            // path1
            // 
            this.path1.Location = new System.Drawing.Point(926, 177);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(654, 31);
            this.path1.TabIndex = 4;
            // 
            // rightTW
            // 
            this.rightTW.Location = new System.Drawing.Point(912, 226);
            this.rightTW.Name = "rightTW";
            this.rightTW.Size = new System.Drawing.Size(758, 831);
            this.rightTW.TabIndex = 3;
            this.rightTW.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rightTW_AfterSelect);
            this.rightTW.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.rightTW_NodeMouseDoubleClick);
            // 
            // copy
            // 
            this.copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
            this.copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(46, 44);
            this.copy.Text = "Скопировать";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 1069);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.rightTW);
            this.Controls.Add(this.path);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.leftTW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView leftTW;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton createDir;
        private System.Windows.Forms.ToolStripButton delete;
        private System.Windows.Forms.ToolStripButton rename;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.TreeView rightTW;
        private System.Windows.Forms.ToolStripButton fileCreate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton copy;
    }
}

