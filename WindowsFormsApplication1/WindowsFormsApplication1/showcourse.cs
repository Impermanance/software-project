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

        private void tuichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tuike_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            int isok = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    try
                    {
                        string CID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        if (CID != "")
                        {
                            string sqls = string.Format("delete from selectcourses where SID= '{0}' and ID='{1}'", id.ToString(), CID.ToString());
                            SqlCommand cmdl = new SqlCommand(sqls, conn);
                            cmdl.ExecuteNonQuery();
                            isok = 1;
                        }
                        else
                        {
                            MessageBox.Show("选择了无用行");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }

            }
            if (isok == 1)
                MessageBox.Show("退课成功");
            conn.Close();

            string sqlss = string.Format("select CID,Cname,Time,Didian,Teacher from Course where CID  in (select ID from selectcourses "
                    + " where SID='{0}')", id);
            SqlDataAdapter da = new SqlDataAdapter(sqlss, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;

            }
        }


    }
}
