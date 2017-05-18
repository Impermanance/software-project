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
    public partial class showcourse : Form
    {
       // private SqlCommand cmd = null;
        private string sql = null;
        private SqlConnection conn = null;
        public string sqls;
        public string id;
        public showcourse(string ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void showcourse_Load(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();

            
                sqls = string.Format("select CID,Cname,Time,Didian,Teacher from Course where CID  in (select ID from selectcourses "
                    + " where SID='{0}')", id);
                SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            
            
        }

       
    }
}
