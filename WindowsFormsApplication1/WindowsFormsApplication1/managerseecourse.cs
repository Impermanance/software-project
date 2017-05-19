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
    public partial class managerseecourse : Form
    {
        private string sql = null;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public string sqls;
        public string CID;
        public int iso = 0;
        public managerseecourse()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                    {
                        CID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string sqls = string.Format("delete from Scores where CName=(select Cname from CName where ID='{0}')", CID);
                        SqlCommand cmdllll = new SqlCommand(sqls, conn);
                        cmdllll.ExecuteNonQuery();
                        sqls = string.Format("delete from Course where CID='{0}'", CID);
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();
                        sqls = string.Format("delete from zhijiao where CID='{0}'", CID);
                        SqlCommand cmdll = new SqlCommand(sqls, conn);
                        cmdll.ExecuteNonQuery();
                        sqls = string.Format("delete from selectcourses where ID='{0}'", CID);
                        SqlCommand cmdlll = new SqlCommand(sqls, conn);
                        cmdlll.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("课程信息删除成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {            
                        CID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string sqls = string.Format("update Course set CID= '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "',CName='" + dataGridView1.Rows[i].Cells[2].Value.ToString()
                            + "',Time='" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "',Didian='" + dataGridView1.Rows[i].Cells[4].Value.ToString()
                            + "',Teacher='" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "' where CID='{0}'", CID);
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();

                }
                MessageBox.Show("课程信息修改成功！");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serach_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            if (comboBox1.Text == "课程名")
            {
                sqls = string.Format("select CID,Cname,Time,Didian,Teacher from Course where Cname='{0}'", coursename.Text.ToString());
                SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.Text == "课程ID")
            {
                sqls = string.Format("select CID,Cname,Time,Didian,Teacher from Course where CID='{0}'", coursename.Text.ToString());
                SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("请选择按课程名搜索或课程ID搜索");
                comboBox1.Focus();
            }
            if (coursename.Text == "")
                MessageBox.Show("请输入课程名或者课程编号");
        }

        private void display_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sqls = string.Format("select CID,Cname,Time,Didian,Teacher from Course ");
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
