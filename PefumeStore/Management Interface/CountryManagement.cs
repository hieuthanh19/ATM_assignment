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

        private void CountryManagement_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.perfume_StoreDataSet.countries);

            createPnl.Hide();
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
            createPnl.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Validate();
            countriesBindingSource.EndEdit();
            countriesTableAdapter.Update(perfume_StoreDataSet.countries);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (countriesDataGridView.SelectedRows.Count > 0)
            {
                DialogResult choice = MessageBox.Show("Are you sure you want to delete?", "Perfume Store Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    int countryId = int.Parse(country_idTextBox.Text);
                    string countryName = country_nameTextBox.Text;
                    int status = (int)country_statusComboBox.SelectedIndex;
                    DateTime createdAt = country_createdAtDateTimePicker.Value;
                    countriesTableAdapter.Delete(countryId, countryName, status, createdAt);

                    //Update Data grid view                
                    countriesTableAdapter.Fill(this.perfume_StoreDataSet.countries);
                    countriesBindingSource.DataSource = this.perfume_StoreDataSet.countries;
                    countriesDataGridView.DataSource = countriesBindingSource;
                }
            }
            else
            {
                MessageBox.Show("Please select a record!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountryManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Clear Data in all fields
        /// </summary>
        private void createClearData()
        {
            createCountry_nameTextBox.Clear();
            createStatusComboBox.SelectedIndex = 0;
        }

        private void returnToListBtn_Click(object sender, EventArgs e)
        {
            createPnl.Hide();
            createClearData();
        }

        private void createClearBtn_Click(object sender, EventArgs e)
        {
            createClearData();
        }

        private void createCreateBtn_Click(object sender, EventArgs e)
        {
            //check empty
            if (createCountry_nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Text fields can't be empty", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string countryName =  createCountry_nameTextBox.Text;
                int status = createStatusComboBox.SelectedIndex;
                countriesTableAdapter.Insert(countryName, status, DateTime.Now);

                //Update Data grid view                
                countriesTableAdapter.Fill(this.perfume_StoreDataSet.countries);
                countriesBindingSource.DataSource = this.perfume_StoreDataSet.countries;
                countriesDataGridView.DataSource = countriesBindingSource;

                //focus on new row
                countriesDataGridView.Rows[countriesDataGridView.RowCount - 1].Selected = true;
                countriesDataGridView.CurrentCell = countriesDataGridView.Rows[countriesDataGridView.RowCount - 1].Cells[0];

                MessageBox.Show("New Record has been created!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                createPnl.Hide();
                createClearData();

            }
        }

        private void countriesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            country_statusComboBox.SelectedIndex = (int)countriesDataGridView.SelectedRows[0].Cells[2].Value;
        }
    }
}
