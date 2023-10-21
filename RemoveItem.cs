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
    public partial class RemoveItem : Form
    {
        function fn = new function();
        String query;
        public RemoveItem()
        {
            InitializeComponent();
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            Dellabel.Text = "How to Delete ?";
            loadData();
        }

        public void loadData()
        {
            query = "select * from Category";
            DataSet ds =  fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Category where name like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item ?","Import Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from Category where iid = '" + id + "'";
                fn.setData(query);
                loadData();
            }
        }

        private void Dellabel_Click(object sender, EventArgs e)
        {
            Dellabel.ForeColor = Color.Red;
            Dellabel.Text = "Click on row to delete item";
        }

        private void RemoveItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
