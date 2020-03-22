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

        private void BrandManagement_Load(object sender, EventArgs e)
        {
            //load data
            LoadDataGridViewByCountry();
            this.countriesTableAdapter.Fill(this.perfume_StoreDataSet.countries);
            //config
            configDataGridView();
            country_nameComboBox.SelectedValue = brandDataGridView.Rows[0].Cells[2].Value;
            createPnl.Hide();

        }

        /// <summary>
        /// Load data to data grid view
        /// </summary>
        public void LoadDataGridViewByCountry()
        {
            this.brandTableAdapter.FillWithCountryName(this.perfume_StoreDataSet.brand);
            brandBindingSource.DataSource = this.perfume_StoreDataSet.brand;
            brandDataGridView.DataSource = brandBindingSource;
        }

        /// <summary>
        /// set up data grid view
        /// </summary>
        private void configDataGridView()
        {
            brandDataGridView.MultiSelect = false;
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
            //set column's display position
            brandDataGridView.Columns["country_name"].DisplayIndex = 2;

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
            if (brandDataGridView.SelectedRows.Count > 0)
            {
                //new data            
                string newBrandName = brand_nameTextBox.Text;
                int newCountryId = (int)country_nameComboBox.SelectedValue;
                DateTime newCreatedTime = brand_createdAtDateTimePicker.Value;
                int newStatus = (int)brand_statusNumericUpDown.Value;

                //old data from grid view
                DataGridViewRow row = brandDataGridView.SelectedRows[0];
                int brandId = (int)row.Cells[0].Value;
                string brandName = (string)row.Cells[1].Value;
                int countryId = (int)row.Cells[2].Value;
                DateTime createdTime = (DateTime)row.Cells[3].Value;
                int status = (int)row.Cells[4].Value;
                //update
                brandTableAdapter.Update(newBrandName, newCountryId, newCreatedTime, newStatus,
                    brandId, brandName, countryId, createdTime, status);
                LoadDataGridViewByCountry();

                MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a record!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (brandDataGridView.SelectedRows.Count > 0)
            {
                DialogResult choice = MessageBox.Show("Are you sure you want to delete?", "Perfume Store Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choice == DialogResult.Yes)
                {
                    int brandId = int.Parse(brand_idTextBox.Text);
                    string brandName = brand_nameTextBox.Text;
                    int countryId = (int)country_nameComboBox.SelectedValue;
                    DateTime createdTime = brand_createdAtDateTimePicker.Value;
                    int status = (int)brand_statusNumericUpDown.Value;
                    brandTableAdapter.Delete(brandId, brandName, countryId, createdTime, status);

                    LoadDataGridViewByCountry();
                }
            }
            else
            {
                MessageBox.Show("Please select a record!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrandManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void brandDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int countryId = (int)brandDataGridView.SelectedRows[0].Cells[2].Value;
            country_nameComboBox.SelectedValue = countryId;
        }

        /// <summary>
        /// Clear Data in all fields
        /// </summary>
        private void createClearData()
        {
            createBrand_nameTextBox.Clear();
            createCountry_idComboBox.SelectedItem = 0;
            createStatusComboBox.SelectedIndex = 0;
        }

        private void returnToListBtn_Click(object sender, EventArgs e)
        {
            createPnl.Hide();

        }

        private void createClearBtn_Click(object sender, EventArgs e)
        {
            createClearData();
        }

        private void createCreateBtn_Click(object sender, EventArgs e)
        {
            //check empty
            if (createBrand_nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Text fields can't be empty", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string brandName = createBrand_nameTextBox.Text;
                int countryId = (int)createCountry_idComboBox.SelectedValue;
                DateTime currentTime = DateTime.Now;
                string createdTime = currentTime.ToString("s");
                int status = createStatusComboBox.SelectedIndex;

                brandTableAdapter.Insert(brandName, countryId, currentTime, status);

                LoadDataGridViewByCountry();

                //focus on new row
                brandDataGridView.Rows[brandDataGridView.RowCount - 1].Selected = true;
                brandDataGridView.CurrentCell = brandDataGridView.Rows[brandDataGridView.RowCount - 1].Cells[0];

                MessageBox.Show("New Record has been created!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                createPnl.Hide();
                createClearData();
            }
        }
    }
}
