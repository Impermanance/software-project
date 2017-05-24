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
    public partial class Students : Form
    {
        public string id;
        public string password;
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public Students(string ID,string Password)
        {
            InitializeComponent();
            id = ID;
            password = Password;

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shouye fm1 = new shouye();
            fm1.Show();
            this.Close();
        }

        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsinformation sti = new studentsinformation(id);
            sti.Show();
        }

        private void 个人成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grades g = new Grades(id);
            g.Show();
        }

        private void 查看课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            courses cs = new courses(id);
            cs.Show();
        }

        private void 已选课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcourse sc = new showcourse(id);
            sc.Show();
        }

        private void Students_Load(object sender, EventArgs e)
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
                   textBox1.Text=reader.GetValue(1).ToString();
                }
            }          
            reader.Close();
            label4.Text=DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss");  
        }
       
    }
}
