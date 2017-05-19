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
  
    public partial class studentzhuce : Form
    {
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public string path;
        public studentzhuce()
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

        private void bt_resume_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_sex.Text = "";
            tb_bir.Text = "";
            tb_class.Text = "";
            tb_address.Text = "";
            tb_room.Text = "";
            cb_face.Text = "";
            qqq.Text = "";
            telp.Text = "";
            pwdd.Text = "";
            pictureBox1.ImageLocation = "";

        }

        private void bt_queren_Click(object sender, EventArgs e)
        {
            if ("".Equals(tb_id.Text.ToString()) ||
                "".Equals(tb_name.Text.ToString()) || 
                "".Equals(tb_sex.Text.ToString()) || 
                "".Equals(tb_bir.Text.ToString())|| 
                "".Equals(tb_class.Text.ToString()) || 
                "".Equals(tb_address.Text.ToString()) || 
                "".Equals(tb_room.Text.ToString()) || 
                "".Equals(cb_face.Text.ToString())|| 
                "".Equals(qqq.Text.ToString())|| 
                "".Equals(telp.Text.ToString())||
                "".Equals(path)||
                "".Equals(pwdd.Text.ToString())  )
            {
                MessageBox.Show("请输入完整");
            }

            else
            {

                int t = 0;
                sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                conn = new SqlConnection(sql);
                conn.Open();
                string sql_id = "select ID from Students ";
                cmd = new SqlCommand(sql_id, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = (string)reader.GetValue(0);
                        if (id.Equals(tb_id.Text.ToString()))
                        {
                            t = 1;
                            break;
                        }
                    }
                }
                reader.Close();

                if (t == 1)
                {
                    MessageBox.Show("存在该学号的学生，录入失败!");
                }
                else
                {
                   
                    string sqls = "insert into Students values ('" + tb_id.Text.ToString() + "','" 
                  + tb_name.Text.ToString() + "','" + tb_sex.Text.ToString()
                  + "','" + tb_class.Text.ToString() + "','" + tb_bir.Text.ToString() 
                  + "','" + tb_address.Text.ToString() + "','"
                  + tb_room.Text.ToString() + "','" + cb_face.Text.ToString() + "','" 
                  + qqq.Text.ToString() + "','" + telp.Text.ToString() + "','" 
                  + path + "','" +pwdd.Text.ToString()+ "')";
                    SqlCommand cmdl = new SqlCommand(sqls, conn);
                    cmdl.ExecuteNonQuery();
                    MessageBox.Show("学生信息录入成功");
                    conn.Close();
                    this.Close();
                    shouye fm1 = new shouye();
                    fm1.Show();

                }

            }

        }

      
    }
}
