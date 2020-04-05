using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace PefumeStore.Management_Interface
{
    public partial class ProductImagesManagement : Form
    {
        #region Form Atttributes
        ImageList imgList = new ImageList();
        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = false,
            ValidateNames = true,
            Filter = "Choose Image(*.jpg;*png;*jpeg)|*.jpg;*png;*jpeg"
        };
        FileInfo fi;
        int count = 0;
        #endregion

        #region product img attributes
        public int productId { get; set; }
        public string productName { get; set; }
        public string imgPath { get; set; }
        #endregion


        public ProductImagesManagement(int productId, string productName)
        {
            InitializeComponent();
            this.productId = productId;
            this.productName = productName;
            this.imgPath = "/img/product/" + productId + "/";
        }

        /// <summary>
        /// Load image store in project ro Data grid
        /// </summary>
        public void LoadImageToDataGrid()
        {
            for (int i = 0; i < productImgDataGridView.Rows.Count; i++)
            {
                int productId = (int)productImgDataGridView.Rows[i].Cells[1].Value;
                string imgName = (string)productImgDataGridView.Rows[i].Cells[2].Value;
                // Directory: img/product/productId/imgname
                string filepath = AppDomain.CurrentDomain.BaseDirectory + "img\\product\\" + productId + "\\" + imgName;
                //Bitmap bmp = new Bitmap(Application.StartupPath + "\\Data\\AirPlaneData\\" + dt.Rows[row][4]);
                productImgDataGridView.Rows[i].Cells[4].Value = null;
                Bitmap bmp = new Bitmap(filepath);
                ((DataGridViewImageCell)productImgDataGridView.Rows[i].Cells[4]).Value = bmp;
            }
        }

        private void Product_Images_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfume_StoreDataSet.productImg' table. You can move, or remove it, as needed.
            this.productImgTableAdapter.FillByProductId(this.perfume_StoreDataSet.productImg, this.productId);
            productImgBindingSource.DataSource = this.perfume_StoreDataSet.productImg;
            productImgDataGridView.DataSource = productImgBindingSource;
            //set product info
            product_idLabel.Text = product_idLabel.Text + " " + this.productId;
            product_nameLabel.Text = product_nameLabel.Text + " " + this.productName;
            //
            LoadImageToDataGrid();


        }

        /// <summary>
        /// Add Image info into Database
        /// </summary>
        /// <param name="imgName"></param>
        public void AddImgToDb(string imgName)
        {
            //int previousImgID = 0;
            //if (productImgDataGridView.RowCount > 0)
            //{
            //    previousImgID = (int)productImgDataGridView.Rows[productImgDataGridView.RowCount - 1].Cells[0].Value;
            //}
            //int currentImgId = ++previousImgID;
            productImgTableAdapter.Insert(this.productId, DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + imgName, 1);
            //Update data grid view 
            productImgTableAdapter.Fill(this.perfume_StoreDataSet.productImg);
            productImgBindingSource.DataSource = this.perfume_StoreDataSet.productImg;
            productImgDataGridView.DataSource = productImgBindingSource;
            //focus on new row
            productImgDataGridView.Rows[productImgDataGridView.RowCount - 1].Selected = true;
            productImgDataGridView.CurrentCell = productImgDataGridView.Rows[productImgDataGridView.RowCount - 1].Cells[0];
        }

        /// <summary>
        /// Add Images to Image List
        /// </summary>
        public void AddImage()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //save new product image to DB
                AddImgToDb(ofd.SafeFileName);
                //add image to new record
                DataGridViewImageCell dataGridViewImageCell = ((DataGridViewImageCell)productImgDataGridView.Rows[productImgDataGridView.RowCount - 1].Cells[4]);
                //using (var memoryStream = new MemoryStream(File.ReadAllBytes(ofd.FileName)))
                //{
                //    using (var image = System.Drawing.Image.FromStream(memoryStream))
                //    {
                //        dataGridViewImageCell.Value = image;
                //    }
                //}
                
                dataGridViewImageCell.Value = System.Drawing.Image.FromFile(ofd.FileName);
                SaveImages();
                LoadImageToDataGrid();

            }
        }
        /// <summary>
        /// Save Images to save path
        /// </summary>
        /// <param name="savePath"></param>
        public void SaveImages()
        {
            //get info in last record
            
            Image myImg = (productImgDataGridView.Rows[productImgDataGridView.RowCount - 1].Cells[4].Value as Image);
            int productId = (int)productImgDataGridView.Rows[productImgDataGridView.RowCount - 1].Cells[1].Value;
            string imgName = (string)productImgDataGridView.Rows[productImgDataGridView.RowCount - 1].Cells[2].Value;
            // Directory: bin/debug/img/product/productId/imgname
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "img\\product\\" + productId + "\\";
            Directory.CreateDirectory(filepath);
            myImg.Save(filepath + imgName, myImg.RawFormat);
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddImage();

            LoadImageToDataGrid();
        }

        private void ProductImagesManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productImgDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = productImgDataGridView.SelectedRows[0];
                int imgId = (int)row.Cells[0].Value;
                int productID = this.productId;
                string imgName = (string)row.Cells[2].Value;
                int status = (int)row.Cells[3].Value;

                productImgTableAdapter.Delete(imgId, productID, imgName, status);
                //load data to grid view
                this.productImgTableAdapter.FillByProductId(this.perfume_StoreDataSet.productImg, this.productId);
                productImgBindingSource.DataSource = this.perfume_StoreDataSet.productImg;
                productImgDataGridView.DataSource = productImgBindingSource;
                LoadImageToDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a record!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (productImgDataGridView.SelectedRows.Count > 0)
            {
                //get old data
                DataGridViewRow row = productImgDataGridView.SelectedRows[0];
                int imgId = (int)row.Cells[0].Value;
                int productID = this.productId;
                string imgName = (string)row.Cells[2].Value;
                int status = (int)row.Cells[3].Value;

                //get new data
                int newStatus = status == 0 ? 1 : 0;

                //update
                productImgTableAdapter.Update(productId, imgName, newStatus, imgId, productId, imgName, status);
                //load data to grid view
                this.productImgTableAdapter.FillByProductId(this.perfume_StoreDataSet.productImg, this.productId);
                productImgBindingSource.DataSource = this.perfume_StoreDataSet.productImg;
                productImgDataGridView.DataSource = productImgBindingSource;
                LoadImageToDataGrid();
                MessageBox.Show("Saved!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a record!", "Perfume Store Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
