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
    public partial class deletescore : Form
    {
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public string scores;
        public int flag = 0;
        public string cid;
        public string cname;
        public int ist = 0;
        public string id;
        public deletescore(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 0;
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            if (comboBox1.Text == "")
                MessageBox.Show("请选择按课程名搜索或者按课程编号搜索");
            else if (textBox1.Text == "")
                MessageBox.Show("请输入课程名或者课程编号");
            else if (comboBox1.Text == "课程名" && textBox1.Text != "")
            {
                cname = textBox1.Text.ToString();
                flag = 1;
                string sqlss = string.Format("select * from zhijiao where CID =(select  CID  from course where cname='{0}')", cname);
                cmd = new SqlCommand(sqlss, conn);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                try
                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        string sqls = string.Format("select distinct selectcourses.SID,Students.Name,selectcourses.ID,Course.Cname,scores.grades" +
                            " from selectcourses,Course,Students,Scores" +
                            " where selectcourses.SID=Students.ID and selectcourses.ID=(select CID from Course where Cname= '{0}') and "
                            + " Course.CID=(select CID from Course where Cname='{1}' "
                            + "  and Scores.CID=(select CID from Course where Cname='{1}'))", cname, cname, cname);
                        SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        MessageBox.Show("查找成功");
                    }
                    else
                    {
                        reader.Close();
                        string sqls = string.Format("select distinct selectcourses.SID,Students.Name,selectcourses.ID,Course.Cname,scores.grades" +
                            " from selectcourses,Course,Students,scores" +
                            " where selectcourses.SID=Students.ID and selectcourses.ID=(select CID from Course where Cname= '{0}') and "
                            + " Course.CID=(select CID from Course where Cname='{1}' "
                            + "  and Scores.CID=(select CID from Course where Cname='{1}'))", cname, cname, cname);
                        SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        MessageBox.Show("不存在此课程，或您没有执教该课程");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                reader.Close();
                conn.Close();

            }
            else if (comboBox1.Text == "课程编号" && textBox1.Text != "")
            {
                cid = textBox1.Text.ToString();
                flag = 2;
                string sqlss = string.Format("select * from zhijiao where CID ='{0}'", cid);
                cmd = new SqlCommand(sqlss, conn);
                SqlDataReader reader1 = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader1.HasRows)
                {
                    reader1.Close();
                    string sqls = string.Format("select distinct selectcourses.ID,Course.Cname,selectcourses.SID,Students.Name,Scores.Grades" +
                    " from selectcourses,Course,Students,scores" +
                    " where selectcourses.SID=Students.ID and selectcourses.ID= '{0}' and "
                    + " Course.CID='{1}' and scores.CID='{2}'", cid, cid,cid);
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    MessageBox.Show("查找成功");
                }
                else
                {
                    reader1.Close();
                    string sqls = string.Format("select distinct selectcourses.ID,Course.Cname,selectcourses.SID,Students.Name,scores.grades" +
                   " from selectcourses,Course,Students,scores" +
                   " where selectcourses.SID=Students.ID and selectcourses.ID= '{0}' and "
                   + " Course.CID='{1}' and scores.CID='{2}'", cid, cid, cid);
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    MessageBox.Show("不存在此课程，或您没有执教该课程");
                }
                reader1.Close();
                conn.Close();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                        string sqls = string.Format("delete from scores where ID='{0}' and CID = '{1}'",dataGridView1.Rows[i].Cells[3].Value.ToString()
                            ,dataGridView1.Rows[i].Cells[1].Value.ToString());
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();
                        ist = 1;
                        //MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        //MessageBox.Show(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }
                }
                if(ist==1)
                MessageBox.Show("学生成绩删除成功");
                string sqlss = string.Format("select distinct selectcourses.ID,Course.Cname,selectcourses.SID,Students.Name,Scores.Grades" +
                   " from selectcourses,Course,Students,scores" +
                   " where selectcourses.SID=Students.ID and selectcourses.ID= '{0}' and "
                   + " Course.CID='{1}' and scores.CID='{2}'", cid, cid, cid);
                SqlDataAdapter da = new SqlDataAdapter(sqlss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}