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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.productImgDataGridView = new System.Windows.Forms.DataGridView();
            this.product_idLabel = new System.Windows.Forms.Label();
            this.product_nameLabel = new System.Windows.Forms.Label();
            this.imgidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgpathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 2;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.SeaGreen;
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
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelTitle.Location = new System.Drawing.Point(146, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(418, 32);
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
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(380, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 34);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChangeStatus.FlatAppearance.BorderSize = 0;
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeStatus.Location = new System.Drawing.Point(497, 115);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(154, 34);
            this.btnChangeStatus.TabIndex = 36;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(657, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 34);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // productImgDataGridView
            // 
            this.productImgDataGridView.AllowUserToAddRows = false;
            this.productImgDataGridView.AllowUserToDeleteRows = false;
            this.productImgDataGridView.AutoGenerateColumns = false;
            this.productImgDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.productImgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productImgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.imgpathDataGridViewTextBoxColumn,
            this.imgstatusDataGridViewTextBoxColumn,
            this.Image});
            this.productImgDataGridView.DataSource = this.productImgBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productImgDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productImgDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.productImgDataGridView.Location = new System.Drawing.Point(12, 155);
            this.productImgDataGridView.MultiSelect = false;
            this.productImgDataGridView.Name = "productImgDataGridView";
            this.productImgDataGridView.ReadOnly = true;
            this.productImgDataGridView.RowTemplate.Height = 80;
            this.productImgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productImgDataGridView.Size = new System.Drawing.Size(756, 324);
            this.productImgDataGridView.TabIndex = 44;
            // 
            // product_idLabel
            // 
            this.product_idLabel.AutoSize = true;
            this.product_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_idLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.product_idLabel.Location = new System.Drawing.Point(12, 54);
            this.product_idLabel.Name = "product_idLabel";
            this.product_idLabel.Size = new System.Drawing.Size(42, 25);
            this.product_idLabel.TabIndex = 45;
            this.product_idLabel.Text = "ID: ";
            // 
            // product_nameLabel
            // 
            this.product_nameLabel.AutoSize = true;
            this.product_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_nameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.product_nameLabel.Location = new System.Drawing.Point(12, 81);
            this.product_nameLabel.Name = "product_nameLabel";
            this.product_nameLabel.Size = new System.Drawing.Size(75, 25);
            this.product_nameLabel.TabIndex = 46;
            this.product_nameLabel.Text = "Name: ";
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
            this.imgpathDataGridViewTextBoxColumn.Width = 150;
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
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 250;
            // 
            // ProductImagesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 491);
            this.Controls.Add(this.product_idLabel);
            this.Controls.Add(this.product_nameLabel);
            this.Controls.Add(this.productImgDataGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.labelTitle);
            this.Name = "ProductImagesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Images Management | Perfume Store Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductImagesManagement_FormClosed);
            this.Load += new System.EventHandler(this.Product_Images_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView productImgDataGridView;
        private System.Windows.Forms.Label product_idLabel;
        private System.Windows.Forms.Label product_nameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgpathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}