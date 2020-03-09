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
            System.Windows.Forms.Label product_createdByLabel;
            System.Windows.Forms.Label product_updatedAtLabel;
            System.Windows.Forms.Label product_updateByLabel;
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
            this.product_quantityMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.product_volumneMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.categoryTableAdapter();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.brandTableAdapter();
            this.product_originalPriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.product_currentPriceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.product_statusCombobox = new System.Windows.Forms.ComboBox();
            this.productCreatedBy_ComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.usersTableAdapter();
            this.productUpdatedBy_comboBox = new System.Windows.Forms.ComboBox();
            this.fKproductcategor04E4BC85BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKproductbrandi05D8E0BEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKorderItemprodu0A9D95DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.orderItemTableAdapter();
            this.perfumeStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productvolumneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoriginalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcurrentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcreatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcreatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productupdatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productupdateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            product_createdByLabel = new System.Windows.Forms.Label();
            product_updatedAtLabel = new System.Windows.Forms.Label();
            product_updateByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductcategor04E4BC85BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderItemprodu0A9D95DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfumeStoreDataSetBindingSource)).BeginInit();
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
            // product_createdByLabel
            // 
            product_createdByLabel.AutoSize = true;
            product_createdByLabel.Location = new System.Drawing.Point(586, 428);
            product_createdByLabel.Name = "product_createdByLabel";
            product_createdByLabel.Size = new System.Drawing.Size(82, 17);
            product_createdByLabel.TabIndex = 24;
            product_createdByLabel.Text = "Created By:";
            // 
            // product_updatedAtLabel
            // 
            product_updatedAtLabel.AutoSize = true;
            product_updatedAtLabel.Location = new System.Drawing.Point(586, 457);
            product_updatedAtLabel.Name = "product_updatedAtLabel";
            product_updatedAtLabel.Size = new System.Drawing.Size(83, 17);
            product_updatedAtLabel.TabIndex = 26;
            product_updatedAtLabel.Text = "Updated At:";
            // 
            // product_updateByLabel
            // 
            product_updateByLabel.AutoSize = true;
            product_updateByLabel.Location = new System.Drawing.Point(586, 484);
            product_updateByLabel.Name = "product_updateByLabel";
            product_updateByLabel.Size = new System.Drawing.Size(86, 17);
            product_updateByLabel.TabIndex = 28;
            product_updateByLabel.Text = "Updated By:";
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
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productvolumneDataGridViewTextBoxColumn,
            this.productquantityDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.brandidDataGridViewTextBoxColumn,
            this.productoriginalPriceDataGridViewTextBoxColumn,
            this.productcurrentPriceDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn,
            this.productstatusDataGridViewTextBoxColumn,
            this.productcreatedAtDataGridViewTextBoxColumn,
            this.productcreatedByDataGridViewTextBoxColumn,
            this.productupdatedAtDataGridViewTextBoxColumn,
            this.productupdateByDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(20, 82);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(560, 457);
            this.productDataGridView.TabIndex = 1;
            this.productDataGridView.SelectionChanged += new System.EventHandler(this.productDataGridView_SelectionChanged);
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
            this.product_updatedAtDateTimePicker.Location = new System.Drawing.Point(738, 453);
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
            this.btnDelete.Location = new System.Drawing.Point(900, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(738, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(819, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // product_quantityMaskedTxtBox
            // 
            this.product_quantityMaskedTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleDescription", this.productBindingSource, "product_quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.product_quantityMaskedTxtBox.Location = new System.Drawing.Point(738, 161);
            this.product_quantityMaskedTxtBox.Mask = "00000";
            this.product_quantityMaskedTxtBox.Name = "product_quantityMaskedTxtBox";
            this.product_quantityMaskedTxtBox.Size = new System.Drawing.Size(48, 22);
            this.product_quantityMaskedTxtBox.TabIndex = 35;
            this.product_quantityMaskedTxtBox.ValidatingType = typeof(int);
            // 
            // product_volumneMaskedTxtBox
            // 
            this.product_volumneMaskedTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleDescription", this.productBindingSource, "product_volumne", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.product_volumneMaskedTxtBox.Location = new System.Drawing.Point(738, 133);
            this.product_volumneMaskedTxtBox.Mask = "00000";
            this.product_volumneMaskedTxtBox.Name = "product_volumneMaskedTxtBox";
            this.product_volumneMaskedTxtBox.Size = new System.Drawing.Size(48, 22);
            this.product_volumneMaskedTxtBox.TabIndex = 36;
            this.product_volumneMaskedTxtBox.ValidatingType = typeof(int);
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
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "category_name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(738, 185);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(256, 24);
            this.categoryComboBox.TabIndex = 37;
            this.categoryComboBox.ValueMember = "category_id";
            // 
            // brandComboBox
            // 
            this.brandComboBox.DataSource = this.brandBindingSource;
            this.brandComboBox.DisplayMember = "brand_name";
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(738, 215);
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
            // product_originalPriceMaskedTextBox
            // 
            this.product_originalPriceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleDescription", this.productBindingSource, "product_originalPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.product_originalPriceMaskedTextBox.Location = new System.Drawing.Point(738, 247);
            this.product_originalPriceMaskedTextBox.Mask = "00000";
            this.product_originalPriceMaskedTextBox.Name = "product_originalPriceMaskedTextBox";
            this.product_originalPriceMaskedTextBox.Size = new System.Drawing.Size(48, 22);
            this.product_originalPriceMaskedTextBox.TabIndex = 39;
            this.product_originalPriceMaskedTextBox.ValidatingType = typeof(int);
            // 
            // product_currentPriceMaskedTextBox
            // 
            this.product_currentPriceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleDescription", this.productBindingSource, "product_currentPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.product_currentPriceMaskedTextBox.Location = new System.Drawing.Point(738, 278);
            this.product_currentPriceMaskedTextBox.Mask = "00000";
            this.product_currentPriceMaskedTextBox.Name = "product_currentPriceMaskedTextBox";
            this.product_currentPriceMaskedTextBox.Size = new System.Drawing.Size(48, 22);
            this.product_currentPriceMaskedTextBox.TabIndex = 40;
            this.product_currentPriceMaskedTextBox.ValidatingType = typeof(int);
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
            // productCreatedBy_ComboBox
            // 
            this.productCreatedBy_ComboBox.DataSource = this.usersBindingSource;
            this.productCreatedBy_ComboBox.DisplayMember = "user_fullName";
            this.productCreatedBy_ComboBox.FormattingEnabled = true;
            this.productCreatedBy_ComboBox.Location = new System.Drawing.Point(738, 423);
            this.productCreatedBy_ComboBox.Name = "productCreatedBy_ComboBox";
            this.productCreatedBy_ComboBox.Size = new System.Drawing.Size(256, 24);
            this.productCreatedBy_ComboBox.TabIndex = 42;
            this.productCreatedBy_ComboBox.ValueMember = "user_id";
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
            // productUpdatedBy_comboBox
            // 
            this.productUpdatedBy_comboBox.DataSource = this.usersBindingSource;
            this.productUpdatedBy_comboBox.DisplayMember = "user_fullName";
            this.productUpdatedBy_comboBox.FormattingEnabled = true;
            this.productUpdatedBy_comboBox.Location = new System.Drawing.Point(738, 481);
            this.productUpdatedBy_comboBox.Name = "productUpdatedBy_comboBox";
            this.productUpdatedBy_comboBox.Size = new System.Drawing.Size(256, 24);
            this.productUpdatedBy_comboBox.TabIndex = 43;
            this.productUpdatedBy_comboBox.ValueMember = "user_id";
            // 
            // fKproductcategor04E4BC85BindingSource
            // 
            this.fKproductcategor04E4BC85BindingSource.DataMember = "FK__product__categor__04E4BC85";
            this.fKproductcategor04E4BC85BindingSource.DataSource = this.categoryBindingSource;
            // 
            // fKproductbrandi05D8E0BEBindingSource
            // 
            this.fKproductbrandi05D8E0BEBindingSource.DataMember = "FK__product__brand_i__05D8E0BE";
            this.fKproductbrandi05D8E0BEBindingSource.DataSource = this.brandBindingSource;
            // 
            // fKorderItemprodu0A9D95DBBindingSource
            // 
            this.fKorderItemprodu0A9D95DBBindingSource.DataMember = "FK__orderItem__produ__0A9D95DB";
            this.fKorderItemprodu0A9D95DBBindingSource.DataSource = this.productBindingSource;
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
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 50;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // productvolumneDataGridViewTextBoxColumn
            // 
            this.productvolumneDataGridViewTextBoxColumn.DataPropertyName = "product_volumne";
            this.productvolumneDataGridViewTextBoxColumn.HeaderText = "Volumne";
            this.productvolumneDataGridViewTextBoxColumn.Name = "productvolumneDataGridViewTextBoxColumn";
            this.productvolumneDataGridViewTextBoxColumn.ReadOnly = true;
            this.productvolumneDataGridViewTextBoxColumn.Width = 75;
            // 
            // productquantityDataGridViewTextBoxColumn
            // 
            this.productquantityDataGridViewTextBoxColumn.DataPropertyName = "product_quantity";
            this.productquantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.productquantityDataGridViewTextBoxColumn.Name = "productquantityDataGridViewTextBoxColumn";
            this.productquantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.productquantityDataGridViewTextBoxColumn.Width = 75;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "Category ID";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryidDataGridViewTextBoxColumn.Width = 75;
            // 
            // brandidDataGridViewTextBoxColumn
            // 
            this.brandidDataGridViewTextBoxColumn.DataPropertyName = "brand_id";
            this.brandidDataGridViewTextBoxColumn.HeaderText = "Brand ID";
            this.brandidDataGridViewTextBoxColumn.Name = "brandidDataGridViewTextBoxColumn";
            this.brandidDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandidDataGridViewTextBoxColumn.Width = 50;
            // 
            // productoriginalPriceDataGridViewTextBoxColumn
            // 
            this.productoriginalPriceDataGridViewTextBoxColumn.DataPropertyName = "product_originalPrice";
            this.productoriginalPriceDataGridViewTextBoxColumn.HeaderText = "Original Price";
            this.productoriginalPriceDataGridViewTextBoxColumn.Name = "productoriginalPriceDataGridViewTextBoxColumn";
            this.productoriginalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productcurrentPriceDataGridViewTextBoxColumn
            // 
            this.productcurrentPriceDataGridViewTextBoxColumn.DataPropertyName = "product_currentPrice";
            this.productcurrentPriceDataGridViewTextBoxColumn.HeaderText = "Current Price";
            this.productcurrentPriceDataGridViewTextBoxColumn.Name = "productcurrentPriceDataGridViewTextBoxColumn";
            this.productcurrentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description";
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            this.productdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productstatusDataGridViewTextBoxColumn
            // 
            this.productstatusDataGridViewTextBoxColumn.DataPropertyName = "product_status";
            this.productstatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.productstatusDataGridViewTextBoxColumn.Name = "productstatusDataGridViewTextBoxColumn";
            this.productstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.productstatusDataGridViewTextBoxColumn.Width = 50;
            // 
            // productcreatedAtDataGridViewTextBoxColumn
            // 
            this.productcreatedAtDataGridViewTextBoxColumn.DataPropertyName = "product_createdAt";
            this.productcreatedAtDataGridViewTextBoxColumn.HeaderText = "Created At";
            this.productcreatedAtDataGridViewTextBoxColumn.Name = "productcreatedAtDataGridViewTextBoxColumn";
            this.productcreatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productcreatedByDataGridViewTextBoxColumn
            // 
            this.productcreatedByDataGridViewTextBoxColumn.DataPropertyName = "product_createdBy";
            this.productcreatedByDataGridViewTextBoxColumn.HeaderText = "Created By";
            this.productcreatedByDataGridViewTextBoxColumn.Name = "productcreatedByDataGridViewTextBoxColumn";
            this.productcreatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productupdatedAtDataGridViewTextBoxColumn
            // 
            this.productupdatedAtDataGridViewTextBoxColumn.DataPropertyName = "product_updatedAt";
            this.productupdatedAtDataGridViewTextBoxColumn.HeaderText = "Updated At";
            this.productupdatedAtDataGridViewTextBoxColumn.Name = "productupdatedAtDataGridViewTextBoxColumn";
            this.productupdatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productupdateByDataGridViewTextBoxColumn
            // 
            this.productupdateByDataGridViewTextBoxColumn.DataPropertyName = "product_updateBy";
            this.productupdateByDataGridViewTextBoxColumn.HeaderText = "Updated By";
            this.productupdateByDataGridViewTextBoxColumn.Name = "productupdateByDataGridViewTextBoxColumn";
            this.productupdateByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 553);
            this.Controls.Add(this.productUpdatedBy_comboBox);
            this.Controls.Add(this.productCreatedBy_ComboBox);
            this.Controls.Add(this.product_statusCombobox);
            this.Controls.Add(this.product_currentPriceMaskedTextBox);
            this.Controls.Add(this.product_originalPriceMaskedTextBox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.product_volumneMaskedTxtBox);
            this.Controls.Add(this.product_quantityMaskedTxtBox);
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
            this.Controls.Add(product_createdByLabel);
            this.Controls.Add(product_updatedAtLabel);
            this.Controls.Add(this.product_updatedAtDateTimePicker);
            this.Controls.Add(product_updateByLabel);
            this.Controls.Add(this.productDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfume Store Manager | Product Management";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductcategor04E4BC85BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKproductbrandi05D8E0BEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderItemprodu0A9D95DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfumeStoreDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox product_quantityMaskedTxtBox;
        private System.Windows.Forms.MaskedTextBox product_volumneMaskedTxtBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Perfume_StoreDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Perfume_StoreDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.MaskedTextBox product_originalPriceMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox product_currentPriceMaskedTextBox;
        private System.Windows.Forms.ComboBox product_statusCombobox;
        private System.Windows.Forms.ComboBox productCreatedBy_ComboBox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Perfume_StoreDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox productUpdatedBy_comboBox;
        private System.Windows.Forms.BindingSource fKproductcategor04E4BC85BindingSource;
        private System.Windows.Forms.BindingSource fKproductbrandi05D8E0BEBindingSource;
        private System.Windows.Forms.BindingSource fKorderItemprodu0A9D95DBBindingSource;
        private Perfume_StoreDataSetTableAdapters.orderItemTableAdapter orderItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productvolumneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoriginalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcurrentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcreatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcreatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productupdatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productupdateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource perfumeStoreDataSetBindingSource;
    }
}