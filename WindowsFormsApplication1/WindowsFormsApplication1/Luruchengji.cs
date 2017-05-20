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
    public partial class Luruchengji : Form
    {
        public string id;
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public string scores;
        public int flag = 0;
        public string cid;
        public string cname;
        public int ist=0;
        public Luruchengji(string ID)
        {
            InitializeComponent();
            id=ID;
        }

        private void Luruchengji_Load(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();

            //string sqls = string.Format("select DISTINCT   from zhijiao,Course,Teacher"
            //+" where  TID='{0}' "
            //+" and zhijiao.CID=Course.CID "
            //+" and zhijiao.TID=Teacher.ID ", id);
            //SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];

            //sqls = string.Format("select CName from Scores where TeacherName =(select Name from Teacher where ID='{0}')", id);
            //SqlDataAdapter daa = new SqlDataAdapter(sqls, conn);
            //DataSet dss = new DataSet();
            //daa.Fill(dss);
            //DataTable dt = ds.Tables[0];
            //textBox1.Text = dt.Rows[0].ToString();
             //string sqlss = string.Format("select * from Course where Teacher =(select Name from Teacher where ID='{0}')",id);
             //cmd = new SqlCommand(sqlss, conn);
             //SqlDataReader reader = cmd.ExecuteReader();
             //if (reader.HasRows)
             //{
             //    while (reader.Read())
             //    {
             //        textBox1.Text = reader.GetValue(1).ToString();
             //    }
             //}
             //reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    sql = string.Format("select * from Scores where ID = '{0}' and CID='{1}'",dataGridView1.Rows[i].Cells[3].Value.ToString(),dataGridView1.Rows[i].Cells[1].Value.ToString() );
                    cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("该同学已添加过成绩");
                    }
                    else
                    {
                        reader.Close();
                        string sqls = string.Format("insert into Scores values('" + dataGridView1.Rows[i].Cells[3].Value.ToString()
                            + "',(select CID from Course where CID='" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'),'" + dataGridView1.Rows[i].Cells[0].Value.ToString()
                            + "',(select Name from Teacher where ID='" + id + "'),'" +
                            dataGridView1.Rows[i].Cells[2].Value.ToString() + "')");
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();
                        ist = 1;
                    }
                }
                if(ist==1)
                MessageBox.Show("学生成绩录入成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            conn.Close();
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
                        string sqls = string.Format("select distinct selectcourses.SID,Students.Name,selectcourses.ID,Course.Cname" +
                            " from selectcourses,Course,Students" +
                            " where selectcourses.SID=Students.ID and selectcourses.ID=(select CID from Course where Cname= '{0}') and "
                            + " Course.CID=(select CID from Course where Cname='{1}')", cname,cname);
                        SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        MessageBox.Show("查找成功");
                    }
                    else
                    {
                        reader.Close();
                        string sqls = string.Format("select distinct selectcourses.ID,Course.Cname,selectcourses.SID,Students.Name" +
                            " from selectcourses,Course,Students" +
                            " where selectcourses.SID=Students.ID and selectcourses.ID=(select CID from Course where Cname= '{0}') and "
                            + " Course.CID=(select CID from Course where Cname='{1}')", cname,cname);
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
                    string sqls = string.Format("select distinct selectcourses.ID,Course.Cname,selectcourses.SID,Students.Name" +
                    " from selectcourses,Course,Students" +
                    " where selectcourses.SID=Students.ID and selectcourses.ID= '{0}' and "
                    + " Course.CID='{1}'", cid, cid);
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    MessageBox.Show("查找成功");
                }
                else
                {
                    reader1.Close();
                    string sqls = string.Format("select distinct selectcourses.ID,Course.Cname,selectcourses.SID,Students.Name" +
                    " from selectcourses,Course,Students" +
                    " where selectcourses.SID=Students.ID and selectcourses.ID= '{0}' and "
                    + " Course.CID='{1}'", cid, cid);
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



    }
}
