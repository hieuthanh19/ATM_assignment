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
    public partial class report_cost : Form
    {
        public report_cost()
        {
            InitializeComponent();
        }

        private void report_cost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.perfume_StoreDataSet.orders);
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.category' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            
        }

        private void btbS_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.FillBy(this.perfume_StoreDataSet.orders, dateTimePicker1.Text, dateTimePicker2.Text);
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
