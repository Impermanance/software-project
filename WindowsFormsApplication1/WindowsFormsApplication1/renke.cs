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
    public partial class renke : Form
    {
        private string sql = null;
        private SqlConnection conn = null;
        public string sqls;
        public string id;
        public renke(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void renke_Load(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();

            sqls = string.Format("select DISTINCT zhijiao.CID,Course.CName,Course.Time,Course.Didian  from zhijiao,Course,Teacher"
            +" where  TID='{0}' "
            +" and zhijiao.CID=Course.CID "
            +" and zhijiao.TID=Teacher.ID ", id);
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
