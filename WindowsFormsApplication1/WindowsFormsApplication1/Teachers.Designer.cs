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
            this.任课信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入学生成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生基本信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(518, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基本信息ToolStripMenuItem
            // 
            this.基本信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息查询ToolStripMenuItem,
            this.任课信息查询ToolStripMenuItem});
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
            // 任课信息查询ToolStripMenuItem
            // 
            this.任课信息查询ToolStripMenuItem.Name = "任课信息查询ToolStripMenuItem";
            this.任课信息查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.任课信息查询ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.任课信息查询ToolStripMenuItem.Text = "任课信息查询";
            this.任课信息查询ToolStripMenuItem.Click += new System.EventHandler(this.任课信息查询ToolStripMenuItem_Click);
            // 
            // 录入学生成绩ToolStripMenuItem
            // 
            this.录入学生成绩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生基本信息查询ToolStripMenuItem,
            this.学生成绩查询ToolStripMenuItem,
            this.录入成绩ToolStripMenuItem,
            this.删除成绩ToolStripMenuItem});
            this.录入学生成绩ToolStripMenuItem.Name = "录入学生成绩ToolStripMenuItem";
            this.录入学生成绩ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.录入学生成绩ToolStripMenuItem.Text = "学生成绩管理";
            // 
            // 学生基本信息查询ToolStripMenuItem
            // 
            this.学生基本信息查询ToolStripMenuItem.Name = "学生基本信息查询ToolStripMenuItem";
            this.学生基本信息查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.学生基本信息查询ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.学生基本信息查询ToolStripMenuItem.Text = "学生基本信息查询";
            this.学生基本信息查询ToolStripMenuItem.Click += new System.EventHandler(this.学生基本信息查询ToolStripMenuItem_Click);
            // 
            // 学生成绩查询ToolStripMenuItem
            // 
            this.学生成绩查询ToolStripMenuItem.Name = "学生成绩查询ToolStripMenuItem";
            this.学生成绩查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.学生成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.学生成绩查询ToolStripMenuItem.Text = "学生成绩查询";
            this.学生成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩查询ToolStripMenuItem_Click);
            // 
            // 录入成绩ToolStripMenuItem
            // 
            this.录入成绩ToolStripMenuItem.Name = "录入成绩ToolStripMenuItem";
            this.录入成绩ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.录入成绩ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.录入成绩ToolStripMenuItem.Text = "录入成绩";
            this.录入成绩ToolStripMenuItem.Click += new System.EventHandler(this.录入成绩ToolStripMenuItem_Click);
            // 
            // 删除成绩ToolStripMenuItem
            // 
            this.删除成绩ToolStripMenuItem.Name = "删除成绩ToolStripMenuItem";
            this.删除成绩ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.删除成绩ToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.删除成绩ToolStripMenuItem.Text = "删除成绩";
            this.删除成绩ToolStripMenuItem.Click += new System.EventHandler(this.删除成绩ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "欢迎使用本学生信息管理平台";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "现在是";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(310, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "老师。";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(186, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 50);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "欢迎您，";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 354);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teachers";
            this.Text = "教师界面";
            this.Load += new System.EventHandler(this.Teachers_Load);
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
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任课信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除成绩ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

    }
}