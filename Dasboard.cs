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
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
        }

        public Dasboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if(user == "Admin")
            {
                btnPlaceOrder.Hide();
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }
        }

       
        /*
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        */
        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1 ();
            this.Hide();
            fm.Show();
            /*
            Dasboard ds = new Dasboard();
            UpdateItem ui = new UpdateItem();
            AddItems ai = new AddItems();
            ds.Hide();
            ui.Hide();
            ai.Hide();
            */

        }

        int num = 0;
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBanner.Location = new Point(592, 462);
                labelBanner.ForeColor = Color.Yellow;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.Location = new Point(166, 367);
                labelBanner.ForeColor = Color.GreenYellow;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(268, 367);
                labelBanner.ForeColor = Color.OrangeRed;
                num = 0;
            }
        }
        */
       
        /*
        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (num == 0)
            {
                labelBanner.Location = new Point(192, 367);
                labelBanner.ForeColor = Color.Yellow;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.Location = new Point(256, 367);
                labelBanner.ForeColor = Color.GreenYellow;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(327, 367);
                labelBanner.ForeColor = Color.OrangeRed;
                num = 0;
            }
        }
        */
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        /*
        private void labelBanner_Click(object sender, EventArgs e)
        {

        }
        */
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem ri = new RemoveItem();
            ri.Show();

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            AddItems ad = new AddItems();
            ad.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrder po = new PlaceOrder();
            po.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateItem ut = new UpdateItem();
            ut.Show();
        }
        private void Dasboard_Load(object sender, EventArgs e)
        {
          
        }
        /*
        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        */
    }

}
