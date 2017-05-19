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
    public partial class teacherseestu : Form
    {
        private SqlCommand cmd = null;
        //private string sql = null;
        private static string sql = System.Configuration.ConfigurationSettings.AppSettings["connectionstring"];
        private SqlConnection conn = null;
        public string path = @"Resources\dl.jpg";
        public string id;
        public string sname;
        public int isok = 0;
        public int flag=0;
        public teacherseestu()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            pictureBox1.ImageLocation = path;
        }

        private void studentsinformation_Load(object sender, EventArgs e)
        {
            //sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            //conn = new SqlConnection(sql);
            //conn.Open();
            //sql = string.Format("select * from Students where ID = '{0}'", Convert.ToInt32(id));
            //cmd = new SqlCommand(sql, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        tb_id.Text = reader.GetValue(0).ToString();
            //        tb_name.Text = reader.GetValue(1).ToString();
            //        tb_sex.Text = reader.GetValue(2).ToString();
            //        tb_class.Text = reader.GetValue(3).ToString();
            //        tb_bir.Text = reader.GetValue(4).ToString();
            //        tb_address.Text = reader.GetValue(5).ToString();
            //        tb_room.Text = reader.GetValue(6).ToString();
            //        cb_face.Text = reader.GetValue(7).ToString();
            //        qqq.Text = reader.GetValue(8).ToString();
            //        telp.Text = reader.GetValue(9).ToString();
            //        pictureBox1.ImageLocation = reader.GetValue(10).ToString();
            //        pwdd.Text = reader.GetValue(11).ToString();
            //    }
            //}
          
            //reader.Close();

        }

        private void bt_queren_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bt_resume_Click_1(object sender, EventArgs e)
        {
            isok = 1;
            tb_address.ReadOnly = false;
            tb_bir.ReadOnly = false;
            tb_class.ReadOnly = false; ;
            tb_id.ReadOnly = false;
            tb_name.ReadOnly = false;
            tb_room.ReadOnly = false;
            pwdd.ReadOnly = false;
            qqq.ReadOnly = false;
            telp.ReadOnly = false;
            button1.Enabled = true;
        }

        private void bt_queren_Click(object sender, EventArgs e)
        {
            if (isok == 1)
            {
                isok = 0;
                tb_address.ReadOnly = true;
                tb_bir.ReadOnly = true;
                tb_class.ReadOnly = true; ;
                tb_id.ReadOnly = true;
                tb_name.ReadOnly = true;
                tb_room.ReadOnly = true;
                pwdd.ReadOnly = true;
                qqq.ReadOnly = true;
                telp.ReadOnly = true;
                button1.Enabled = true;
                if ("".Equals(tb_id.Text.ToString()) ||
                    "".Equals(tb_name.Text.ToString()) ||
                    "".Equals(tb_sex.Text.ToString()) ||
                    "".Equals(tb_bir.Text.ToString()) ||
                    "".Equals(tb_class.Text.ToString()) ||
                    "".Equals(tb_address.Text.ToString()) ||
                    "".Equals(tb_room.Text.ToString()) ||
                    "".Equals(cb_face.Text.ToString()) ||
                    "".Equals(qqq.Text.ToString()) ||
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
                        if (flag == 1)
                        {
                            //sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                            conn = new SqlConnection(sql);
                            conn.Open();
                            string sqls = "update Students set Name='" + tb_name.Text.ToString() + "',Sex='" + tb_sex.Text.ToString()
                                + "',Class='" + tb_class.Text.ToString() + "',Birthday='" + tb_bir.Text.ToString()
                                + "',Address='" + tb_address.Text.ToString() + "',Room='" + tb_room.Text.ToString()
                                + "',Face='" + cb_face.Text.ToString() + "',QQ='" + qqq.Text.ToString()
                                + "',Tel='" + telp.Text.ToString() + "',Pic='" + path.ToString()
                                + "',pwd='" + pwdd.Text.ToString() + "' where ID=" + Convert.ToInt32(id) + ";";
                            SqlCommand cmdl = new SqlCommand(sqls, conn);
                            cmdl.ExecuteNonQuery();
                            MessageBox.Show("学生信息修改成功");
                            conn.Close();
                       //     this.Close();
                        }
                        else if (flag == 2)
                        {
                            //sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                            conn = new SqlConnection(sql);
                            conn.Open();
                            string sqls = "update Students set Name='" + tb_name.Text.ToString() + "',Sex='" + tb_sex.Text.ToString()
                                + "',Class='" + tb_class.Text.ToString() + "',Birthday='" + tb_bir.Text.ToString()
                                + "',Address='" + tb_address.Text.ToString() + "',Room='" + tb_room.Text.ToString()
                                + "',Face='" + cb_face.Text.ToString() + "',QQ='" + qqq.Text.ToString()
                                + "',Tel='" + telp.Text.ToString() + "',Pic='" + path.ToString()
                                + "',pwd='" + pwdd.Text.ToString() + "' where Name='" + sname.ToString() + "';";
                            SqlCommand cmdl = new SqlCommand(sqls, conn);
                            cmdl.ExecuteNonQuery();
                            MessageBox.Show("学生信息修改成功");
                            conn.Close();
                          //  this.Close();
                        }
                        else
                        {
                            MessageBox.Show("请输入学号或学生姓名");
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("学生信息已确认");
              //  this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("请选择按姓名搜索或者按学号搜索");
            else if (textBox1.Text == "")
                MessageBox.Show("请输入学生姓名或者学号");
            else if (comboBox1.Text == "学号" && textBox1.Text != "")
            {
                id = textBox1.Text.ToString();
                flag = 1;
                //sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                conn = new SqlConnection(sql);
                conn.Open();
                sql = string.Format("select * from Students where ID = '{0}'", id);
                cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tb_id.Text = reader.GetValue(0).ToString();
                        tb_name.Text = reader.GetValue(1).ToString();
                        tb_sex.Text = reader.GetValue(2).ToString();
                        tb_class.Text = reader.GetValue(3).ToString();
                        tb_bir.Text = reader.GetValue(4).ToString();
                        tb_address.Text = reader.GetValue(5).ToString();
                        tb_room.Text = reader.GetValue(6).ToString();
                        cb_face.Text = reader.GetValue(7).ToString();
                        qqq.Text = reader.GetValue(8).ToString();
                        telp.Text = reader.GetValue(9).ToString();
                        pictureBox1.ImageLocation = reader.GetValue(10).ToString();
                        pwdd.Text = reader.GetValue(11).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("不存在该学生");
                    textBox1.Text = "";
                    textBox1.Focus();
                }

                reader.Close();
            }
            else if (comboBox1.Text == "学生姓名" && textBox1.Text != "")
            {
                sname = textBox1.Text.ToString().Trim();
                flag = 2;
                //sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                conn = new SqlConnection(sql);
                conn.Open();
                sql = string.Format("select * from Students where Name = '"+sname.ToString()+"'");
                cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tb_id.Text = reader.GetValue(0).ToString();
                        tb_name.Text = reader.GetValue(1).ToString();
                        tb_sex.Text = reader.GetValue(2).ToString();
                        tb_class.Text = reader.GetValue(3).ToString();
                        tb_bir.Text = reader.GetValue(4).ToString();
                        tb_address.Text = reader.GetValue(5).ToString();
                        tb_room.Text = reader.GetValue(6).ToString();
                        cb_face.Text = reader.GetValue(7).ToString();
                        qqq.Text = reader.GetValue(8).ToString();
                        telp.Text = reader.GetValue(9).ToString();
                        pictureBox1.ImageLocation = reader.GetValue(10).ToString();
                        pwdd.Text = reader.GetValue(11).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("不存在该学生");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                reader.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            pictureBox1.ImageLocation = path;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



      
    }
    
}
