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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftTW = new System.Windows.Forms.TreeView();
            this.leftContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createDir = new System.Windows.Forms.ToolStripButton();
            this.fileCreate = new System.Windows.Forms.ToolStripButton();
            this.rename = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.ToolStripButton();
            this.copy = new System.Windows.Forms.ToolStripButton();
            this.path = new System.Windows.Forms.TextBox();
            this.path1 = new System.Windows.Forms.TextBox();
            this.rightTW = new System.Windows.Forms.TreeView();
            this.rightContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.leftContextMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.rightContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftTW
            // 
            this.leftTW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftTW.ContextMenuStrip = this.leftContextMenu;
            this.leftTW.Location = new System.Drawing.Point(12, 226);
            this.leftTW.Name = "leftTW";
            this.leftTW.Size = new System.Drawing.Size(758, 831);
            this.leftTW.TabIndex = 0;
            this.leftTW.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.leftTW_AfterLabelEdit);
            this.leftTW.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.leftTW_AfterSelect);
            this.leftTW.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.leftTW_NodeMouseDoubleClick);
            // 
            // leftContextMenu
            // 
            this.leftContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.leftContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.скопироватьToolStripMenuItem,
            this.свойстваToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.leftContextMenu.Name = "leftContextMenu";
            this.leftContextMenu.Size = new System.Drawing.Size(265, 194);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.папкуToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // папкуToolStripMenuItem
            // 
            this.папкуToolStripMenuItem.Name = "папкуToolStripMenuItem";
            this.папкуToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.папкуToolStripMenuItem.Text = "Папку";
            this.папкуToolStripMenuItem.Click += new System.EventHandler(this.папкуToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.скопироватьToolStripMenuItem.Text = "Скопировать";
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.удалитьToolStripMenuItem.Text = "Удалить";
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
            this.copy,
            this.settings});
            this.toolStrip1.Location = new System.Drawing.Point(12, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(342, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createDir
            // 
            this.createDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createDir.Image = ((System.Drawing.Image)(resources.GetObject("createDir.Image")));
            this.createDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createDir.Name = "createDir";
            this.createDir.Size = new System.Drawing.Size(46, 36);
            this.createDir.Text = "Создать папку";
            this.createDir.Click += new System.EventHandler(this.CreateDir_Click);
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
            this.rightTW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rightTW.ContextMenuStrip = this.rightContextMenu;
            this.rightTW.Location = new System.Drawing.Point(912, 226);
            this.rightTW.Name = "rightTW";
            this.rightTW.Size = new System.Drawing.Size(758, 831);
            this.rightTW.TabIndex = 3;
            this.rightTW.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rightTW_AfterSelect);
            this.rightTW.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.rightTW_NodeMouseDoubleClick);
            // 
            // rightContextMenu
            // 
            this.rightContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.rightContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.rightContextMenu.Name = "leftContextMenuStrip";
            this.rightContextMenu.Size = new System.Drawing.Size(265, 194);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 38);
            this.toolStripMenuItem1.Text = "Создать";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 44);
            this.toolStripMenuItem2.Text = "Папку";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 44);
            this.toolStripMenuItem3.Text = "Файл";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(264, 38);
            this.toolStripMenuItem4.Text = "Переименовать";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(264, 38);
            this.toolStripMenuItem5.Text = "Скопировать";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(264, 38);
            this.toolStripMenuItem6.Text = "Свойства";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(264, 38);
            this.toolStripMenuItem7.Text = "Удалить";
            // 
            // settings
            // 
            this.settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(46, 44);
            this.settings.Text = "Настройки";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1725, 1069);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.rightTW);
            this.Controls.Add(this.path);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.leftTW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Total Chumander";
            this.leftContextMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.rightContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton copy;
        private System.Windows.Forms.ContextMenuStrip leftContextMenu;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rightContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripButton settings;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

