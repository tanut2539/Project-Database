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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        // datagridview
        DataSet ds = new DataSet();
        // ส่วนเชื่อมต่อฐานข้อมูล
        SqlConnection Connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Toey\Desktop\Allnew\database\Project_database\Database1.mdf;Integrated Security=True;User Instance=True");
        string sql = null;

        private void add_Load(object sender, EventArgs e)
        {
            sql = "SELECT *FROM Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, Connect);
            da.Fill(ds, "Pid");
            viewproduct.DataSource = ds.Tables["Pid"];
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" & txt_name.Text != "" & txt_price.Text != "")
            {
                DataRow[] drs = ds.Tables["Pid"].Select("Pid ='" + txt_id.Text + "'");
                if (drs.Length == 0) // Insert
                {
                    DataRow dr = ds.Tables["Pid"].NewRow();
                    dr["Pid"] = txt_id.Text;
                    dr["Pname"] = txt_name.Text;
                    dr["Qty"] = numericUpDown1.Value;
                    dr["Price"] = txt_price.Text;
                    ds.Tables["Pid"].Rows.Add(dr); // เอาข้อมูลใหม่ใส่ database
                    // ส่วนปรับปรุงฐานข้อมูลมูล
                    string sql = "SELECT *FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(sql, Connect);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Pid");
                    //
                    ds.Tables["Pid"].AcceptChanges(); // เปลี่ยนแปลง
                    MessageBox.Show("สำเร็จ", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_id.Text = "";
                    txt_name.Text = "";
                    numericUpDown1.Value = 1;
                    txt_price.Text = "";
                }
                else // มีข้อมูลแจ้งเตือนค่าซ้ำ
                {
                    MessageBox.Show("ขออภัยข้อมูลซ้ำ", "Wraning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                viewproduct.DataSource = ds.Tables["Pid"];
            }
            else // หาก ID,Name และ Price เป็นค่า ว่าง หรือ อย่างใดอย่างหนึ่ง แสดงเตือนข้อมูลไม่ถูกต้อง
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้องโปรดกรอกข้อมูลให้ครบถ้วน", "Wraning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
