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
    public partial class AddItems : Form
    {
        function fn = new function();
        String query;
        public AddItems()
        {
            InitializeComponent();
        }

        private void AddItems_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */

        
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into Category (name,category,price) values('"+txtItemName.Text+"','"+txtCategory.Text+"',"+txtPrice.Text+")";
            fn.setData(query);
            clearAll();
        }
        //clear additem page data after adding an items
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void btnAddItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
