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
    public partial class guanliyuan : Form
    {
        public guanliyuan()
        {
            InitializeComponent();
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerseestu ms = new managerseestu();
            ms.Show();
        }

        private void 录入学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuruStu ls = new LuruStu();
            ls.Show();
        }

        private void 查看教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerseeTeac mt = new managerseeTeac();
            mt.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            shouye s = new shouye();
            s.Show();

        }

        private void 录入教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luruteac lt = new Luruteac();
            lt.Show();
        }

        private void 查看课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerseecourse ms = new managerseecourse();
            ms.Show();
        }
    }
}
