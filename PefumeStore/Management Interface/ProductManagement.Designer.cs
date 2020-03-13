namespace PefumeStore.Management_Interface
{
    partial class ProductManagement
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
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label product_volumneLabel;
            System.Windows.Forms.Label product_quantityLabel;
            System.Windows.Forms.Label category_idLabel;
            System.Windows.Forms.Label brand_idLabel;
            System.Windows.Forms.Label product_originalPriceLabel;
            System.Windows.Forms.Label product_currentPriceLabel;
            System.Windows.Forms.Label product_descriptionLabel;
            System.Windows.Forms.Label product_statusLabel;
            System.Windows.Forms.Label product_createdAtLabel;
            System.Windows.Forms.Label product_updatedAtLabel;
            System.Windows.Forms.Label proImgLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.product_updatedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.categoryTableAdapter();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.brandTableAdapter();
            this.product_statusCombobox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.usersTableAdapter();
            this.orderItemTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.orderItemTableAdapter();
            this.perfumeStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proImgBtn = new System.Windows.Forms.Button();
            this.product_quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.product_originalPriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.product_currentPriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.product_volumneNumericUpDown = new System.Windows.Forms.NumericUpDown();
            product_idLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            product_volumneLabel = new System.Windows.Forms.Label();
            product_quantityLabel = new System.Windows.Forms.Label();
            category_idLabel = new System.Windows.Forms.Label();
            brand_idLabel = new System.Windows.Forms.Label();
            product_originalPriceLabel = new System.Windows.Forms.Label();
            product_currentPriceLabel = new System.Windows.Forms.Label();
            product_descriptionLabel = new System.Windows.Forms.Label();
            product_statusLabel = new System.Windows.Forms.Label();
            product_createdAtLabel = new System.Windows.Forms.Label();
            product_updatedAtLabel = new System.Windows.Forms.Label();
            proImgLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfumeStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_volumneNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(586, 82);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(25, 17);
            product_idLabel.TabIndex = 2;
            product_idLabel.Text = "ID:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(586, 110);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(100, 17);
            product_nameLabel.TabIndex = 4;
            product_nameLabel.Text = "Product name:";
            // 
            // product_volumneLabel
            // 
            product_volumneLabel.AutoSize = true;
            product_volumneLabel.Location = new System.Drawing.Point(586, 138);
            product_volumneLabel.Name = "product_volumneLabel";
            product_volumneLabel.Size = new System.Drawing.Size(146, 17);
            product_volumneLabel.TabIndex = 6;
            product_volumneLabel.Text = "Product volumne (ml):";
            // 
            // product_quantityLabel
            // 
            product_quantityLabel.AutoSize = true;
            product_quantityLabel.Location = new System.Drawing.Point(586, 166);
            product_quantityLabel.Name = "product_quantityLabel";
            product_quantityLabel.Size = new System.Drawing.Size(115, 17);
            product_quantityLabel.TabIndex = 8;
            product_quantityLabel.Text = "Product quantity:";
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(586, 194);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(69, 17);
            category_idLabel.TabIndex = 10;
            category_idLabel.Text = "Category:";
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Location = new System.Drawing.Point(586, 222);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(50, 17);
            brand_idLabel.TabIndex = 12;
            brand_idLabel.Text = "Brand:";
            // 
            // product_originalPriceLabel
            // 
            product_originalPriceLabel.AutoSize = true;
            product_originalPriceLabel.Location = new System.Drawing.Point(586, 250);
            product_originalPriceLabel.Name = "product_originalPriceLabel";
            product_originalPriceLabel.Size = new System.Drawing.Size(97, 17);
            product_originalPriceLabel.TabIndex = 14;
            product_originalPriceLabel.Text = "Original Price:";
            // 
            // product_currentPriceLabel
            // 
            product_currentPriceLabel.AutoSize = true;
            product_currentPriceLabel.Location = new System.Drawing.Point(586, 278);
            product_currentPriceLabel.Name = "product_currentPriceLabel";
            product_currentPriceLabel.Size = new System.Drawing.Size(95, 17);
            product_currentPriceLabel.TabIndex = 16;
            product_currentPriceLabel.Text = "Current Price:";
            // 
            // product_descriptionLabel
            // 
            product_descriptionLabel.AutoSize = true;
            product_descriptionLabel.Location = new System.Drawing.Point(586, 306);
            product_descriptionLabel.Name = "product_descriptionLabel";
            product_descriptionLabel.Size = new System.Drawing.Size(83, 17);
            product_descriptionLabel.TabIndex = 18;
            product_descriptionLabel.Text = "Description:";
            // 
            // product_statusLabel
            // 
            product_statusLabel.AutoSize = true;
            product_statusLabel.Location = new System.Drawing.Point(586, 372);
            product_statusLabel.Name = "product_statusLabel";
            product_statusLabel.Size = new System.Drawing.Size(103, 17);
            product_statusLabel.TabIndex = 20;
            product_statusLabel.Text = "Product status:";
            // 
            // product_createdAtLabel
            // 
            product_createdAtLabel.AutoSize = true;
            product_createdAtLabel.Location = new System.Drawing.Point(586, 401);
            product_createdAtLabel.Name = "product_createdAtLabel";
            product_createdAtLabel.Size = new System.Drawing.Size(79, 17);
            product_createdAtLabel.TabIndex = 22;
            product_createdAtLabel.Text = "Created At:";
            // 
            // product_updatedAtLabel
            // 
            product_updatedAtLabel.AutoSize = true;
            product_updatedAtLabel.Location = new System.Drawing.Point(586, 434);
            product_updatedAtLabel.Name = "product_updatedAtLabel";
            product_updatedAtLabel.Size = new System.Drawing.Size(83, 17);
            product_updatedAtLabel.TabIndex = 26;
            product_updatedAtLabel.Text = "Updated At:";
            // 
            // proImgLbl
            // 
            proImgLbl.AutoSize = true;
            proImgLbl.Location = new System.Drawing.Point(586, 474);
            proImgLbl.Name = "proImgLbl";
            proImgLbl.Size = new System.Drawing.Size(110, 17);
            proImgLbl.TabIndex = 45;
            proImgLbl.Text = "Product Images:";
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
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(20, 82);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(560, 499);
            this.productDataGridView.TabIndex = 1;
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_id", true));
            this.product_idTextBox.Enabled = false;
            this.product_idTextBox.Location = new System.Drawing.Point(738, 79);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(75, 22);
            this.product_idTextBox.TabIndex = 3;
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(738, 107);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(256, 22);
            this.product_nameTextBox.TabIndex = 5;
            // 
            // product_descriptionTextBox
            // 
            this.product_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_description", true));
            this.product_descriptionTextBox.Location = new System.Drawing.Point(738, 303);
            this.product_descriptionTextBox.Multiline = true;
            this.product_descriptionTextBox.Name = "product_descriptionTextBox";
            this.product_descriptionTextBox.Size = new System.Drawing.Size(256, 60);
            this.product_descriptionTextBox.TabIndex = 19;
            // 
            // product_createdAtDateTimePicker
            // 
            this.product_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_createdAt", true));
            this.product_createdAtDateTimePicker.Location = new System.Drawing.Point(738, 397);
            this.product_createdAtDateTimePicker.Name = "product_createdAtDateTimePicker";
            this.product_createdAtDateTimePicker.Size = new System.Drawing.Size(256, 22);
            this.product_createdAtDateTimePicker.TabIndex = 23;
            // 
            // product_updatedAtDateTimePicker
            // 
            this.product_updatedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_updatedAt", true));
            this.product_updatedAtDateTimePicker.Location = new System.Drawing.Point(738, 430);
            this.product_updatedAtDateTimePicker.Name = "product_updatedAtDateTimePicker";
            this.product_updatedAtDateTimePicker.Size = new System.Drawing.Size(256, 22);
            this.product_updatedAtDateTimePicker.TabIndex = 27;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product Management";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(900, 503);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(738, 503);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(819, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.productBindingSource;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(738, 191);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(256, 24);
            this.categoryComboBox.TabIndex = 37;
            this.categoryComboBox.ValueMember = "category_id";
            // 
            // brandComboBox
            // 
            this.brandComboBox.DataSource = this.productBindingSource;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(738, 221);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(256, 24);
            this.brandComboBox.TabIndex = 38;
            this.brandComboBox.ValueMember = "brand_id";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // product_statusCombobox
            // 
            this.product_statusCombobox.DataSource = this.productBindingSource;
            this.product_statusCombobox.DisplayMember = "product_status";
            this.product_statusCombobox.FormattingEnabled = true;
            this.product_statusCombobox.Location = new System.Drawing.Point(738, 367);
            this.product_statusCombobox.Name = "product_statusCombobox";
            this.product_statusCombobox.Size = new System.Drawing.Size(75, 24);
            this.product_statusCombobox.TabIndex = 41;
            this.product_statusCombobox.ValueMember = "product_status";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // orderItemTableAdapter
            // 
            this.orderItemTableAdapter.ClearBeforeFill = true;
            // 
            // perfumeStoreDataSetBindingSource
            // 
            this.perfumeStoreDataSetBindingSource.DataSource = this.perfume_StoreDataSet;
            this.perfumeStoreDataSetBindingSource.Position = 0;
            // 
            // proImgBtn
            // 
            this.proImgBtn.Location = new System.Drawing.Point(738, 467);
            this.proImgBtn.Name = "proImgBtn";
            this.proImgBtn.Size = new System.Drawing.Size(75, 30);
            this.proImgBtn.TabIndex = 44;
            this.proImgBtn.Text = "Manage";
            this.proImgBtn.UseVisualStyleBackColor = true;
            this.proImgBtn.Click += new System.EventHandler(this.proImgBtn_Click);
            // 
            // product_quantityNumericUpDown
            // 
            this.product_quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_quantity", true));
            this.product_quantityNumericUpDown.Location = new System.Drawing.Point(738, 164);
            this.product_quantityNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.product_quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.product_quantityNumericUpDown.Name = "product_quantityNumericUpDown";
            this.product_quantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.product_quantityNumericUpDown.TabIndex = 47;
            this.product_quantityNumericUpDown.ThousandsSeparator = true;
            this.product_quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // product_originalPriceMaskedTextBox
            // 
            this.product_originalPriceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_originalPrice", true));
            this.product_originalPriceMaskedTextBox.Location = new System.Drawing.Point(738, 247);
            this.product_originalPriceMaskedTextBox.Name = "product_originalPriceMaskedTextBox";
            this.product_originalPriceMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.product_originalPriceMaskedTextBox.TabIndex = 48;
            // 
            // product_currentPriceMaskedTextBox
            // 
            this.product_currentPriceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_currentPrice", true));
            this.product_currentPriceMaskedTextBox.Location = new System.Drawing.Point(738, 273);
            this.product_currentPriceMaskedTextBox.Name = "product_currentPriceMaskedTextBox";
            this.product_currentPriceMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.product_currentPriceMaskedTextBox.TabIndex = 49;
            // 
            // product_volumneNumericUpDown
            // 
            this.product_volumneNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_volumne", true));
            this.product_volumneNumericUpDown.Location = new System.Drawing.Point(738, 133);
            this.product_volumneNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.product_volumneNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.product_volumneNumericUpDown.Name = "product_volumneNumericUpDown";
            this.product_volumneNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.product_volumneNumericUpDown.TabIndex = 50;
            this.product_volumneNumericUpDown.ThousandsSeparator = true;
            this.product_volumneNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 601);
            this.Controls.Add(this.product_volumneNumericUpDown);
            this.Controls.Add(this.product_currentPriceMaskedTextBox);
            this.Controls.Add(this.product_originalPriceMaskedTextBox);
            this.Controls.Add(this.product_quantityNumericUpDown);
            this.Controls.Add(proImgLbl);
            this.Controls.Add(this.proImgBtn);
            this.Controls.Add(this.product_statusCombobox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(product_idLabel);
            this.Controls.Add(this.product_idTextBox);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(product_volumneLabel);
            this.Controls.Add(product_quantityLabel);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(brand_idLabel);
            this.Controls.Add(product_originalPriceLabel);
            this.Controls.Add(product_currentPriceLabel);
            this.Controls.Add(product_descriptionLabel);
            this.Controls.Add(this.product_descriptionTextBox);
            this.Controls.Add(product_statusLabel);
            this.Controls.Add(product_createdAtLabel);
            this.Controls.Add(this.product_createdAtDateTimePicker);
            this.Controls.Add(product_updatedAtLabel);
            this.Controls.Add(this.product_updatedAtDateTimePicker);
            this.Controls.Add(this.productDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfume Store Manager | Product Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductManagement_FormClosed);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfumeStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_volumneNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Perfume_StoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox product_descriptionTextBox;
        private System.Windows.Forms.DateTimePicker product_createdAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker product_updatedAtDateTimePicker;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Perfume_StoreDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Perfume_StoreDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.ComboBox product_statusCombobox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Perfume_StoreDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private Perfume_StoreDataSetTableAdapters.orderItemTableAdapter orderItemTableAdapter;
        private System.Windows.Forms.BindingSource perfumeStoreDataSetBindingSource;
        private System.Windows.Forms.Button proImgBtn;
        private System.Windows.Forms.NumericUpDown product_quantityNumericUpDown;
        private System.Windows.Forms.MaskedTextBox product_originalPriceMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox product_currentPriceMaskedTextBox;
        private System.Windows.Forms.NumericUpDown product_volumneNumericUpDown;
    }
}