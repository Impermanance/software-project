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
    public partial class Grades : Form
    {

        private string sql = null;
        private SqlConnection conn = null;
        public string id;
        public Grades(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();

            string sqls = string.Format("select CID,CName,Grades,TeacherName from Scores where ID ='{0}'", Convert.ToInt32(id));
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            //conn = new SqlConnection(sql);
            //conn.Open();

            //string sqls = string.Format("select CID as 课程编号,Grades as 课程成绩,TeacherName as 教师姓名 from Scores where ID ='{0}'", Convert.ToInt32(id));
            //SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //DataTable dt = ds.Tables[0];
            //label1.Text = dt.Rows[0]["编号"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 


        
    }
}
