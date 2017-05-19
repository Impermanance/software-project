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
    public partial class Teachers : Form
    {
        public string path;
        public string id;
        public Teachers(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm1 = new Form1();
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
      
    }
}
