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
    public partial class Teachers : Form
    {
        public string path;
        public string id;
        private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public Teachers(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            shouye fm1 = new shouye();
            fm1.Show();
        }

        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachersinformation tif = new Teachersinformation(id);
            tif.Show();
        }

        private void 学生基本信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacherseestu ts = new teacherseestu();
            ts.Show();
        }

        private void 学生成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuscore sc = new stuscore();
            sc.Show();
        }

        private void 录入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luruchengji lj = new Luruchengji(id);
            lj.Show();
        }

        private void 任课信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renke r = new renke(id);
            r.Show();
        }

        private void 执教班级查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhijiaobanji zb = new zhijiaobanji(id);
            zb.Show();
        }

        private void 删除成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletescore ds = new deletescore(id);
            ds.Show();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            sql = string.Format("select * from Teacher where ID = '{0}'", Convert.ToInt32(id));
            cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox1.Text = reader.GetValue(1).ToString();
                }
            }
            reader.Close();
            label4.Text = DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss");  
        }
      
    }
}
