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
    public partial class addcourse : Form
    {
        private string sql = null;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public string sqls;
        public addcourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sql = string.Format("select * from Course where CID = '{0}'", textBox1.Text);
            cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
            }
            else
                MessageBox.Show("未存在此课程编号，可添加");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sql = string.Format("select * from Course where CName = '{0}'", textBox2.Text);
            cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
            }
            else
                MessageBox.Show("未存在此课程名，可添加");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sql = string.Format("select * from Teacher where Name = '{0}'", textBox5.Text);
            cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("存在此教师，可添加");
            }
            else
                MessageBox.Show("未存在此教师，不可添加");

        }

        private void queding_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            try
            {
                string sqls = string.Format("insert into Course values('" + textBox1.Text.ToString()
                    + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString()
                    + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')");
                SqlCommand cmdllll = new SqlCommand(sqls, conn);
                cmdllll.ExecuteNonQuery();
                MessageBox.Show("已成功新增课程");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            conn.Close();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = null;

        }

        private void tuichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
