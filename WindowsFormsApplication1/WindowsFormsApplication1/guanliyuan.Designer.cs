namespace WindowsFormsApplication1
{
    partial class guanliyuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看教师信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入教师信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息管理ToolStripMenuItem,
            this.教师信息管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改学生信息ToolStripMenuItem,
            this.录入学生信息ToolStripMenuItem});
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.修改学生信息ToolStripMenuItem.Text = "查看学生信息";
            this.修改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.修改学生信息ToolStripMenuItem_Click);
            // 
            // 录入学生信息ToolStripMenuItem
            // 
            this.录入学生信息ToolStripMenuItem.Name = "录入学生信息ToolStripMenuItem";
            this.录入学生信息ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.录入学生信息ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.录入学生信息ToolStripMenuItem.Text = "录入学生信息";
            this.录入学生信息ToolStripMenuItem.Click += new System.EventHandler(this.录入学生信息ToolStripMenuItem_Click);
            // 
            // 教师信息管理ToolStripMenuItem
            // 
            this.教师信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看教师信息ToolStripMenuItem,
            this.录入教师信息ToolStripMenuItem});
            this.教师信息管理ToolStripMenuItem.Name = "教师信息管理ToolStripMenuItem";
            this.教师信息管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.教师信息管理ToolStripMenuItem.Text = "教师信息管理";
            // 
            // 查看教师信息ToolStripMenuItem
            // 
            this.查看教师信息ToolStripMenuItem.Name = "查看教师信息ToolStripMenuItem";
            this.查看教师信息ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.查看教师信息ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.查看教师信息ToolStripMenuItem.Text = "查看教师信息";
            // 
            // 录入教师信息ToolStripMenuItem
            // 
            this.录入教师信息ToolStripMenuItem.Name = "录入教师信息ToolStripMenuItem";
            this.录入教师信息ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.录入教师信息ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.录入教师信息ToolStripMenuItem.Text = "录入教师信息";
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看课程ToolStripMenuItem,
            this.新增课程ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 查看课程ToolStripMenuItem
            // 
            this.查看课程ToolStripMenuItem.Name = "查看课程ToolStripMenuItem";
            this.查看课程ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.查看课程ToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.查看课程ToolStripMenuItem.Text = "查看课程";
            // 
            // 新增课程ToolStripMenuItem
            // 
            this.新增课程ToolStripMenuItem.Name = "新增课程ToolStripMenuItem";
            this.新增课程ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.新增课程ToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.新增课程ToolStripMenuItem.Text = "新增课程";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // guanliyuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 460);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "guanliyuan";
            this.Text = "管理员界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看教师信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入教师信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}