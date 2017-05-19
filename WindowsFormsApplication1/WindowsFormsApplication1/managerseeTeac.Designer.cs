namespace WindowsFormsApplication1
{
    partial class managerseeTeac
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
            this.depart = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.qq = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_sex = new System.Windows.Forms.ComboBox();
            this.cb_face = new System.Windows.Forms.ComboBox();
            this.tb_zhicheng = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_bir = new System.Windows.Forms.TextBox();
            this.tb_xueli = new System.Windows.Forms.TextBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pwdd
            // 
            this.pwdd.Location = new System.Drawing.Point(312, 106);
            this.pwdd.Name = "pwdd";
            this.pwdd.ReadOnly = true;
            this.pwdd.Size = new System.Drawing.Size(132, 25);
            this.pwdd.TabIndex = 122;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Location = new System.Drawing.Point(244, 116);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(52, 15);
            this.pwd.TabIndex = 121;
            this.pwd.Text = "密码：";
            // 
            // telp
            // 
            this.telp.Location = new System.Drawing.Point(564, 350);
            this.telp.Name = "telp";
            this.telp.ReadOnly = true;
            this.telp.Size = new System.Drawing.Size(132, 25);
            this.telp.TabIndex = 120;
            // 
            // depart
            // 
            this.depart.Location = new System.Drawing.Point(312, 350);
            this.depart.Name = "depart";
            this.depart.ReadOnly = true;
            this.depart.Size = new System.Drawing.Size(132, 25);
            this.depart.TabIndex = 119;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(489, 353);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(82, 15);
            this.tel.TabIndex = 118;
            this.tel.Text = "电话号码：";
            // 
            // qq
            // 
            this.qq.AutoSize = true;
            this.qq.Location = new System.Drawing.Point(247, 353);
            this.qq.Name = "qq";
            this.qq.Size = new System.Drawing.Size(82, 15);
            this.qq.TabIndex = 117;
            this.qq.Text = "所在学院：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(509, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // tb_sex
            // 
            this.tb_sex.FormattingEnabled = true;
            this.tb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.tb_sex.Location = new System.Drawing.Point(312, 158);
            this.tb_sex.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(132, 23);
            this.tb_sex.TabIndex = 114;
            // 
            // cb_face
            // 
            this.cb_face.FormattingEnabled = true;
            this.cb_face.Items.AddRange(new object[] {
            "党员",
            "团员",
            "群众",
            "其他"});
            this.cb_face.Location = new System.Drawing.Point(564, 306);
            this.cb_face.Margin = new System.Windows.Forms.Padding(4);
            this.cb_face.Name = "cb_face";
            this.cb_face.Size = new System.Drawing.Size(132, 23);
            this.cb_face.TabIndex = 113;
            // 
            // tb_zhicheng
            // 
            this.tb_zhicheng.Location = new System.Drawing.Point(312, 299);
            this.tb_zhicheng.Margin = new System.Windows.Forms.Padding(4);
            this.tb_zhicheng.Name = "tb_zhicheng";
            this.tb_zhicheng.ReadOnly = true;
            this.tb_zhicheng.Size = new System.Drawing.Size(132, 25);
            this.tb_zhicheng.TabIndex = 112;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(564, 236);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_address.Name = "tb_address";
            this.tb_address.ReadOnly = true;
            this.tb_address.Size = new System.Drawing.Size(132, 25);
            this.tb_address.TabIndex = 111;
            // 
            // tb_bir
            // 
            this.tb_bir.Location = new System.Drawing.Point(312, 229);
            this.tb_bir.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bir.Name = "tb_bir";
            this.tb_bir.ReadOnly = true;
            this.tb_bir.Size = new System.Drawing.Size(132, 25);
            this.tb_bir.TabIndex = 110;
            // 
            // tb_xueli
            // 
            this.tb_xueli.Location = new System.Drawing.Point(564, 158);
            this.tb_xueli.Margin = new System.Windows.Forms.Padding(4);
            this.tb_xueli.Name = "tb_xueli";
            this.tb_xueli.ReadOnly = true;
            this.tb_xueli.Size = new System.Drawing.Size(132, 25);
            this.tb_xueli.TabIndex = 109;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(312, 26);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(132, 25);
            this.tb_name.TabIndex = 108;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(312, 66);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(132, 25);
            this.tb_id.TabIndex = 107;
            // 
            // bt_resume
            // 
            this.bt_resume.Location = new System.Drawing.Point(423, 426);
            this.bt_resume.Margin = new System.Windows.Forms.Padding(4);
            this.bt_resume.Name = "bt_resume";
            this.bt_resume.Size = new System.Drawing.Size(100, 29);
            this.bt_resume.TabIndex = 106;
            this.bt_resume.Text = "修改信息";
            this.bt_resume.UseVisualStyleBackColor = true;
            this.bt_resume.Click += new System.EventHandler(this.bt_resume_Click);
            // 
            // bt_queren
            // 
            this.bt_queren.Location = new System.Drawing.Point(247, 426);
            this.bt_queren.Margin = new System.Windows.Forms.Padding(4);
            this.bt_queren.Name = "bt_queren";
            this.bt_queren.Size = new System.Drawing.Size(100, 29);
            this.bt_queren.TabIndex = 105;
            this.bt_queren.Text = "确认";
            this.bt_queren.UseVisualStyleBackColor = true;
            this.bt_queren.Click += new System.EventHandler(this.bt_queren_Click);
            // 
            // lb_face
            // 
            this.lb_face.AutoSize = true;
            this.lb_face.Location = new System.Drawing.Point(486, 310);
            this.lb_face.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_face.Name = "lb_face";
            this.lb_face.Size = new System.Drawing.Size(75, 15);
            this.lb_face.TabIndex = 104;
            this.lb_face.Text = "政治面貌:";
            // 
            // lb_room
            // 
            this.lb_room.AutoSize = true;
            this.lb_room.Location = new System.Drawing.Point(244, 310);
            this.lb_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_room.Name = "lb_room";
            this.lb_room.Size = new System.Drawing.Size(45, 15);
            this.lb_room.TabIndex = 103;
            this.lb_room.Text = "职称:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(486, 240);
            this.lb_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(75, 15);
            this.lb_address.TabIndex = 102;
            this.lb_address.Text = "家庭住址:";
            // 
            // lb_birthday
            // 
            this.lb_birthday.AutoSize = true;
            this.lb_birthday.Location = new System.Drawing.Point(244, 240);
            this.lb_birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(75, 15);
            this.lb_birthday.TabIndex = 101;
            this.lb_birthday.Text = "出生日期:";
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Location = new System.Drawing.Point(486, 162);
            this.lb_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(52, 15);
            this.lb_class.TabIndex = 100;
            this.lb_class.Text = "学历：";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(244, 162);
            this.lb_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(52, 15);
            this.lb_sex.TabIndex = 99;
            this.lb_sex.Text = "性别：";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(244, 26);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(45, 15);
            this.lb_name.TabIndex = 98;
            this.lb_name.Text = "姓名:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(244, 66);
            this.lb_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(45, 15);
            this.lb_id.TabIndex = 97;
            this.lb_id.Text = "编号:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 123;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 25);
            this.textBox1.TabIndex = 132;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 131;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "教师姓名",
            "教师编号"});
            this.comboBox1.Location = new System.Drawing.Point(44, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 130;
            // 
            // managerseeTeac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 505);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pwdd);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.telp);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.qq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.cb_face);
            this.Controls.Add(this.tb_zhicheng);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_bir);
            this.Controls.Add(this.tb_xueli);
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
            this.Name = "managerseeTeac";
            this.Text = "教师信息";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdd;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox telp;
        private System.Windows.Forms.TextBox depart;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label qq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tb_sex;
        private System.Windows.Forms.ComboBox cb_face;
        private System.Windows.Forms.TextBox tb_zhicheng;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_bir;
        private System.Windows.Forms.TextBox tb_xueli;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}