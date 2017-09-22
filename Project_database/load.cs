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
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }

        private void load_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login O = new Login();
            O.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
