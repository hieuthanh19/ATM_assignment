namespace PefumeStore.Management_Interface
{
    partial class ProductImagesManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label img_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductImagesManagement));
            this.btnReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.productImgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productImgTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.productImgTableAdapter();
            this.product_idLabel = new System.Windows.Forms.Label();
            this.product_nameLabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_statusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productImgDataGridView = new System.Windows.Forms.DataGridView();
            this.imgidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgpathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            img_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_statusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // img_statusLabel
            // 
            img_statusLabel.AutoSize = true;
            img_statusLabel.Location = new System.Drawing.Point(3, 54);
            img_statusLabel.Name = "img_statusLabel";
            img_statusLabel.Size = new System.Drawing.Size(92, 17);
            img_statusLabel.TabIndex = 44;
            img_statusLabel.Text = "Image status:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 33;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(153, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(410, 32);
            this.labelTitle.TabIndex = 32;
            this.labelTitle.Text = "Product Images Management";
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brandTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.countriesTableAdapter = null;
            this.tableAdapterManager.deliveryMethodTableAdapter = null;
            this.tableAdapterManager.favListTableAdapter = null;
            this.tableAdapterManager.orderItemTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.paymentMethodTableAdapter = null;
            this.tableAdapterManager.productImgTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(546, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 30);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(546, 85);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(111, 30);
            this.btnChangeStatus.TabIndex = 36;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // productImgBindingSource
            // 
            this.productImgBindingSource.DataMember = "productImg";
            this.productImgBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // productImgTableAdapter
            // 
            this.productImgTableAdapter.ClearBeforeFill = true;
            // 
            // product_idLabel
            // 
            this.product_idLabel.AutoSize = true;
            this.product_idLabel.Location = new System.Drawing.Point(3, 10);
            this.product_idLabel.Name = "product_idLabel";
            this.product_idLabel.Size = new System.Drawing.Size(29, 17);
            this.product_idLabel.TabIndex = 37;
            this.product_idLabel.Text = "ID: ";
            // 
            // product_nameLabel
            // 
            this.product_nameLabel.AutoSize = true;
            this.product_nameLabel.Location = new System.Drawing.Point(3, 37);
            this.product_nameLabel.Name = "product_nameLabel";
            this.product_nameLabel.Size = new System.Drawing.Size(53, 17);
            this.product_nameLabel.TabIndex = 38;
            this.product_nameLabel.Text = "Name: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(546, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 30);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.img_statusNumericUpDown);
            this.panel1.Controls.Add(img_statusLabel);
            this.panel1.Controls.Add(this.product_idLabel);
            this.panel1.Controls.Add(this.product_nameLabel);
            this.panel1.Location = new System.Drawing.Point(15, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 88);
            this.panel1.TabIndex = 44;
            // 
            // img_statusNumericUpDown
            // 
            this.img_statusNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productImgBindingSource, "img_status", true));
            this.img_statusNumericUpDown.Location = new System.Drawing.Point(101, 54);
            this.img_statusNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.img_statusNumericUpDown.Name = "img_statusNumericUpDown";
            this.img_statusNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.img_statusNumericUpDown.TabIndex = 45;
            // 
            // productImgDataGridView
            // 
            this.productImgDataGridView.AllowUserToAddRows = false;
            this.productImgDataGridView.AllowUserToDeleteRows = false;
            this.productImgDataGridView.AutoGenerateColumns = false;
            this.productImgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productImgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.imgpathDataGridViewTextBoxColumn,
            this.imgstatusDataGridViewTextBoxColumn,
            this.Image});
            this.productImgDataGridView.DataSource = this.productImgBindingSource;
            this.productImgDataGridView.Location = new System.Drawing.Point(12, 165);
            this.productImgDataGridView.MultiSelect = false;
            this.productImgDataGridView.Name = "productImgDataGridView";
            this.productImgDataGridView.ReadOnly = true;
            this.productImgDataGridView.RowTemplate.Height = 80;
            this.productImgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productImgDataGridView.Size = new System.Drawing.Size(645, 220);
            this.productImgDataGridView.TabIndex = 44;
            // 
            // imgidDataGridViewTextBoxColumn
            // 
            this.imgidDataGridViewTextBoxColumn.DataPropertyName = "img_id";
            this.imgidDataGridViewTextBoxColumn.HeaderText = "Image ID";
            this.imgidDataGridViewTextBoxColumn.Name = "imgidDataGridViewTextBoxColumn";
            this.imgidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imgpathDataGridViewTextBoxColumn
            // 
            this.imgpathDataGridViewTextBoxColumn.DataPropertyName = "img_path";
            this.imgpathDataGridViewTextBoxColumn.HeaderText = "Image Name";
            this.imgpathDataGridViewTextBoxColumn.Name = "imgpathDataGridViewTextBoxColumn";
            this.imgpathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imgstatusDataGridViewTextBoxColumn
            // 
            this.imgstatusDataGridViewTextBoxColumn.DataPropertyName = "img_status";
            this.imgstatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.imgstatusDataGridViewTextBoxColumn.Name = "imgstatusDataGridViewTextBoxColumn";
            this.imgstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 200;
            // 
            // ProductImagesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 431);
            this.Controls.Add(this.productImgDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductImagesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfume Store Manager | Product Images Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductImagesManagement_FormClosed);
            this.Load += new System.EventHandler(this.Product_Images_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_statusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label labelTitle;
        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Perfume_StoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.BindingSource productImgBindingSource;
        private Perfume_StoreDataSetTableAdapters.productImgTableAdapter productImgTableAdapter;
        private System.Windows.Forms.Label product_idLabel;
        private System.Windows.Forms.Label product_nameLabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView productImgDataGridView;
        private System.Windows.Forms.NumericUpDown img_statusNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgpathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}