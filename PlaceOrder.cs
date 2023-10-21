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
    public partial class PlaceOrder : Form
    {
        function fn = new function();
        String query;
        public PlaceOrder()
        {
            InitializeComponent();
        }
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for add only same category items in list
            String category = comboCategory.Text;
            //take data from database based on selected category
            query = "Select name from Category where category = '"+category+"' ";
            showItemList(query);
        }

        //search box
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            //for searching data from list. 
            query = "Select name from Category where category = '" + category + "' and name like'"+txtSearch.Text+"%' ";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }
        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();

            //display selected item to Itemname 
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;

            //display selected item Price  
            query = "select price from Category where name = '" + text + "'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
            

        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        //add data order list.
        protected int n, total = 0;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            //For placing an order there should be atleast one quantity.
            if(txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }

        //remove items from order list
        int amount;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }

            total -= amount;
            labelTotalAmount.Text = "Rs. " + total;
        }

        //payment 


    }
}
