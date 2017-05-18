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
    public partial class Teachersinformation : Form
    {
        public int isok = 0;
        public string id;
        public Teachersinformation(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void bt_resume_Click(object sender, EventArgs e)
        {
            isok = 1;
            tb_address.ReadOnly = false;
            tb_bir.ReadOnly = false;
            tb_xueli.ReadOnly = false; ;
            tb_id.ReadOnly = false;
            tb_name.ReadOnly = false;
            tb_zhicheng.ReadOnly = false;
            pwdd.ReadOnly = false;
            depart.ReadOnly = false;
            telp.ReadOnly = false;
            button1.Enabled = true;
        }
    }
}
