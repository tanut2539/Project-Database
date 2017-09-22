using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_database
{
    public partial class Main : Form
    {
        string id = "";
        public Main(string data)
        {
            InitializeComponent();
            id = data;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private int count = 1;

        private void buy_Click(object sender, EventArgs e)
        {
            buy B = new buy(this.id);
            B.MdiParent = this;
            B.Text = "Buy " + count;
            B.Show();
            count += 1;
        }

        private void add_Click(object sender, EventArgs e)
        {
            add A = new add();
            A.MdiParent = this;
            A.Text = "Add "+ count;
            A.Show();
            count += 1;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit E = new edit();
            E.MdiParent = this;
            E.Text = "Edit " + count;
            E.Show();
            count += 1;
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            Reports R = new Reports();
            R.MdiParent = this;
            R.Text = "Reports " + count;
            R.Show();
            count += 1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {

                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }
    }
}
