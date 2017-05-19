namespace WindowsFormsApplication1
{
    partial class stuscore
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
            this.queren = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiugai = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // queren
            // 
            this.queren.Location = new System.Drawing.Point(55, 331);
            this.queren.Name = "queren";
            this.queren.Size = new System.Drawing.Size(75, 23);
            this.queren.TabIndex = 5;
            this.queren.Text = "确定";
            this.queren.UseVisualStyleBackColor = true;
            this.queren.Click += new System.EventHandler(this.queren_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.课程名,
            this.课程成绩,
            this.TeacherName});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(55, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(402, 206);
            this.dataGridView1.TabIndex = 3;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "CID";
            this.CID.HeaderText = "课程编号";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Width = 90;
            // 
            // 课程名
            // 
            this.课程名.DataPropertyName = "CName";
            this.课程名.HeaderText = "课程名";
            this.课程名.Name = "课程名";
            this.课程名.ReadOnly = true;
            this.课程名.Width = 90;
            // 
            // 课程成绩
            // 
            this.课程成绩.DataPropertyName = "Grades";
            this.课程成绩.HeaderText = "课程成绩";
            this.课程成绩.Name = "课程成绩";
            this.课程成绩.ReadOnly = true;
            this.课程成绩.Width = 90;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "教师姓名";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            this.TeacherName.Width = 90;
            // 
            // xiugai
            // 
            this.xiugai.Location = new System.Drawing.Point(223, 330);
            this.xiugai.Name = "xiugai";
            this.xiugai.Size = new System.Drawing.Size(75, 23);
            this.xiugai.TabIndex = 6;
            this.xiugai.Text = "修改";
            this.xiugai.UseVisualStyleBackColor = true;
            this.xiugai.Click += new System.EventHandler(this.xiugai_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "学生姓名",
            "学号"});
            this.comboBox1.Location = new System.Drawing.Point(55, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(382, 28);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 10;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // stuscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 383);
            this.Controls.Add(this.search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.xiugai);
            this.Controls.Add(this.queren);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stuscore";
            this.Text = "学生成绩";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button queren;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.Button xiugai;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button search;
    }
}