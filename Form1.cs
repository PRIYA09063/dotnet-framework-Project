using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dasboard ds = new Dasboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="priya" && txtPassword.Text == "pal")
            {
                Dasboard ds = new Dasboard("Admin");
                ds.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
