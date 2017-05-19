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
    public partial class stuscore : Form
    {
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public string path = @"Resources\dl.jpg";
        public string id;
        public string sname;
        public string scores;
        public int isok = 0;
        public int flag = 0;
        public stuscore()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            flag = 0;
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            if (comboBox1.Text == "")
                MessageBox.Show("请选择按姓名搜索或者按学号搜索");
            else if (textBox1.Text == "")
                MessageBox.Show("请输入学生姓名或者学号");
            else if (comboBox1.Text == "学号" && textBox1.Text != "")
            {
                id = textBox1.Text.ToString();
                flag = 1;
                string sqlss = string.Format("select * from Students where ID = '{0}'", id);
                cmd = new SqlCommand(sqlss, conn);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    reader.Close();
                    string sqls = string.Format("select CID,CName,Grades,TeacherName from Scores where ID ='{0}'", id);
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    reader.Close();
                    string sqls = string.Format("select CID,CName,Grades,TeacherName from Scores where ID ='{0}'", 0);
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    MessageBox.Show("不存在该学生信息，或者该学生成绩未录入");
                }
                reader.Close();
                conn.Close();
            
            }
            else if (comboBox1.Text == "学生姓名" && textBox1.Text != "")
            {
                sname = textBox1.Text.ToString();
                flag = 2;
                string sqlss = string.Format("select * from Students where ID = '{0}'", id);
                cmd = new SqlCommand(sqlss, conn);
                SqlDataReader reader1 = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader1.HasRows)
                {
                    reader1.Close();
                    string sqls = string.Format("select CID,CName,Grades,TeacherName from Scores where ID =(select ID from Students where Name='{0}')", sname);
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    
                }
                else
                {
                    reader1.Close();
                    string sqls = string.Format("select CID,CName,Grades,TeacherName from Scores where ID =(select ID from Students where Name='{0}')", 0);
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    MessageBox.Show("不存在该学生信息，或者该学生成绩未录入");
                }
                reader1.Close();
                conn.Close();
            }
            conn.Close();
           
        }

        private void queren_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            try
            {
                if (flag == 1)
                {
                    flag = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                        conn = new SqlConnection(sql);
                        conn.Open();
                        scores = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string sqls = string.Format("update Scores set Grades = '{0}' where ID = '{1}' and CID='{2}'", scores.ToString(), id.ToString(), dataGridView1.Rows[i].Cells[0].Value.ToString());
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("学生信息修改成功");
                }
                else if (flag == 2)
                {
                    flag = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
                        conn = new SqlConnection(sql);
                        conn.Open();
                        scores = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string sqls = string.Format("update Scores set Grades = '{0}' where CID='{1}' and ID = (select id from Students where Name = '{2}')", scores.ToString(), dataGridView1.Rows[i].Cells[0].Value.ToString(),sname.ToString());
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("学生信息修改成功");
                }
                else
                    MessageBox.Show("请输入学号或学生姓名");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            conn.Close();
        }

        private void xiugai_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }


    }
}
