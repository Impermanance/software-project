using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Students : Form
    {
        public string id;
        public string password;
        public Students(string ID,string Password)
        {
            InitializeComponent();
            id = ID;
            password = Password;

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
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


   
       
    }
}
