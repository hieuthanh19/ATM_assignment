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
    public partial class ProductImagesManagement : Form
    {
        public int productId { get; set; }
        public ProductImagesManagement(int productId)
        {
            InitializeComponent();
            this.productId = productId;
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void Product_Images_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.productImg' table. You can move, or remove it, as needed.
            this.productImgTableAdapter.Fill(this.perfume_StoreDataSet.productImg);
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.perfume_StoreDataSet.product);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Validate();
            productImgBindingSource.EndEdit();
            productImgTableAdapter.Update(perfume_StoreDataSet);
        }

        private void ProductImagesManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
