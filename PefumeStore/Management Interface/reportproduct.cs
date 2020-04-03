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
    public partial class reportproduct : Form
    {
        public reportproduct()
        {
            InitializeComponent();
        }

        private void reportproduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.perfume_StoreDataSet.DataTable1);

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.perfume_StoreDataSet.DataTable1);
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            //this.dataTable1TableAdapter.Fill(this.perfume_StoreDataSet.DataTable1);
        }

        private void btbS_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.FillBy(this.perfume_StoreDataSet.DataTable1, dateTimePicker1.Text, dateTimePicker2.Text);

            this.reportViewer1.RefreshReport();
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
