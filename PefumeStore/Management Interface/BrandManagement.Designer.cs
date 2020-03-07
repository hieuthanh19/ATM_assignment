namespace PefumeStore.Management_Interface
{
    partial class BrandManagement
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
            System.Windows.Forms.Label brand_idLabel;
            System.Windows.Forms.Label brand_nameLabel;
            System.Windows.Forms.Label country_idLabel;
            System.Windows.Forms.Label brand_createdAtLabel;
            System.Windows.Forms.Label brand_statusLabel;
            this.brandDataGridView = new System.Windows.Forms.DataGridView();
            this.brand_idTextBox = new System.Windows.Forms.TextBox();
            this.brand_nameTextBox = new System.Windows.Forms.TextBox();
            this.country_idTextBox = new System.Windows.Forms.TextBox();
            this.brand_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fKbrandcountryi0F624AF8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fKbrandcountryi0F624AF8BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.countrynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrystatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycreatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.brandTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.countriesTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.countriesTableAdapter();
            this.productTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.productTableAdapter();
            brand_idLabel = new System.Windows.Forms.Label();
            brand_nameLabel = new System.Windows.Forms.Label();
            country_idLabel = new System.Windows.Forms.Label();
            brand_createdAtLabel = new System.Windows.Forms.Label();
            brand_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbrandcountryi0F624AF8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbrandcountryi0F624AF8BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Location = new System.Drawing.Point(627, 94);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(64, 17);
            brand_idLabel.TabIndex = 2;
            brand_idLabel.Text = "brand id:";
            // 
            // brand_nameLabel
            // 
            brand_nameLabel.AutoSize = true;
            brand_nameLabel.Location = new System.Drawing.Point(627, 122);
            brand_nameLabel.Name = "brand_nameLabel";
            brand_nameLabel.Size = new System.Drawing.Size(88, 17);
            brand_nameLabel.TabIndex = 4;
            brand_nameLabel.Text = "brand name:";
            // 
            // country_idLabel
            // 
            country_idLabel.AutoSize = true;
            country_idLabel.Location = new System.Drawing.Point(627, 150);
            country_idLabel.Name = "country_idLabel";
            country_idLabel.Size = new System.Drawing.Size(74, 17);
            country_idLabel.TabIndex = 6;
            country_idLabel.Text = "country id:";
            // 
            // brand_createdAtLabel
            // 
            brand_createdAtLabel.AutoSize = true;
            brand_createdAtLabel.Location = new System.Drawing.Point(627, 179);
            brand_createdAtLabel.Name = "brand_createdAtLabel";
            brand_createdAtLabel.Size = new System.Drawing.Size(118, 17);
            brand_createdAtLabel.TabIndex = 8;
            brand_createdAtLabel.Text = "brand created At:";
            // 
            // brand_statusLabel
            // 
            brand_statusLabel.AutoSize = true;
            brand_statusLabel.Location = new System.Drawing.Point(627, 206);
            brand_statusLabel.Name = "brand_statusLabel";
            brand_statusLabel.Size = new System.Drawing.Size(91, 17);
            brand_statusLabel.TabIndex = 10;
            brand_statusLabel.Text = "brand status:";
            // 
            // brandDataGridView
            // 
            this.brandDataGridView.AllowUserToAddRows = false;
            this.brandDataGridView.AllowUserToDeleteRows = false;
            this.brandDataGridView.AutoGenerateColumns = false;
            this.brandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand_name,
            this.countrynameDataGridViewTextBoxColumn,
            this.country_id,
            this.brand_createdAt,
            this.brand_status,
            this.countryidDataGridViewTextBoxColumn,
            this.countrystatusDataGridViewTextBoxColumn,
            this.countrycreatedAtDataGridViewTextBoxColumn});
            this.brandDataGridView.DataSource = this.countriesBindingSource;
            this.brandDataGridView.Location = new System.Drawing.Point(12, 94);
            this.brandDataGridView.Name = "brandDataGridView";
            this.brandDataGridView.ReadOnly = true;
            this.brandDataGridView.RowTemplate.Height = 24;
            this.brandDataGridView.Size = new System.Drawing.Size(594, 220);
            this.brandDataGridView.TabIndex = 1;
            // 
            // brand_idTextBox
            // 
            this.brand_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_id", true));
            this.brand_idTextBox.Enabled = false;
            this.brand_idTextBox.Location = new System.Drawing.Point(751, 91);
            this.brand_idTextBox.Name = "brand_idTextBox";
            this.brand_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.brand_idTextBox.TabIndex = 3;
            // 
            // brand_nameTextBox
            // 
            this.brand_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_name", true));
            this.brand_nameTextBox.Location = new System.Drawing.Point(751, 119);
            this.brand_nameTextBox.Name = "brand_nameTextBox";
            this.brand_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.brand_nameTextBox.TabIndex = 5;
            // 
            // country_idTextBox
            // 
            this.country_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "country_id", true));
            this.country_idTextBox.Location = new System.Drawing.Point(751, 147);
            this.country_idTextBox.Name = "country_idTextBox";
            this.country_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.country_idTextBox.TabIndex = 7;
            // 
            // brand_createdAtDateTimePicker
            // 
            this.brand_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.brandBindingSource, "brand_createdAt", true));
            this.brand_createdAtDateTimePicker.Location = new System.Drawing.Point(751, 175);
            this.brand_createdAtDateTimePicker.Name = "brand_createdAtDateTimePicker";
            this.brand_createdAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.brand_createdAtDateTimePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Brand Management";
            // 
            // fKbrandcountryi0F624AF8BindingSource
            // 
            this.fKbrandcountryi0F624AF8BindingSource.DataMember = "FK__brand__country_i__0F624AF8";
            this.fKbrandcountryi0F624AF8BindingSource.DataSource = this.countriesBindingSource;
            // 
            // fKproductbrandi05D8E0BEBindingSource
            // 
            this.fKproductbrandi05D8E0BEBindingSource.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource.DataSource = this.fKbrandcountryi0F624AF8BindingSource;
            // 
            // fKproductbrandi05D8E0BEBindingSource1
            // 
            this.fKproductbrandi05D8E0BEBindingSource1.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource1.DataSource = this.fKbrandcountryi0F624AF8BindingSource;
            // 
            // fKproductbrandi05D8E0BEBindingSource2
            // 
            this.fKproductbrandi05D8E0BEBindingSource2.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource2.DataSource = this.brandBindingSource;
            // 
            // fKproductbrandi05D8E0BEBindingSource3
            // 
            this.fKproductbrandi05D8E0BEBindingSource3.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource3.DataSource = this.brandBindingSource;
            // 
            // fKproductbrandi05D8E0BEBindingSource4
            // 
            this.fKproductbrandi05D8E0BEBindingSource4.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource4.DataSource = this.fKbrandcountryi0F624AF8BindingSource;
            // 
            // fKbrandcountryi0F624AF8BindingSource1
            // 
            this.fKbrandcountryi0F624AF8BindingSource1.DataMember = "FK__brand__country_i__0F624AF8";
            this.fKbrandcountryi0F624AF8BindingSource1.DataSource = this.countriesBindingSource;
            // 
            // fKproductbrandi05D8E0BEBindingSource5
            // 
            this.fKproductbrandi05D8E0BEBindingSource5.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource5.DataSource = this.fKbrandcountryi0F624AF8BindingSource1;
            // 
            // fKproductbrandi05D8E0BEBindingSource6
            // 
            this.fKproductbrandi05D8E0BEBindingSource6.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource6.DataSource = this.fKbrandcountryi0F624AF8BindingSource;
            // 
            // brand_name
            // 
            this.brand_name.DataPropertyName = "brand_name";
            this.brand_name.HeaderText = "Name";
            this.brand_name.Name = "brand_name";
            this.brand_name.ReadOnly = true;
            this.brand_name.Width = 200;
            // 
            // country_id
            // 
            this.country_id.DataPropertyName = "country_id";
            this.country_id.HeaderText = "country_id";
            this.country_id.Name = "country_id";
            this.country_id.ReadOnly = true;
            this.country_id.Visible = false;
            // 
            // brand_createdAt
            // 
            this.brand_createdAt.DataPropertyName = "brand_createdAt";
            this.brand_createdAt.HeaderText = "Created At";
            this.brand_createdAt.Name = "brand_createdAt";
            this.brand_createdAt.ReadOnly = true;
            this.brand_createdAt.Width = 150;
            // 
            // brand_status
            // 
            this.brand_status.DataPropertyName = "brand_status";
            this.brand_status.HeaderText = "Status";
            this.brand_status.Name = "brand_status";
            this.brand_status.ReadOnly = true;
            this.brand_status.Width = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Locked"});
            this.comboBox1.Location = new System.Drawing.Point(751, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(913, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(751, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(832, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countrynameDataGridViewTextBoxColumn
            // 
            this.countrynameDataGridViewTextBoxColumn.DataPropertyName = "country_name";
            this.countrynameDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countrynameDataGridViewTextBoxColumn.Name = "countrynameDataGridViewTextBoxColumn";
            this.countrynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.countrynameDataGridViewTextBoxColumn.Width = 150;
            // 
            // countryidDataGridViewTextBoxColumn
            // 
            this.countryidDataGridViewTextBoxColumn.DataPropertyName = "country_id";
            this.countryidDataGridViewTextBoxColumn.HeaderText = "country_id";
            this.countryidDataGridViewTextBoxColumn.Name = "countryidDataGridViewTextBoxColumn";
            this.countryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryidDataGridViewTextBoxColumn.Visible = false;
            // 
            // countrystatusDataGridViewTextBoxColumn
            // 
            this.countrystatusDataGridViewTextBoxColumn.DataPropertyName = "country_status";
            this.countrystatusDataGridViewTextBoxColumn.HeaderText = "country_status";
            this.countrystatusDataGridViewTextBoxColumn.Name = "countrystatusDataGridViewTextBoxColumn";
            this.countrystatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.countrystatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // countrycreatedAtDataGridViewTextBoxColumn
            // 
            this.countrycreatedAtDataGridViewTextBoxColumn.DataPropertyName = "country_createdAt";
            this.countrycreatedAtDataGridViewTextBoxColumn.HeaderText = "country_createdAt";
            this.countrycreatedAtDataGridViewTextBoxColumn.Name = "countrycreatedAtDataGridViewTextBoxColumn";
            this.countrycreatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.countrycreatedAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "countries";
            this.countriesBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brandTableAdapter = this.brandTableAdapter;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.countriesTableAdapter = null;
            this.tableAdapterManager.deliveryMethodTableAdapter = null;
            this.tableAdapterManager.favListTableAdapter = null;
            this.tableAdapterManager.orderItemTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.paymentMethodTableAdapter = null;
            this.tableAdapterManager.productImgTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // BrandManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(brand_idLabel);
            this.Controls.Add(this.brand_idTextBox);
            this.Controls.Add(brand_nameLabel);
            this.Controls.Add(this.brand_nameTextBox);
            this.Controls.Add(country_idLabel);
            this.Controls.Add(this.country_idTextBox);
            this.Controls.Add(brand_createdAtLabel);
            this.Controls.Add(this.brand_createdAtDateTimePicker);
            this.Controls.Add(brand_statusLabel);
            this.Controls.Add(this.brandDataGridView);
            this.Name = "BrandManagement";
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.BrandManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbrandcountryi0F624AF8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbrandcountryi0F624AF8BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Perfume_StoreDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView brandDataGridView;
        private System.Windows.Forms.TextBox brand_idTextBox;
        private System.Windows.Forms.TextBox brand_nameTextBox;
        private System.Windows.Forms.TextBox country_idTextBox;
        private System.Windows.Forms.DateTimePicker brand_createdAtDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Perfume_StoreDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource fKbrandcountryi0F624AF8BindingSource;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource;
        private Perfume_StoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource1;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn country_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrystatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycreatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource3;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource4;
        private System.Windows.Forms.BindingSource fKbrandcountryi0F624AF8BindingSource1;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource5;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
    }
}