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
        /// Set data for combo box according to current selected row
        /// </summary>
        public void loadComboBox()
        {
            //disable combo boxes
            productCreatedBy_ComboBox.Enabled = false;
            productCreatedBy_ComboBox.Enabled = false;

            //get IDs
            int categoryId = (int)productDataGridView.CurrentRow.Cells[4].Value;
            int brandId = (int)productDataGridView.CurrentRow.Cells[5].Value;
            int createdById = -1;
            int updatedById = -1;
            if (productDataGridView.CurrentRow.Cells[11].Value.Equals(""))
                createdById = (int)productDataGridView.CurrentRow.Cells[11].Value;
            if (productDataGridView.CurrentRow.Cells[13].Value.Equals(""))
                updatedById = (int)productDataGridView.CurrentRow.Cells[13].Value;
            //Set combo box
            categoryComboBox.SelectedValue = categoryId;
            brandComboBox.SelectedValue = brandId;

            if (createdById == -1)
            {
                productCreatedBy_ComboBox.SelectedValue = createdById;
                productCreatedBy_ComboBox.Enabled = true;
            }

            if (updatedById == -1)
            {
                productUpdatedBy_comboBox.SelectedValue = updatedById;
                productCreatedBy_ComboBox.Enabled = true;
            }


        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.orderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter.Fill(this.perfume_StoreDataSet.orderItem);
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.perfume_StoreDataSet.users);
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.perfume_StoreDataSet.brand);
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.perfume_StoreDataSet.category);
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.perfume_StoreDataSet.product);

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
                int productId = int.Parse(product_idTextBox.Text);
                string productName = product_nameTextBox.Text;
                double productVolumne = int.Parse(product_volumneMaskedTxtBox.Text);
                int productQuantity = int.Parse(product_quantityMaskedTxtBox.Text);
                int categoryId = (int)categoryComboBox.SelectedValue;
                int brandId = (int)brandComboBox.SelectedValue;
                double originalPrice = double.Parse(product_originalPriceMaskedTextBox.Text);
                double currentPrice = double.Parse(product_currentPriceMaskedTextBox.Text);
                string description = product_descriptionTextBox.Text;
                int status = (int)product_statusCombobox.SelectedValue;
                DateTime createdTime = product_createdAtDateTimePicker.Value;
                int createdBy = (int)productCreatedBy_ComboBox.SelectedValue;
                DateTime updatedAt = product_updatedAtDateTimePicker.Value;
                int updatedBy = (int)productUpdatedBy_comboBox.SelectedValue;

                productTableAdapter.Insert(productId, productName, productVolumne, productQuantity, categoryId, brandId, originalPrice, currentPrice, description, status, createdTime, createdBy, updatedAt, updatedBy);


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
                double productVolumne = int.Parse(product_volumneMaskedTxtBox.Text);
                int productQuantity = int.Parse(product_quantityMaskedTxtBox.Text);
                int categoryId = (int)categoryComboBox.SelectedValue;
                int brandId = (int)brandComboBox.SelectedValue;
                double originalPrice = double.Parse(product_originalPriceMaskedTextBox.Text);
                double currentPrice = double.Parse(product_currentPriceMaskedTextBox.Text);
                //string description = product_descriptionTextBox.Text;
                int status = (int)product_statusCombobox.SelectedValue;
                DateTime createdTime = product_createdAtDateTimePicker.Value;
                int createdBy = (int)productCreatedBy_ComboBox.SelectedValue;
                DateTime updatedAt = product_updatedAtDateTimePicker.Value;
                int updatedBy = (int)productUpdatedBy_comboBox.SelectedValue;

                productTableAdapter.Delete(productId, productName, productVolumne, productQuantity, categoryId, brandId, originalPrice, currentPrice, status, createdTime, createdBy, updatedAt, updatedBy);

                //Update Data grid view
                productDataTable productDatatable = new productDataTable();
                productTableAdapter.Fill(productDatatable);
                productBindingSource.DataSource = productDatatable;
                productDataGridView.DataSource = productDatatable;
            }
        }

        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            loadComboBox();
        }
    }
}
