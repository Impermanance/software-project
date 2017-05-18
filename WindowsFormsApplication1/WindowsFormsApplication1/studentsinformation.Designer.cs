namespace WindowsFormsApplication1
{
    partial class studentsinformation
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
            this.pwdd = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.Label();
            this.telp = new System.Windows.Forms.TextBox();
            this.qqq = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.qq = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_sex = new System.Windows.Forms.ComboBox();
            this.cb_face = new System.Windows.Forms.ComboBox();
            this.tb_room = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_bir = new System.Windows.Forms.TextBox();
            this.tb_class = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_resume = new System.Windows.Forms.Button();
            this.bt_queren = new System.Windows.Forms.Button();
            this.lb_face = new System.Windows.Forms.Label();
            this.lb_room = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_birthday = new System.Windows.Forms.Label();
            this.lb_class = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pwdd
            // 
            this.pwdd.Location = new System.Drawing.Point(167, 94);
            this.pwdd.Name = "pwdd";
            this.pwdd.ReadOnly = true;
            this.pwdd.Size = new System.Drawing.Size(132, 25);
            this.pwdd.TabIndex = 70;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Location = new System.Drawing.Point(99, 104);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(52, 15);
            this.pwd.TabIndex = 69;
            this.pwd.Text = "密码：";
            // 
            // telp
            // 
            this.telp.Location = new System.Drawing.Point(419, 338);
            this.telp.Name = "telp";
            this.telp.ReadOnly = true;
            this.telp.Size = new System.Drawing.Size(132, 25);
            this.telp.TabIndex = 68;
            // 
            // qqq
            // 
            this.qqq.Location = new System.Drawing.Point(167, 338);
            this.qqq.Name = "qqq";
            this.qqq.ReadOnly = true;
            this.qqq.Size = new System.Drawing.Size(132, 25);
            this.qqq.TabIndex = 67;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(344, 341);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(82, 15);
            this.tel.TabIndex = 66;
            this.tel.Text = "电话号码：";
            // 
            // qq
            // 
            this.qq.AutoSize = true;
            this.qq.Location = new System.Drawing.Point(102, 341);
            this.qq.Name = "qq";
            this.qq.Size = new System.Drawing.Size(68, 15);
            this.qq.TabIndex = 65;
            this.qq.Text = "QQ号码：";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(518, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_sex
            // 
            this.tb_sex.FormattingEnabled = true;
            this.tb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.tb_sex.Location = new System.Drawing.Point(167, 146);
            this.tb_sex.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(132, 23);
            this.tb_sex.TabIndex = 62;
            // 
            // cb_face
            // 
            this.cb_face.FormattingEnabled = true;
            this.cb_face.Items.AddRange(new object[] {
            "党员",
            "团员",
            "群众",
            "其他"});
            this.cb_face.Location = new System.Drawing.Point(419, 294);
            this.cb_face.Margin = new System.Windows.Forms.Padding(4);
            this.cb_face.Name = "cb_face";
            this.cb_face.Size = new System.Drawing.Size(132, 23);
            this.cb_face.TabIndex = 61;
            // 
            // tb_room
            // 
            this.tb_room.Location = new System.Drawing.Point(167, 287);
            this.tb_room.Margin = new System.Windows.Forms.Padding(4);
            this.tb_room.Name = "tb_room";
            this.tb_room.ReadOnly = true;
            this.tb_room.Size = new System.Drawing.Size(132, 25);
            this.tb_room.TabIndex = 60;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(419, 224);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_address.Name = "tb_address";
            this.tb_address.ReadOnly = true;
            this.tb_address.Size = new System.Drawing.Size(132, 25);
            this.tb_address.TabIndex = 59;
            // 
            // tb_bir
            // 
            this.tb_bir.Location = new System.Drawing.Point(167, 217);
            this.tb_bir.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bir.Name = "tb_bir";
            this.tb_bir.ReadOnly = true;
            this.tb_bir.Size = new System.Drawing.Size(132, 25);
            this.tb_bir.TabIndex = 58;
            // 
            // tb_class
            // 
            this.tb_class.Location = new System.Drawing.Point(419, 146);
            this.tb_class.Margin = new System.Windows.Forms.Padding(4);
            this.tb_class.Name = "tb_class";
            this.tb_class.ReadOnly = true;
            this.tb_class.Size = new System.Drawing.Size(132, 25);
            this.tb_class.TabIndex = 57;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(167, 14);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(132, 25);
            this.tb_name.TabIndex = 56;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(167, 54);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(132, 25);
            this.tb_id.TabIndex = 55;
            // 
            // bt_resume
            // 
            this.bt_resume.Location = new System.Drawing.Point(343, 414);
            this.bt_resume.Margin = new System.Windows.Forms.Padding(4);
            this.bt_resume.Name = "bt_resume";
            this.bt_resume.Size = new System.Drawing.Size(100, 29);
            this.bt_resume.TabIndex = 54;
            this.bt_resume.Text = "修改信息";
            this.bt_resume.UseVisualStyleBackColor = true;
            this.bt_resume.Click += new System.EventHandler(this.bt_resume_Click);
            // 
            // bt_queren
            // 
            this.bt_queren.Location = new System.Drawing.Point(102, 414);
            this.bt_queren.Margin = new System.Windows.Forms.Padding(4);
            this.bt_queren.Name = "bt_queren";
            this.bt_queren.Size = new System.Drawing.Size(100, 29);
            this.bt_queren.TabIndex = 53;
            this.bt_queren.Text = "确认";
            this.bt_queren.UseVisualStyleBackColor = true;
            this.bt_queren.Click += new System.EventHandler(this.bt_queren_Click);
            // 
            // lb_face
            // 
            this.lb_face.AutoSize = true;
            this.lb_face.Location = new System.Drawing.Point(341, 298);
            this.lb_face.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_face.Name = "lb_face";
            this.lb_face.Size = new System.Drawing.Size(75, 15);
            this.lb_face.TabIndex = 52;
            this.lb_face.Text = "政治面貌:";
            // 
            // lb_room
            // 
            this.lb_room.AutoSize = true;
            this.lb_room.Location = new System.Drawing.Point(99, 298);
            this.lb_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_room.Name = "lb_room";
            this.lb_room.Size = new System.Drawing.Size(60, 15);
            this.lb_room.TabIndex = 51;
            this.lb_room.Text = "宿舍号:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(341, 228);
            this.lb_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(75, 15);
            this.lb_address.TabIndex = 50;
            this.lb_address.Text = "家庭住址:";
            // 
            // lb_birthday
            // 
            this.lb_birthday.AutoSize = true;
            this.lb_birthday.Location = new System.Drawing.Point(99, 228);
            this.lb_birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(75, 15);
            this.lb_birthday.TabIndex = 49;
            this.lb_birthday.Text = "出生日期:";
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Location = new System.Drawing.Point(341, 150);
            this.lb_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(52, 15);
            this.lb_class.TabIndex = 48;
            this.lb_class.Text = "班级：";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(99, 150);
            this.lb_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(52, 15);
            this.lb_sex.TabIndex = 47;
            this.lb_sex.Text = "性别：";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(99, 14);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(45, 15);
            this.lb_name.TabIndex = 46;
            this.lb_name.Text = "姓名:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(99, 54);
            this.lb_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(45, 15);
            this.lb_id.TabIndex = 45;
            this.lb_id.Text = "学号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(364, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // studentsinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 493);
            this.Controls.Add(this.pwdd);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.telp);
            this.Controls.Add(this.qqq);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.qq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.cb_face);
            this.Controls.Add(this.tb_room);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_bir);
            this.Controls.Add(this.tb_class);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_resume);
            this.Controls.Add(this.bt_queren);
            this.Controls.Add(this.lb_face);
            this.Controls.Add(this.lb_room);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_birthday);
            this.Controls.Add(this.lb_class);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_id);
            this.Name = "studentsinformation";
            this.Text = "studentsinformation";
            this.Load += new System.EventHandler(this.studentsinformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdd;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox telp;
        private System.Windows.Forms.TextBox qqq;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label qq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tb_sex;
        private System.Windows.Forms.ComboBox cb_face;
        private System.Windows.Forms.TextBox tb_room;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_bir;
        private System.Windows.Forms.TextBox tb_class;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_resume;
        private System.Windows.Forms.Button bt_queren;
        private System.Windows.Forms.Label lb_face;
        private System.Windows.Forms.Label lb_room;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_birthday;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
    }
}