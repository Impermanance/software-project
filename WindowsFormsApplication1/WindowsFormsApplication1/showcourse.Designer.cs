namespace WindowsFormsApplication1
{
    partial class showcourse
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
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tuike = new System.Windows.Forms.Button();
            this.queren = new System.Windows.Forms.Button();
            this.tuichu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(1, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(617, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "选择";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CID";
            this.Column2.HeaderText = "课程编号";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CName";
            this.Column3.HeaderText = "课程名";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Time";
            this.Column4.HeaderText = "    上课时间";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Didian";
            this.Column5.HeaderText = "上课地点";
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Teacher";
            this.Column6.HeaderText = "教师姓名";
            this.Column6.Name = "Column6";
            this.Column6.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "全选";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "全不选";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // tuike
            // 
            this.tuike.Location = new System.Drawing.Point(275, 358);
            this.tuike.Name = "tuike";
            this.tuike.Size = new System.Drawing.Size(75, 23);
            this.tuike.TabIndex = 3;
            this.tuike.Text = "退课";
            this.tuike.UseVisualStyleBackColor = true;
            // 
            // queren
            // 
            this.queren.Location = new System.Drawing.Point(409, 359);
            this.queren.Name = "queren";
            this.queren.Size = new System.Drawing.Size(75, 23);
            this.queren.TabIndex = 4;
            this.queren.Text = "确认";
            this.queren.UseVisualStyleBackColor = true;
            // 
            // tuichu
            // 
            this.tuichu.Location = new System.Drawing.Point(543, 358);
            this.tuichu.Name = "tuichu";
            this.tuichu.Size = new System.Drawing.Size(75, 23);
            this.tuichu.TabIndex = 5;
            this.tuichu.Text = "退出";
            this.tuichu.UseVisualStyleBackColor = true;
            // 
            // showcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 421);
            this.Controls.Add(this.tuichu);
            this.Controls.Add(this.queren);
            this.Controls.Add(this.tuike);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "showcourse";
            this.Text = "选课展示";
            this.Load += new System.EventHandler(this.showcourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tuike;
        private System.Windows.Forms.Button queren;
        private System.Windows.Forms.Button tuichu;
    }
}