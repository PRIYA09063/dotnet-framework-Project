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
    public partial class UpdateItem : Form
    {
        function fn = new function();
        String query;
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            
            loadData();
        }

        public void loadData()
        {
            query = "select * from Category";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Category where name like '" + txtSearchItem.Text + "%'";
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update Category set name  = '" + txtName.Text + "', category = '" + txtCategory.Text + "',price = '" + txtPrice.Text + "' where iid = '"+id+"' ";
            fn.setData(query);
            loadData();
            txtName.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
        }
    }
}
