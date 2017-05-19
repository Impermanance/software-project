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
    public partial class studentsinformation : Form
    {
         private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public string path=@"Resources\dl.jpg";
        public string id;
        public int isok = 0;
        public studentsinformation(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void bt_queren_Click(object sender, EventArgs e)
        {
            if (isok == 1)
            {
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
                        sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
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
                MessageBox.Show("学生信息已确认");
                this.Close();
            }

        }

        private void bt_resume_Click(object sender, EventArgs e)
        {
            isok = 1;
            tb_address.ReadOnly = false;
            tb_bir.ReadOnly = false;
           // tb_class.ReadOnly = false; ;
           // tb_id.ReadOnly = false;
           // tb_name.ReadOnly = false;
           // tb_room.ReadOnly = false;
            pwdd.ReadOnly = false;
            qqq.ReadOnly = false;
            telp.ReadOnly = false;
            button1.Enabled = true;

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
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sql = string.Format("select * from Students where ID = '{0}'", Convert.ToInt32(id));
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
           
            reader.Close();

        }

      
    }
}
