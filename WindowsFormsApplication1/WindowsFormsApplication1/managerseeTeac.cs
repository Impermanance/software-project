using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class managerseeTeac : Form
    {
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public string path = @"Resources\dl.jpg";
        public string id;
        public string sname;
        public int isok = 0;
        public int flag = 0;
        public managerseeTeac()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("请选择按教师姓名搜索或者按教师编号搜索");
            else if (textBox1.Text == "")
                MessageBox.Show("请输入教师姓名或者教师编号");
            else if (comboBox1.Text == "教师编号" && textBox1.Text != "")
            {
                id = textBox1.Text.ToString();
                flag = 1;
                sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                conn = new SqlConnection(sql);
                conn.Open();
                sql = string.Format("select * from Teacher where ID = '{0}'", id);
                cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tb_id.Text = reader.GetValue(0).ToString();
                        tb_name.Text = reader.GetValue(1).ToString();
                        tb_sex.Text = reader.GetValue(2).ToString();
                        tb_bir.Text = reader.GetValue(3).ToString();
                        tb_xueli.Text = reader.GetValue(4).ToString();
                        tb_zhicheng.Text = reader.GetValue(5).ToString();
                        depart.Text = reader.GetValue(6).ToString();
                        cb_face.Text = reader.GetValue(7).ToString();
                        telp.Text = reader.GetValue(8).ToString();
                        tb_address.Text = reader.GetValue(9).ToString();
                        pictureBox1.ImageLocation = reader.GetValue(10).ToString();
                        pwdd.Text = reader.GetValue(11).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("不存在该教师");
                    textBox1.Text = "";
                    textBox1.Focus();
                }

                reader.Close();
            }
            else if (comboBox1.Text == "教师姓名" && textBox1.Text != "")
            {
                sname = textBox1.Text.ToString().Trim();
                flag = 2;
                sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                conn = new SqlConnection(sql);
                conn.Open();
                sql = string.Format("select * from Teacher where Name = '" + sname.ToString() + "'");
                cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tb_id.Text = reader.GetValue(0).ToString();
                        tb_name.Text = reader.GetValue(1).ToString();
                        tb_sex.Text = reader.GetValue(2).ToString();
                        tb_bir.Text = reader.GetValue(3).ToString();
                        tb_xueli.Text = reader.GetValue(4).ToString();
                        tb_zhicheng.Text = reader.GetValue(5).ToString();
                        depart.Text = reader.GetValue(6).ToString();
                        cb_face.Text = reader.GetValue(7).ToString();
                        telp.Text = reader.GetValue(8).ToString();
                        tb_address.Text = reader.GetValue(9).ToString();
                        pictureBox1.ImageLocation = reader.GetValue(10).ToString();
                        pwdd.Text = reader.GetValue(11).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("不存在该教师");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            pictureBox1.ImageLocation = path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_resume_Click(object sender, EventArgs e)
        {
            isok = 1;
            tb_address.ReadOnly = false;
            tb_bir.ReadOnly = false;
            tb_xueli.ReadOnly = false; ;
            tb_id.ReadOnly = false;
            tb_name.ReadOnly = false;
            tb_zhicheng.ReadOnly = false;
            pwdd.ReadOnly = false;
            depart.ReadOnly = false;
            telp.ReadOnly = false;
            button1.Enabled = true;
        }

        private void bt_queren_Click(object sender, EventArgs e)
        {
            if (isok == 1)
            {
                if ("".Equals(tb_id.Text.ToString()) ||
                    "".Equals(tb_name.Text.ToString()) ||
                    "".Equals(tb_sex.Text.ToString()) ||
                    "".Equals(tb_bir.Text.ToString()) ||
                    "".Equals(tb_xueli.Text.ToString()) ||
                    "".Equals(tb_address.Text.ToString()) ||
                    "".Equals(tb_zhicheng.Text.ToString()) ||
                    "".Equals(cb_face.Text.ToString()) ||
                    "".Equals(depart.Text.ToString()) ||
                    "".Equals(telp.Text.ToString()) ||
                    "".Equals(path) ||
                    "".Equals(pwdd.Text.ToString()))
                {
                    MessageBox.Show("请输入完整");
                }

                else
                {
                    try
                    {
                        sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                        conn = new SqlConnection(sql);
                        conn.Open();
                        string sqls = "update Teacher set Name='" + tb_name.Text.ToString() + "',Sex='" + tb_sex.Text.ToString()
                            + "',Birthday='" + tb_bir.Text.ToString() + "',Grade='" + tb_xueli.Text.ToString()
                            + "',Zhicheng='" + tb_zhicheng.Text.ToString() + "',Xueyuan='" + depart.Text.ToString()
                            + "',Face='" + cb_face.Text.ToString() + "',Tel='" + telp.Text.ToString()
                            + "',Address='" + tb_address.Text.ToString() + "',Pic='" + path.ToString()
                            + "',pwd='" + pwdd.Text.ToString() + "' where ID='" + id.ToString() + "';";
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();
                        MessageBox.Show("教师信息录入成功");
                        conn.Close();
                        this.Close();
                        //Form1 fm1 = new Form1();
                        //fm1.Show();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("教师信息已确认");
                this.Close();
            }
        }
    }
}
