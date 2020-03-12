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
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void btnProductMng_Click(object sender, EventArgs e)
        {
            Hide();
            ProductManagement pm = new ProductManagement();
            pm.Show();
        }

        private void btnCategoryMng_Click(object sender, EventArgs e)
        {
            Hide();
            CategoryManagement cm = new CategoryManagement();
            cm.Show();
        }

        private void btnBrandMng_Click(object sender, EventArgs e)
        {
            Hide();
            BrandManagement bm = new BrandManagement();
            bm.Show();
        }

        private void btnCountryMng_Click(object sender, EventArgs e)
        {
            Hide();
            CountryManagement cm = new CountryManagement();
            cm.Show();
        }

        private void btnOrderMng_Click(object sender, EventArgs e)
        {
            Hide();
            OrderManagement om = new OrderManagement();
            om.Show();
        }

        private void btnDeliveryMethodMng_Click(object sender, EventArgs e)
        {
            Hide();
            DeliveryMethodManagement dmm = new DeliveryMethodManagement();
            dmm.Show();
        }

        private void btnPaymentMethodMng_Click(object sender, EventArgs e)
        {
            Hide();
            PaymentMethodManagement pmm = new PaymentMethodManagement();
            pmm.Show();
        }

        private void btnUserMng_Click(object sender, EventArgs e)
        {
            Hide();
            UserManagement um = new UserManagement();
            um.Show();
        }

        private void btnUserRoleMng_Click(object sender, EventArgs e)
        {
            Hide();
            UserRoleManagement urm = new UserRoleManagement();
            urm.Show();

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void Admin_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
