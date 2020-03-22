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

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.product' table. You can move, or remove it, as needed.
            LoadDataGridViewByCategoryNBrand();
            this.brandTableAdapter.Fill(this.perfume_StoreDataSet.brand);
            this.categoryTableAdapter.Fill(this.perfume_StoreDataSet.category);

            configDataGridViewForFillByBrandAndCategory();
            createPnl.Hide();
            //set default selected value for combo boxes

            categoryComboBox.SelectedValue = this.productDataGridView.Rows[0].Cells[4].Value;
            brandComboBox.SelectedValue = this.productDataGridView.Rows[0].Cells[5].Value;
            product_statusComboBox.SelectedIndex = (int)this.productDataGridView.Rows[0].Cells[9].Value;
        }

        public void LoadDataGridViewByCategoryNBrand()
        {
            this.productTableAdapter.FillByBrandAndCategory(this.perfume_StoreDataSet.product);
            productBindingSource.DataSource = this.perfume_StoreDataSet.product;
            productDataGridView.DataSource = productBindingSource;
        }

        /// <summary>
        /// Set up data grid view  
        /// </summary>
        public void configDataGridViewForFillByBrandAndCategory()
        {
            //bind data to combo boxes
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
            productDataGridView.Columns["product_volumne"].HeaderText = "Volume";
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
            createClearData();
            createPnl.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count > 0)
            {
                //get new data 
                string newProductName = product_nameTextBox.Text;
                int newCategoryId = (int)categoryComboBox.SelectedValue;
                int newBrandId = (int)brandComboBox.SelectedValue;
                double newProductVolumne = (int)product_volumneNumericUpDown.Value;
                int newProductQuantity = (int)product_quantityNumericUpDown.Value;
                double newOriginalPrice = (double)product_originalPriceNumericUpDown.Value;
                double newCurrentPrice = (double)product_currentPriceNumericUpDown.Value;
                string newDescription = product_descriptionTextBox.Text;
                int newStatus = product_statusComboBox.SelectedIndex;
                DateTime newCreatedTime = product_createdAtDateTimePicker.Value;
                DateTime newUpdatedAt = DateTime.Now;

                //get old data
                DataGridViewRow row = productDataGridView.SelectedRows[0];
                int productId = (int)row.Cells[0].Value;
                string productName = (string)row.Cells[1].Value;
                double productVolumne = (double)row.Cells[2].Value;
                int productQuantity = (int)row.Cells[3].Value;
                int categoryId = (int)row.Cells[4].Value;
                int brandId = (int)row.Cells[5].Value;
                double originalPrice = (double)row.Cells[6].Value;
                double currentPrice = (double)row.Cells[7].Value;
                string description = (string)row.Cells[8].Value;
                int status = (int)row.Cells[9].Value;
                DateTime createdTime = (DateTime)row.Cells[10].Value;
                DateTime updatedAt = (DateTime)row.Cells[11].Value;
                //update product
                productTableAdapter.Update(newProductName, newProductVolumne, newProductQuantity, newCategoryId, newBrandId, newOriginalPrice, newCurrentPrice, newDescription, newStatus, newCreatedTime, newUpdatedAt,
                    productId, productName, productVolumne, productQuantity, categoryId, brandId, originalPrice, currentPrice, status, createdTime, updatedAt);
                LoadDataGridViewByCategoryNBrand();
            }
            else
            {
                MessageBox.Show("Please select a record!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count > 0)
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
                    double originalPrice = (double)product_originalPriceNumericUpDown.Value;
                    double currentPrice = (double)product_currentPriceNumericUpDown.Value;
                    //string description = product_descriptionTextBox.Text;
                    int status = product_statusComboBox.SelectedIndex;
                    DateTime createdTime = product_createdAtDateTimePicker.Value;
                    DateTime updatedAt = product_updatedAtDateTimePicker.Value;

                    productTableAdapter.Delete(productId, productName, productVolumne, productQuantity, categoryId, brandId, originalPrice, currentPrice, status, createdTime, updatedAt);
                    //Update Data grid view
                    LoadDataGridViewByCategoryNBrand();

                    MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a record!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void proImgBtn_Click(object sender, EventArgs e)
        {

            int productId = int.Parse(product_idTextBox.Text);
            string productName = product_nameTextBox.Text;
            ProductImagesManagement product_Images_Management = new ProductImagesManagement(productId, productName);
            product_Images_Management.Show();
        }

        private void ProductManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void productDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryComboBox.SelectedValue = this.productDataGridView.SelectedRows[0].Cells[4].Value;
            brandComboBox.SelectedValue = this.productDataGridView.SelectedRows[0].Cells[5].Value;
            product_statusComboBox.SelectedIndex = (int)this.productDataGridView.SelectedRows[0].Cells[9].Value;
        }

        private void createClearData()
        {
            createProduct_nameTextBox.Clear();
            createProduct_volumneNumericUpDown.Value = 1;
            createProduct_quantityNumericUpDown.Value = 0;
            createBrand_idComboBox.SelectedItem = 0;
            createCategory_idComboBox.SelectedItem = 0;          
            createProduct_originalPriceNumericUpDown.Value = 0;
            createProduct_currentPriceNumericUpDown.Value = 0;
            createProduct_descriptionTextBox.Clear();
            createStatusComboBox.SelectedIndex = 0;
        }

        private void returnToListBtn_Click(object sender, EventArgs e)
        {
            createPnl.Hide();            
        }

        private void createCreateBtn_Click(object sender, EventArgs e)
        {
            //check empty
            if (product_nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Text fields can't be empty", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
            
            else
            {
                string productName = createProduct_nameTextBox.Text;
                double productVolumne = (int)createProduct_volumneNumericUpDown.Value;
                int productQuantity = (int)createProduct_quantityNumericUpDown.Value;
                int categoryId = (int)createCategory_idComboBox.SelectedValue;
                int brandId = (int)createBrand_idComboBox.SelectedValue;
                double originalPrice = (double) createProduct_originalPriceNumericUpDown.Value;
                double currentPrice = (double)createProduct_currentPriceNumericUpDown.Value ;
                string description = createProduct_descriptionTextBox.Text;
                int status = createStatusComboBox.SelectedIndex;
                DateTime createdTime = DateTime.Now;
                DateTime updatedAt = DateTime.Now;

                productTableAdapter.Insert(productName, productVolumne, productQuantity, categoryId, brandId, originalPrice, currentPrice, description, status, createdTime, updatedAt);

                //Update Data grid view
                LoadDataGridViewByCategoryNBrand();

                //focus on new row
                productDataGridView.Rows[productDataGridView.RowCount - 1].Selected = true;
                productDataGridView.CurrentCell = productDataGridView.Rows[productDataGridView.RowCount - 1].Cells[0];
            }
        }

        private void createClearBtn_Click(object sender, EventArgs e)
        {
            createClearData();
        }
    }
}
