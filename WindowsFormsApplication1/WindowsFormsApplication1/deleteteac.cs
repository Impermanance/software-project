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
    public partial class deleteteac : Form
    {
        private string sql = null;
        private SqlConnection conn = null;
  //      private SqlCommand cmd = null;
        public deleteteac()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;

            }

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
                        string sqls = string.Format("delete from zhijiao where TID='{0}'", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        SqlCommand cmdl = new SqlCommand(sqls, conn);
                        cmdl.ExecuteNonQuery();
                        sqls = string.Format("delete from Scores where TeacherName=(select Name from Teacher where ID='{0}')", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        SqlCommand cmdll = new SqlCommand(sqls, conn);
                        cmdll.ExecuteNonQuery();
                        sqls = string.Format("delete from Course where Teacher=(select Name from Teacher where ID='{0}')", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        SqlCommand cmdlll = new SqlCommand(sqls, conn);
                        cmdlll.ExecuteNonQuery();
                        sqls = string.Format("delete from Teacher where ID='{0}'", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        SqlCommand cmdllll = new SqlCommand(sqls, conn);
                        cmdllll.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("教师信息删除成功！");
                string sqlss = string.Format("select ID,Name,Sex,Birthday,Grade,zhicheng,Face,Tel,Address from Teacher");
                SqlDataAdapter da = new SqlDataAdapter(sqlss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
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

        private void deleteteac_Load(object sender, EventArgs e)
        {
            sql = @"server=.\sqlexpress;database= student;Integrated Security=SSPI";
            conn = new SqlConnection(sql);
            conn.Open();

            string sqls = string.Format("select ID,Name,Sex,Birthday,Grade,zhicheng,Face,Tel,Address from Teacher");
            SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
