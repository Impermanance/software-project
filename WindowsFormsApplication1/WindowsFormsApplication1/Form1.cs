using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd = null;
      //  private string sql = null;
        private SqlConnection conn = null;
        public static String id;
        public static String password;
        public int isok=0;
        private static string sql = System.Configuration.ConfigurationSettings.AppSettings["connectionstring"];
        public Form1()
        {
            InitializeComponent();
           // this.BackgroundImage = Image.FromFile("Resources\dl.jpg");
           // this.BackgroundImage = Image.FromFile(@"Resources\dl.jpg");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                
                MessageBox.Show("用户名不能为空，请重试");
                isok = 1;
                textBox1.Focus();
                
            }
            else if (textBox2.Text == "")
            {
            
                MessageBox.Show("密码不能为空，请重试");
                isok = 1;
                textBox2.Focus();
            } 
            else if(radioButton1.Checked!=true&&radioButton2.Checked!=true&&radioButton3.Checked!=true)
            {
          
                MessageBox.Show("身份类型不能为空，请重试");
                isok = 1;
                
            }


                try
                {
                   
                    conn = new SqlConnection(sql);
                    conn.Open();
                    //SqlDataAdapter da = new SqlDataAdapter(sql,conn);
                    //DataSet ds = new DataSet();
                    //da.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    if(radioButton1.Checked)
                    {
                    sql = string.Format("select * from Students where ID = '{0}'", textBox1.Text);
                    cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string isPassword = (string)reader.GetValue(11);
                            if (textBox2.Text.Equals(isPassword))
                            {
                               
                                    id = (string)reader.GetValue(0);
                                    password = (string)reader.GetValue(11);
                                    Students frmstudent = new Students(id,password);
                                    frmstudent.Show();
                                    this.Hide();                                

                            }
                            else
                            {
                                MessageBox.Show("学生密码输入错误，请重试");
                                textBox2.Focus();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在该学生账号");
                    }
                    reader.Close();
                    }

                    if(radioButton2.Checked)
                    {
                    sql = string.Format("select * from Teacher where ID = '{0}'", textBox1.Text);
                    cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader1 = cmd.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            string isPassword = (string)reader1.GetValue(11);
                            if (textBox2.Text.Equals(isPassword))
                            {
                               
                                    id = (string)reader1.GetValue(0);
                                    password = (string)reader1.GetValue(11);
                                    Teachers frmteacher = new Teachers(id);
                                    frmteacher.Show();
                                    this.Hide();
                            }
                                else
                                {
                                    MessageBox.Show("教师密码输入错误，请重试");
                                }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在该教师账号");
                    }
                    reader1.Close();
                    }

                    if (radioButton3.Checked)
                    {
                        if (textBox1.Text == "admin" && textBox2.Text == "123456")
                        {
                            guanliyuan from2 = new guanliyuan();
                            from2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码输入错误，请重试");
                        }
                    }
                    
              
                }
             
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //    studentzhuce zhuce1 = new studentzhuce();
            //    zhuce1.Show();
            //    this.Hide();
            //}
            //else if (radioButton2.Checked)
            //{
            //    teacherzhuce tz = new teacherzhuce();
            //    tz.Show();
            //    this.Hide();
            //}
            //else
            //    MessageBox.Show("请选择注册类型！");
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
            //teacherzhuce tz = new teacherzhuce();
            //tz.Show();
            //this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked=false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }



       

       
    }
}
