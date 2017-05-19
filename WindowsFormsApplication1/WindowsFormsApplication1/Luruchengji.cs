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

            string sqls = string.Format("select Students.ID,Students.Name,Scores.CID,Scores.CName,Scores.Grades  from Scores,Students"
            +"  where Scores.ID=Students.ID and Scores.TeacherName =(select Teacher.Name from Teacher where ID='{0}')", id);
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //sqls = string.Format("select CName from Scores where TeacherName =(select Name from Teacher where ID='{0}')", id);
            //SqlDataAdapter daa = new SqlDataAdapter(sqls, conn);
            //DataSet dss = new DataSet();
            //daa.Fill(dss);
            //DataTable dt = ds.Tables[0];
            //textBox1.Text = dt.Rows[0].ToString();
             string sqlss = string.Format("select * from Scores where TeacherName =(select Name from Teacher where ID='{0}')",id);
             cmd = new SqlCommand(sqlss, conn);
             SqlDataReader reader = cmd.ExecuteReader();
             if (reader.HasRows)
             {
                 while (reader.Read())
                 {
                     textBox1.Text = reader.GetValue(4).ToString();
                 }
             }
             reader.Close();

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
                    scores = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string sqls = string.Format("update Scores set Grades = '{0}' where  ID='{1}' and TeacherName=(select Name from Teacher where ID='{2}')", scores.ToString(), dataGridView1.Rows[i].Cells[0].Value.ToString(),id.ToString());
                    SqlCommand cmdl = new SqlCommand(sqls, conn);
                    cmdl.ExecuteNonQuery();
                }
                MessageBox.Show("学生成绩录入成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            conn.Close();
        }


    }
}
