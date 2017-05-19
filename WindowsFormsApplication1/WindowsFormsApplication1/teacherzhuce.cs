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
    public partial class teacherzhuce : Form
    {
        public string path;
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;

        public teacherzhuce()
        {
            InitializeComponent();
        }

        private void bt_queren_Click(object sender, EventArgs e)
        {
            if ("".Equals(tb_id.Text.ToString())
                || "".Equals(tb_name.Text.ToString()) 
                ||"".Equals(pwd.Text.ToString())
                || "".Equals(tb_sex.Text.ToString()) 
                || "".Equals(tb_bir.Text.ToString())
                || "".Equals(tb_tel.Text.ToString()) 
                || "".Equals(tb_address.Text.ToString()) 
                || "".Equals(tb_xueli.Text.ToString()) 
                || "".Equals(tb_zhicheng.Text.ToString())
                || "".Equals(tb_dep.Text.ToString())
                || "".Equals(cb_face.Text.ToString())
                ||"".Equals(path)
               )
            {
                MessageBox.Show("请输入完整");
            }



            else
            {

                int t=0;
                 sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                conn = new SqlConnection(sql);
                conn.Open();
                string sql_id = "select ID from Teacher ";
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
                    MessageBox.Show("存在该学号的教师，录入失败!");
                }
                else 
                {
                    string sqls = "insert into Teacher values ('" + tb_id.Text.ToString() + "','"
                        + tb_name.Text.ToString() + "','" + tb_sex.Text.ToString()+ "','" 
                        + tb_bir.Text.ToString() + "','" +tb_xueli.Text.ToString()+"','" 
                        +tb_zhicheng.Text.ToString()+"','"+tb_dep.Text.ToString()+"','" 
                        + cb_face.Text.ToString() + "','"+ tb_tel.Text.ToString()+"','" 
                        +tb_address.Text.ToString() + "','"+path.ToString()+"','" 
                        + pwd.Text.ToString() +  
                         "')";
                    SqlCommand cmdl = new SqlCommand(sqls, conn);
                    cmdl.ExecuteNonQuery();
                    MessageBox.Show("教师信息录入成功");
                    conn.Close();
                    this.Close();
                    shouye fm1 = new shouye();
                    fm1.Show();
                }
        }
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
            pwd.Text = "";
            tb_sex.Text = "";
            tb_bir.Text = "";
            tb_xueli.Text = "";
            tb_zhicheng.Text = "";
            tb_dep.Text = "";
            cb_face.Text = "";
            tb_tel.Text = "";
            tb_address.Text = "";
            pictureBox1.ImageLocation = "";
            
        }
    }
}
