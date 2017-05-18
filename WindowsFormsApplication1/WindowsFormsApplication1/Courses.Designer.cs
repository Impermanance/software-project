namespace WindowsFormsApplication1
{
    partial class courses
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
            this.coursename = new System.Windows.Forms.TextBox();
            this.serach = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.选课 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.课程ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上课时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上课地点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // coursename
            // 
            this.coursename.Location = new System.Drawing.Point(175, 26);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(159, 25);
            this.coursename.TabIndex = 0;
            // 
            // serach
            // 
            this.serach.Location = new System.Drawing.Point(370, 28);
            this.serach.Name = "serach";
            this.serach.Size = new System.Drawing.Size(75, 23);
            this.serach.TabIndex = 1;
            this.serach.Text = "搜索课程";
            this.serach.UseVisualStyleBackColor = true;
            this.serach.Click += new System.EventHandler(this.serach_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "课程名",
            "课程ID"});
            this.comboBox1.Location = new System.Drawing.Point(65, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(484, 28);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(108, 23);
            this.display.TabIndex = 5;
            this.display.Text = "显示所有课程";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "全选";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "全不选";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "选课";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选课,
            this.课程ID,
            this.课程名,
            this.上课时间,
            this.上课地点,
            this.教师});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(590, 321);
            this.dataGridView1.TabIndex = 9;
            // 
            // 选课
            // 
            this.选课.HeaderText = "选课";
            this.选课.Name = "选课";
            this.选课.Width = 50;
            // 
            // 课程ID
            // 
            this.课程ID.DataPropertyName = "CID";
            this.课程ID.HeaderText = "课程ID";
            this.课程ID.Name = "课程ID";
            // 
            // 课程名
            // 
            this.课程名.DataPropertyName = "CName";
            this.课程名.HeaderText = "课程名";
            this.课程名.Name = "课程名";
            // 
            // 上课时间
            // 
            this.上课时间.DataPropertyName = "Time";
            this.上课时间.HeaderText = "上课时间";
            this.上课时间.Name = "上课时间";
            // 
            // 上课地点
            // 
            this.上课地点.DataPropertyName = "Didian";
            this.上课地点.HeaderText = "上课地点";
            this.上课地点.Name = "上课地点";
            // 
            // 教师
            // 
            this.教师.DataPropertyName = "Teacher";
            this.教师.HeaderText = "教师";
            this.教师.Name = "教师";
            this.教师.Width = 95;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(393, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "确认";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 431);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.serach);
            this.Controls.Add(this.coursename);
            this.Name = "courses";
            this.Text = "课程展示";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coursename;
        private System.Windows.Forms.Button serach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选课;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上课时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上课地点;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教师;
        private System.Windows.Forms.Button button5;
    }
}