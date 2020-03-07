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
    public partial class DeliveryMethodManagement : Form
    {
        public DeliveryMethodManagement()
        {
            InitializeComponent();
        }

        private void deliveryMethodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryMethodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void DeliveryMethodManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.deliveryMethod' table. You can move, or remove it, as needed.
            this.deliveryMethodTableAdapter.Fill(this.perfume_StoreDataSet.deliveryMethod);

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
    }
}
