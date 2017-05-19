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

        }
    }
}
