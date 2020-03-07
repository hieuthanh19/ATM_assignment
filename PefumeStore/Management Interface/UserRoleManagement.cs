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
    public partial class UserRoleManagement : Form
    {
        public UserRoleManagement()
        {
            InitializeComponent();
        }

        private void user_roleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_roleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void UserRoleManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.user_role' table. You can move, or remove it, as needed.
            this.user_roleTableAdapter.Fill(this.perfume_StoreDataSet.user_role);

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
