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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // ส่วนเชื่อมต่อฐานข้อมูล
        SqlConnection Connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Toey\Desktop\Allnew\database\Project_database\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand Cmd;
        SqlDataReader read;
        string sql = null;

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Connect.Open();
            // ตรวจสอบพนักงาน
            sql = "SELECT *FROM [Employee] WHERE ((id = '"+E_id.Text+"') AND (password = '"+E_pass.Text+"'))";
            Cmd = new SqlCommand(sql, Connect);
            read = Cmd.ExecuteReader();
            if(E_id.Text != "" & E_pass.Text != "")
            {
                if (read.Read())
                {
                    Main M = new Main(this.E_id.Text);
                    M.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ไม่พบ Username หรือ Password", "Wraning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                read.Close();
                Connect.Close();
            }
            else
            {
                MessageBox.Show("ผิดพลาด! โปรดกรอก Username หรือ Password", "Wraning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
