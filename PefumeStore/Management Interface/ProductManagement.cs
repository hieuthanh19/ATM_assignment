using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PefumeStore.Perfume_StoreDataSet;

namespace PefumeStore.Management_Interface
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        /// <summary>
        /// Set up data grid view  
        /// </summary>
        public void configDataGridViewForFillByBrandAndCategory()
        {
            //bind data
            categoryComboBox.DisplayMember = "category_name";
            brandComboBox.DisplayMember = "brand_name";
            //set visible
            productDataGridView.Columns["category_id"].Visible = false;
            productDataGridView.Columns["brand_id"].Visible = false;
            //set headers
            productDataGridView.Columns["product_id"].HeaderText = "ID";
            productDataGridView.Columns["product_name"].HeaderText = "Name";
            productDataGridView.Columns["category_name"].HeaderText = "Category";
            productDataGridView.Columns["brand_name"].HeaderText = "Brand";
            productDataGridView.Columns["product_volumne"].HeaderText = "Volumne";
            productDataGridView.Columns["product_quantity"].HeaderText = "Quantity";
            productDataGridView.Columns["product_originalPrice"].HeaderText = "Original Price";
            productDataGridView.Columns["product_currentPrice"].HeaderText = "Current Price";
            productDataGridView.Columns["product_description"].HeaderText = "Description";
            productDataGridView.Columns["product_status"].HeaderText = "Status";
            productDataGridView.Columns["product_createdAt"].HeaderText = "Created At";
            productDataGridView.Columns["product_updatedAt"].HeaderText = "Updated At";
            //set column display position
            productDataGridView.Columns["category_name"].DisplayIndex = 2;
            productDataGridView.Columns["brand_name"].DisplayIndex = 3;
            //set column width
            productDataGridView.Columns["product_id"].Width = 50;
            productDataGridView.Columns["product_name"].Width = 200;
            productDataGridView.Columns["product_volumne"].Width = 75;
            productDataGridView.Columns["product_quantity"].Width = 75;
            productDataGridView.Columns["product_originalPrice"].Width = 75;
            productDataGridView.Columns["product_currentPrice"].Width = 75;
            productDataGridView.Columns["product_description"].Width = 250;
            productDataGridView.Columns["product_status"].Width = 50;

        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.product' table. You can move, or remove it, as needed.

            this.productTableAdapter.FillByBrandAndCategory(this.perfume_StoreDataSet.product);
            productBindingSource.DataSource = this.perfume_StoreDataSet.product;
            productDataGridView.DataSource = productBindingSource;
            configDataGridViewForFillByBrandAndCategory();
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
            //check empty
            if (product_nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Text fields can't be empty", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string productName = product_nameTextBox.Text;
                double productVolumne = (int)product_volumneNumericUpDown.Value;
                int productQuantity = (int)product_quantityNumericUpDown.Value;                
                int categoryId = (int)categoryComboBox.SelectedValue;
                int brandId = (int)brandComboBox.SelectedValue;
                double originalPrice = double.Parse(product_originalPriceMaskedTextBox.Text);
                double currentPrice = double.Parse(product_currentPriceMaskedTextBox.Text);
                string description = product_descriptionTextBox.Text;
                int status = (int)product_statusCombobox.SelectedValue;
                DateTime createdTime = product_createdAtDateTimePicker.Value;
                DateTime updatedAt = product_updatedAtDateTimePicker.Value;

                productTableAdapter.Insert(productName, productVolumne, productQuantity, categoryId, brandId, originalPrice, currentPrice, description, status, createdTime, updatedAt);

                //Update Data grid view
                productDataTable productDatatable = new productDataTable();
                productTableAdapter.Fill(productDatatable);
                productBindingSource.DataSource = productDatatable;
                productDataGridView.DataSource = productDatatable;

                //focus on new row
                productDataGridView.Rows[productDataGridView.RowCount - 1].Selected = true;
                productDataGridView.CurrentCell = productDataGridView.Rows[productDataGridView.RowCount - 1].Cells[0];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Validate();
            productBindingSource.EndEdit();
            productTableAdapter.Update(perfume_StoreDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete?", "Perfume Store Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                int productId = int.Parse(product_idTextBox.Text);
                string productName = product_nameTextBox.Text;
                double productVolumne = (int)product_volumneNumericUpDown.Value;
                int productQuantity = (int)product_quantityNumericUpDown.Value;
                int categoryId = (int)categoryComboBox.SelectedValue;
                int brandId = (int)brandComboBox.SelectedValue;
                double originalPrice = double.Parse(product_originalPriceMaskedTextBox.Text);
                double currentPrice = double.Parse(product_currentPriceMaskedTextBox.Text);
                //string description = product_descriptionTextBox.Text;
                int status = (int)product_statusCombobox.SelectedValue;
                DateTime createdTime = product_createdAtDateTimePicker.Value;                
                DateTime updatedAt = product_updatedAtDateTimePicker.Value;                

                productTableAdapter.Delete(productId, productName, productVolumne, productQuantity, categoryId, brandId, originalPrice, currentPrice, status, createdTime, updatedAt);

                //Update Data grid view
                productDataTable productDatatable = new productDataTable();
                productTableAdapter.Fill(productDatatable);
                productBindingSource.DataSource = productDatatable;
                productDataGridView.DataSource = productDatatable;
            }
        }

       

        private void proImgBtn_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(product_idTextBox.Text);
            ProductImagesManagement product_Images_Management = new ProductImagesManagement(productId);
            product_Images_Management.Show();
        }

        private void ProductManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
