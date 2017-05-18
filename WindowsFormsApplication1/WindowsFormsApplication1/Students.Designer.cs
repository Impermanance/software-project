namespace WindowsFormsApplication1
{
    partial class Students
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
            this.个人信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已选课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息管理ToolStripMenuItem
            // 
            this.个人信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息查询ToolStripMenuItem});
            this.个人信息管理ToolStripMenuItem.Name = "个人信息管理ToolStripMenuItem";
            this.个人信息管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.个人信息管理ToolStripMenuItem.Text = "基本信息";
            // 
            // 个人信息查询ToolStripMenuItem
            // 
            this.个人信息查询ToolStripMenuItem.Name = "个人信息查询ToolStripMenuItem";
            this.个人信息查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.个人信息查询ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.个人信息查询ToolStripMenuItem.Text = "个人信息查询";
            this.个人信息查询ToolStripMenuItem.Click += new System.EventHandler(this.个人信息查询ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看课程ToolStripMenuItem,
            this.已选课程ToolStripMenuItem,
            this.退课ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 查看课程ToolStripMenuItem
            // 
            this.查看课程ToolStripMenuItem.Name = "查看课程ToolStripMenuItem";
            this.查看课程ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.查看课程ToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.查看课程ToolStripMenuItem.Text = "查看课程";
            this.查看课程ToolStripMenuItem.Click += new System.EventHandler(this.查看课程ToolStripMenuItem_Click);
            // 
            // 已选课程ToolStripMenuItem
            // 
            this.已选课程ToolStripMenuItem.Name = "已选课程ToolStripMenuItem";
            this.已选课程ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.已选课程ToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.已选课程ToolStripMenuItem.Text = "已选课程";
            this.已选课程ToolStripMenuItem.Click += new System.EventHandler(this.已选课程ToolStripMenuItem_Click);
            // 
            // 退课ToolStripMenuItem
            // 
            this.退课ToolStripMenuItem.Name = "退课ToolStripMenuItem";
            this.退课ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.退课ToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.退课ToolStripMenuItem.Text = "退课";
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人成绩ToolStripMenuItem});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 个人成绩ToolStripMenuItem
            // 
            this.个人成绩ToolStripMenuItem.Name = "个人成绩ToolStripMenuItem";
            this.个人成绩ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.个人成绩ToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.个人成绩ToolStripMenuItem.Text = "个人成绩";
            this.个人成绩ToolStripMenuItem.Click += new System.EventHandler(this.个人成绩ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 465);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Students";
            this.Text = "Students";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已选课程ToolStripMenuItem;
    }
}