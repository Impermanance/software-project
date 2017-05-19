namespace WindowsFormsApplication1
{
    partial class managerseecourse
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.选课 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.课程ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上课时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上课地点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serach = new System.Windows.Forms.Button();
            this.coursename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选课,
            this.课程ID,
            this.课程名,
            this.上课时间,
            this.上课地点,
            this.教师});
            this.dataGridView1.Location = new System.Drawing.Point(48, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(590, 321);
            this.dataGridView1.TabIndex = 19;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "修改课程";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "删除课程";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(520, 24);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(108, 23);
            this.display.TabIndex = 15;
            this.display.Text = "显示所有课程";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "课程名",
            "课程ID"});
            this.comboBox1.Location = new System.Drawing.Point(101, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // serach
            // 
            this.serach.Location = new System.Drawing.Point(406, 24);
            this.serach.Name = "serach";
            this.serach.Size = new System.Drawing.Size(75, 23);
            this.serach.TabIndex = 12;
            this.serach.Text = "搜索课程";
            this.serach.UseVisualStyleBackColor = true;
            this.serach.Click += new System.EventHandler(this.serach_Click);
            // 
            // coursename
            // 
            this.coursename.Location = new System.Drawing.Point(211, 22);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(159, 25);
            this.coursename.TabIndex = 11;
            // 
            // managerseecourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.serach);
            this.Controls.Add(this.coursename);
            this.Name = "managerseecourse";
            this.Text = "managerseecourse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选课;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上课时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上课地点;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教师;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button serach;
        private System.Windows.Forms.TextBox coursename;
    }
}