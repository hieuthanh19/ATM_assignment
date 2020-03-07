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
    public partial class CountryManagement : Form
    {
        public CountryManagement()
        {
            InitializeComponent();
        }

        private void countriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void CountryManagement_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.perfume_StoreDataSet.countries);

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
            if (country_nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Text fields can't be empty", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int countryId = int.Parse(country_idTextBox.Text);
                string countryName = country_nameTextBox.Text;
                int status = (int)countryStatusCombobox.SelectedValue;
                countriesTableAdapter.Insert(countryId, countryName, status, null);

                //Update Data grid view
                countriesDataTable countryDatatable = new countriesDataTable();
                countriesTableAdapter.Fill(countryDatatable);
                countriesBindingSource.DataSource = countryDatatable;
                countriesDataGridView.DataSource = countryDatatable;

                //focus on new row
                countriesDataGridView.Rows[countriesDataGridView.RowCount - 1].Selected = true;
                countriesDataGridView.CurrentCell = countriesDataGridView.Rows[countriesDataGridView.RowCount - 1].Cells[0];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Validate();
            countriesBindingSource.EndEdit();
            countriesTableAdapter.Update(perfume_StoreDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete?", "Perfume Store Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                int countryId = int.Parse(country_idTextBox.Text);
                string countryName = country_nameTextBox.Text;
                int status = (int)countryStatusCombobox.SelectedValue;
                DateTime createdAt = country_createdAtDateTimePicker.Value;
                countriesTableAdapter.Delete(countryId, countryName, status, createdAt);
                
                //Update Data grid view
                countriesDataTable countryDatatable = new countriesDataTable();
                countriesTableAdapter.Fill(countryDatatable);
                countriesBindingSource.DataSource = countryDatatable;
                countriesDataGridView.DataSource = countryDatatable;                
            }
        }
    }
}
