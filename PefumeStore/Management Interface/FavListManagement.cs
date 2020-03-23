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
    public partial class FavListManagement : Form
    {
        public FavListManagement()
        {
            InitializeComponent();
        }

        private void favListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.favListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);

        }

        private void FavListManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.favList' table. You can move, or remove it, as needed.
            this.favListTableAdapter.Fill(this.perfume_StoreDataSet.favList);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.favListBindingSource.AddNew();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.favListBindingSource.RemoveCurrent();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.favListBindingSource.MoveNext();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            this.favListBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.favListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfume_StoreDataSet);
        }
    }
}
