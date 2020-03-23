using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PefumeStore.Management_Interface
{
    public partial class OrderItemManagement : Form
    {
        public OrderItemManagement()
        {
            InitializeComponent();
        }

        private void orderItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void OrderItemManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.orderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter.Fill(this.perfume_StoreDataSet.orderItem);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Return to Main Menu?", "Perfume Store Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                Hide();
                Admin_Menu am = new Admin_Menu();
                am.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.orderItemBindingSource.AddNew();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.orderItemBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.orderItemBindingSource.MoveNext();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            this.orderItemBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);
        }
    }
}
