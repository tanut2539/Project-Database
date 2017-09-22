using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_database
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            timer1.Start();
        }

        // datagridview
        DataSet ds = new DataSet();
        // ส่วนเชื่อมต่อฐานข้อมูล
        SqlConnection Connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Toey\Desktop\Allnew\database\Project_database\Database1.mdf;Integrated Security=True;User Instance=True");
        string sql = null;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            sql = "SELECT *FROM Reports";
            SqlDataAdapter da = new SqlDataAdapter(sql, Connect);
            da.Fill(ds, "id");
            viewreport.DataSource = ds.Tables["id"];
        }
    }
}
