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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.perfume_StoreDataSet.orders);

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

        private void order_receiverPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_receiverEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deliveryMethod_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_deliveryStatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_createdAtDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void order_updatedAtDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void order_deliveredAtDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
