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
    public partial class xiugairenke : Form
    {
        private string sql = null;
        private SqlConnection conn = null;
  //      private SqlCommand cmd = null;
        public xiugairenke()
        {
            InitializeComponent();
        }

        private void xiugairenke_Load(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();

            string sqls = string.Format("select Cname from Course");
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            sqls = string.Format("select Name from Teacher");
            SqlDataAdapter daa = new SqlDataAdapter(sqls, conn);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            dataGridView2.DataSource = dss.Tables[0];

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                    {
                        for (int j = 0; j < dataGridView2.Rows.Count; j++)
                        {
                            if ((bool)dataGridView2.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                string sqls = string.Format("insert into zhijiao values((select CID from Course where Cname='{0}'),(select ID from Teacher where Name='{1}'))"
                                    ,dataGridView1.Rows[i].Cells[1].Value.ToString()
                                    ,dataGridView2.Rows[j].Cells[1].Value.ToString());
                                SqlCommand cmdl = new SqlCommand(sqls, conn);
                                cmdl.ExecuteNonQuery();
                            }
                    
                        }
                    }

                }
                MessageBox.Show("任课信息添加成功！");
                string sqlss = string.Format("select Cname from Course");
                SqlDataAdapter da = new SqlDataAdapter(sqlss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                sqlss = string.Format("select Name from Teacher");
                SqlDataAdapter daa = new SqlDataAdapter(sqlss, conn);
                DataSet dss = new DataSet();
                daa.Fill(dss);
                dataGridView2.DataSource = dss.Tables[0];
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
