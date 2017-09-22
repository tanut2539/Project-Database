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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        // ส่วนเชื่อมต่อฐานข้อมูล
        SqlConnection Connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Toey\Desktop\Allnew\database\Project_database\Database1.mdf;Integrated Security=True;User Instance=True");
        string sql = null;

        private void edit_Load(object sender, EventArgs e)
        {
            // ดึงข้อมูล
            sql = "SELECT *FROM Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, Connect);
            da.Fill(ds, "Pid");
            viewproduct.DataSource = ds.Tables["Pid"];
        }

        private void viewproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewproduct.Rows[e.RowIndex].Selected = true;
            // ดึงจาก DataTable
            DataRow dr = ds.Tables["Pid"].Rows[e.RowIndex];
            txt_id.Text = dr["Pid"].ToString();
            txt_name.Text = dr["Pname"].ToString();
            numericUpDown1.Value = Convert.ToDecimal(dr["Qty"]);
            txt_price.Text = dr["Price"].ToString();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" & txt_name.Text != "" & txt_price.Text != "")
            {
                DataRow[] drs = ds.Tables["Pid"].Select("Pid = '" + txt_id.Text + "'");
                if (drs.Length == 0) // ไม่มีข้อมูล ให้ทำการ Insert
                {
                    DataRow dr = ds.Tables["Pname"].NewRow();
                    dr["Pid"] = txt_id.Text;
                    dr["Pname"] = txt_name.Text;
                    dr["Qty"] = numericUpDown1.Value;
                    dr["Price"] = txt_price.Text;
                    ds.Tables["Pid"].Rows.Add(dr); // เอาข้อมูลใหม่ใส่ให้ database
                    // ส่วนของการปรับปรุงฐานข้อมูล
                    string sql = "SELECT *FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(sql, Connect);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Pid");
                    //
                    ds.Tables["Pid"].AcceptChanges(); // เปลี่ยนแปลง
                }
                else // มีข้อมูล ให้ทำการ Update
                {
                    drs[0]["Pname"] = txt_name.Text;
                    drs[0]["Qty"] = numericUpDown1.Value;
                    drs[0]["Price"] = txt_price.Text;
                    // ส่วนของการปรับปรุงฐานข้อมูล
                    string sql = "SELECT *FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(sql, Connect);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Pid");
                    //
                    ds.Tables["Pid"].AcceptChanges(); // เปลี่ยนแปลง
                }
                viewproduct.DataSource = ds.Tables["Pid"];
                txt_id.Text = "";
                txt_name.Text = "";
                numericUpDown1.Value = 1;
                txt_price.Text = "";
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "Edit Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else // หาก ID,Name และ Price เป็นค่า ว่าง หรือ อย่างใดอย่างหนึ่ง แสดงเตือนข้อมูลไม่ถูกต้อง
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้องโปรดกรอกข้อมูลให้ครบถ้วน", "Wraning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            DataRow[] drs = ds.Tables["Pid"].Select("Pid = '" + txt_id.Text + "'");
            if (drs.Length == 0) // หาไม่เจอ
            {
                MessageBox.Show("ไม่พบข้อมูลที่ต้องการ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else // หาเจอ
            {
                drs[0].Delete(); // ลบข้อมูลในแถว
                // ส่วนของการปรับปรุงฐานข้อมูล
                string sql = "SELECT *FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(sql, Connect);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "Pid");
                //
                ds.Tables["Pid"].AcceptChanges(); // เปลี่ยนแปลง
                //
                txt_id.Text = "";
                txt_name.Text = "";
                numericUpDown1.Value = 1;
                txt_price.Text = "";
                MessageBox.Show("ลบสำเร็จ", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
