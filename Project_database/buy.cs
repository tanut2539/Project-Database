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
    public partial class buy : Form
    {
        string eid = "";
        public buy(string data)
        {
            InitializeComponent();
            eid = data;
            timer1.Start();
            date = DateTime.Today.ToLongDateString();
            time = DateTime.Now.ToString("HH:mm:ss");
        }

        // ส่วนสร้างตารางเก็บสินค้าผู้ที่มาซื้อ

        DataTable dt = new DataTable();

        // ส่วนเชื่อมต่อฐานข้อมูล
        SqlConnection Connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Toey\Desktop\Allnew\database\Project_database\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand Cmd;
        SqlDataReader read;
        string sql = null;

        private void buy_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Pid", typeof(string));
            dt.Columns.Add("PName", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Qty", typeof(int));
            dt.Columns.Add("Total", typeof(int));
            // แสดงข้อมูลพนักงานที่เข้าระบบ
            Connect.Open();
            sql = "SELECT *FROM Employee WHERE id = '"+eid+"'";
            Cmd = new SqlCommand(sql, Connect);
            read = Cmd.ExecuteReader();
            if (read.Read())
            {
                E_id.Text = read["id"].ToString();
                E_Fname.Text = read["FName"].ToString();
                E_Lname.Text = read["Lname"].ToString();
                name = read["FName"].ToString();
                read.Close();
            }
            Connect.Close();
        }

        int i = 0, j = 0, total = 0, amt = 0, q = 0, qty = 0, price = 0;
        string name = "";
        string date = "";
        string time = "";
        string pid = "";

        private void txt_pid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_pid.Text != "")
                {
                    // เปิดฐานข้อมูล
                    Connect.Close();
                    Connect.Open();
                    sql = "SELECT *FROM Products WHERE Pid = '" + txt_pid.Text + "'";
                    Cmd = new SqlCommand(sql, Connect);
                    read = Cmd.ExecuteReader();
                    if (read.Read())
                    {
                        lbl_pname.Text = read["Pname"].ToString();
                        lbl_price.Text = read["Price"].ToString();
                        if (MessageBox.Show("เพิ่มสินค้าลงในรายการเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            // คำนวณ ราคา ใส่ลงใน datagridview
                            qty = Convert.ToInt32(numericUpDown1.Value);
                            price = Convert.ToInt32(lbl_price.Text);
                            total = qty * price;
                            // เพิ่มข้อมูลลงบน datagridview
                            dt.Rows.Add(txt_pid.Text, lbl_pname.Text, lbl_price.Text, numericUpDown1.Value, total);
                            viewreport.DataSource = dt;
                            // คำนวณเพื่อหาราคาสินค้ารวม
                            Double l = 0;
                            for (i = 0; i < viewreport.Rows.Count - 1; i++)
                            {
                                l += Convert.ToInt32(viewreport.Rows[i].Cells[4].Value);
                            }
                            lbl_price2.Text = l.ToString();
                            // ตัดสินค้าออกจากคลัง
                            q = Convert.ToInt32(read["Qty"]);
                            amt = q - qty;
                            read.Close();
                            SqlCommand update = new SqlCommand("UPDATE Products SET Qty ='" + amt + "' WHERE (Pid = N'" + txt_pid.Text + "')", Connect);
                            update.ExecuteNonQuery();
                            // คลียเป็นค่าว่างเพื่อเพิ่มสินค้าใหม่
                            txt_pid.Text = "";
                            lbl_pname.Text = "";
                            numericUpDown1.Value = 1;
                            lbl_price.Text = "";
                        }
                        Connect.Close();
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบรหัสสินค้าที่ต้องการ", "Wraning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("ข้อมูลไม่ถูกต้องโปรดกรอกข้อมูลให้ครบถ้วน", "Wraning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void money_ValueChanged(object sender, EventArgs e)
        {
            Double p = 0;
            p = Convert.ToInt32(lbl_price2.Text);
            Double s = Convert.ToDouble(money.Value) - p;
            lbl_change.Text = s.ToString();
        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            Connect.Close();
            // บันทึกรหัสสินค้า
            for (j = 0; j < viewreport.Rows.Count - 1; j++)
            {
                pid += Convert.ToString(viewreport.Rows[j].Cells[0].Value);
            }
            // บันทึกรายงานการขาย
            Connect.Open();
            sql = "INSERT INTO Reports (Eid, Fname, Sales, Pid, Date, Time) VALUES (@Eid, N'" + name + "', '" + lbl_price2.Text + "', '" + pid + "', '" + date + "', '" + time + "')";
            Cmd = new SqlCommand(sql, Connect);
            Cmd.Parameters.AddWithValue("@Eid", eid);
            Cmd.ExecuteNonQuery();
            Connect.Close();
            MessageBox.Show("สำเร็จ", "Sales summary", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lbl_price2.Text = "0";
            money.Value = 0;
            lbl_change.Text = "0";
            dt.Clear();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            lbl_price2.Text = "0";
            money.Value = 0;
            lbl_change.Text = "0";
            dt.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            L_date.Text = DateTime.Now.ToString();
        }
    }
}