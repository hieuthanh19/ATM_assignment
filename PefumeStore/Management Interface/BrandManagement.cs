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
    public partial class BrandManagement : Form
    {
        public BrandManagement()
        {
            InitializeComponent();
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void BrandManagement_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.perfume_StoreDataSet.countries);
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.perfume_StoreDataSet.brand);

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
            if (brand_nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Text fields can't be empty", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int brandId = int.Parse(brand_idTextBox.Text);
                string brandName = brand_nameTextBox.Text;
                int countryId = (int)country_idComboBox.SelectedValue;
                DateTime createdTime = brand_createdAtDateTimePicker.Value;
                int status = (int)brand_statusComboBox.SelectedValue;

                brandTableAdapter.Insert(brandId, brandName, countryId, createdTime, status);


                //Update Data grid view
                brandDataTable brandDatatable = new brandDataTable();
                brandTableAdapter.Fill(brandDatatable);
                brandBindingSource.DataSource = brandDatatable;
                brandDataGridView.DataSource = brandDatatable;

                //focus on new row
                brandDataGridView.Rows[brandDataGridView.RowCount - 1].Selected = true;
                brandDataGridView.CurrentCell = brandDataGridView.Rows[brandDataGridView.RowCount - 1].Cells[0];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Validate();
            brandBindingSource.EndEdit();
            brandTableAdapter.Update(perfume_StoreDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete?", "Perfume Store Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                int brandId = int.Parse(brand_idTextBox.Text);
                string brandName = brand_nameTextBox.Text;
                int countryId = (int)country_idComboBox.SelectedValue;
                DateTime createdTime = brand_createdAtDateTimePicker.Value;
                int status = (int)brand_statusComboBox.SelectedValue;
                brandTableAdapter.Delete(brandId, brandName, countryId, createdTime, status);

                //Update Data grid view
                brandDataTable brandDatatable = new brandDataTable();
                brandTableAdapter.Fill(brandDatatable);
                brandBindingSource.DataSource = brandDatatable;
                brandDataGridView.DataSource = brandDatatable;
            }
        }
    }
}
