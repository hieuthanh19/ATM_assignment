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
    public partial class PaymentMethodManagement : Form
    {
        public PaymentMethodManagement()
        {
            InitializeComponent();
        }

        private void paymentMethodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentMethodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void PaymentMethodManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.paymentMethod' table. You can move, or remove it, as needed.
            this.paymentMethodTableAdapter.Fill(this.perfume_StoreDataSet.paymentMethod);

        }
    }
}
