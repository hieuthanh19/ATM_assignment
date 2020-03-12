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
        private void configDataGridView()
        {
            //bind data
            this.country_nameComboBox.DisplayMember = "country_name";
            //hide country_id column
            brandDataGridView.Columns["country_id"].Visible = false;
            ////set column's width
            //brandDataGridView.Columns["brand_id"].Width = 50;
            //brandDataGridView.Columns["brand_name"].Width = 200;
            //brandDataGridView.Columns["brand_status"].Width = 75;
            //set column's header
            brandDataGridView.Columns["brand_id"].HeaderText = "Brand ID";
            brandDataGridView.Columns["brand_name"].HeaderText = "Brand Name";
            brandDataGridView.Columns["brand_createdAt"].HeaderText = "Created At";
            brandDataGridView.Columns["brand_status"].HeaderText = "Status";
            brandDataGridView.Columns["country_name"].HeaderText = "Country";
            //set column's position
            brandDataGridView.Columns["country_name"].DisplayIndex = 2;                       

        }
        private void BrandManagement_Load(object sender, EventArgs e)
        {
                        
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.FillWithCountryName(this.perfume_StoreDataSet.brand);
            brandBindingSource.DataSource = this.perfume_StoreDataSet.brand;
            brandDataGridView.DataSource = brandBindingSource;
            configDataGridView();

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
                int countryId = (int)country_nameComboBox.SelectedValue;
                DateTime createdTime = brand_createdAtDateTimePicker.Value;
                int status = (int)brand_statusComboBox.SelectedValue;

                brandTableAdapter.Insert(brandName, countryId, createdTime, status);


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
                int countryId = (int)country_nameComboBox.SelectedValue;
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

        private void brandDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillWithCountryNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.brandTableAdapter.FillWithCountryName(this.perfume_StoreDataSet.brand);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillWithCountryNameToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.brandTableAdapter.FillWithCountryName(this.perfume_StoreDataSet.brand);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BrandManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
