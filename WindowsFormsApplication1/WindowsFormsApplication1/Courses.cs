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
    public partial class courses : Form
    {
      //  private SqlCommand cmd = null;
      //  private string sql = null;
        private static string sql = System.Configuration.ConfigurationSettings.AppSettings["connectionstring"];
        private SqlConnection conn = null;
        public string sqls;
        public int iso=0;
        public string id;
        public courses(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serach_Click(object sender, EventArgs e)
        {
          //  sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            if (comboBox1.Text == "课程名")
            {
                sqls = string.Format("select CID,Cname,Time,Didian,Teacher from Course where Cname='{0}'",coursename.Text.ToString());
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
        //    sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sqls = string.Format("select CID,Cname,Time,Didian,Teacher from Course ");
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;
                
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;

            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
        //    sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sqls = string.Format("select CID,Cname,Time,Didian,Teacher from Course where CID not in (select ID from selectcourses "
                +" where SID='{0}')",id);
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == false)
                    iso = 1;
                else
                    iso = 0;
            }
            if (iso == 1)
                MessageBox.Show("未选择任何课程，请重试");

         //   sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            int isok = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    try
                    {
                        string CID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        if (CID != "")
                        {
                            string sqls = "insert into selectcourses values ('" + id.ToString() + "','" + CID.ToString() + "')";
                            SqlCommand cmdl = new SqlCommand(sqls, conn);
                            cmdl.ExecuteNonQuery();
                            isok = 1;
                        }
                        else 
                        {
                            MessageBox.Show("选择了无用行");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }

            }
            if (isok == 1)
                MessageBox.Show("选课成功");
            conn.Close();
        }

  

      
    }
}
