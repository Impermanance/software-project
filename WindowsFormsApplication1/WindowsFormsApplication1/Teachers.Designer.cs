namespace WindowsFormsApplication1
{
    partial class Teachers
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
            this.基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入学生成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生基本信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息ToolStripMenuItem,
            this.录入学生成绩ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基本信息ToolStripMenuItem
            // 
            this.基本信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息查询ToolStripMenuItem});
            this.基本信息ToolStripMenuItem.Name = "基本信息ToolStripMenuItem";
            this.基本信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.基本信息ToolStripMenuItem.Text = "基本信息";
            // 
            // 个人信息查询ToolStripMenuItem
            // 
            this.个人信息查询ToolStripMenuItem.Name = "个人信息查询ToolStripMenuItem";
            this.个人信息查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.个人信息查询ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.个人信息查询ToolStripMenuItem.Text = "个人信息查询";
            this.个人信息查询ToolStripMenuItem.Click += new System.EventHandler(this.个人信息查询ToolStripMenuItem_Click);
            // 
            // 录入学生成绩ToolStripMenuItem
            // 
            this.录入学生成绩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生基本信息查询ToolStripMenuItem,
            this.学生成绩查询ToolStripMenuItem,
            this.录入成绩ToolStripMenuItem,
            this.成绩修改ToolStripMenuItem});
            this.录入学生成绩ToolStripMenuItem.Name = "录入学生成绩ToolStripMenuItem";
            this.录入学生成绩ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.录入学生成绩ToolStripMenuItem.Text = "学生成绩管理";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 学生基本信息查询ToolStripMenuItem
            // 
            this.学生基本信息查询ToolStripMenuItem.Name = "学生基本信息查询ToolStripMenuItem";
            this.学生基本信息查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.学生基本信息查询ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.学生基本信息查询ToolStripMenuItem.Text = "学生基本信息查询";
            // 
            // 学生成绩查询ToolStripMenuItem
            // 
            this.学生成绩查询ToolStripMenuItem.Name = "学生成绩查询ToolStripMenuItem";
            this.学生成绩查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.学生成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.学生成绩查询ToolStripMenuItem.Text = "学生成绩查询";
            // 
            // 录入成绩ToolStripMenuItem
            // 
            this.录入成绩ToolStripMenuItem.Name = "录入成绩ToolStripMenuItem";
            this.录入成绩ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.录入成绩ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.录入成绩ToolStripMenuItem.Text = "录入成绩";
            // 
            // 成绩修改ToolStripMenuItem
            // 
            this.成绩修改ToolStripMenuItem.Name = "成绩修改ToolStripMenuItem";
            this.成绩修改ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.成绩修改ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.成绩修改ToolStripMenuItem.Text = "成绩修改";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 500);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入学生成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生基本信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;

    }
}