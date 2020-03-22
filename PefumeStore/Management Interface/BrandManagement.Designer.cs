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
            System.Windows.Forms.Label brand_createdAtLabel;
            System.Windows.Forms.Label brand_statusLabel;
            System.Windows.Forms.Label country_nameLabel;
            System.Windows.Forms.Label createBrand_nameLabel;
            System.Windows.Forms.Label craeteBrand_statusLabel;
            System.Windows.Forms.Label createCountry_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandManagement));
            this.brandDataGridView = new System.Windows.Forms.DataGridView();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brand_idTextBox = new System.Windows.Forms.TextBox();
            this.brand_nameTextBox = new System.Windows.Forms.TextBox();
            this.brand_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.brandTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.brandTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.countriesTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.countriesTableAdapter();
            this.country_nameComboBox = new System.Windows.Forms.ComboBox();
            this.brand_statusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.createPnl = new System.Windows.Forms.Panel();
            this.returnToListBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createBrand_nameTextBox = new System.Windows.Forms.TextBox();
            this.createCountry_idComboBox = new System.Windows.Forms.ComboBox();
            this.createClearBtn = new System.Windows.Forms.Button();
            this.createCreateBtn = new System.Windows.Forms.Button();
            this.createStatusComboBox = new System.Windows.Forms.ComboBox();
            brand_idLabel = new System.Windows.Forms.Label();
            brand_nameLabel = new System.Windows.Forms.Label();
            brand_createdAtLabel = new System.Windows.Forms.Label();
            brand_statusLabel = new System.Windows.Forms.Label();
            country_nameLabel = new System.Windows.Forms.Label();
            createBrand_nameLabel = new System.Windows.Forms.Label();
            craeteBrand_statusLabel = new System.Windows.Forms.Label();
            createCountry_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_statusNumericUpDown)).BeginInit();
            this.createPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Location = new System.Drawing.Point(611, 94);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(64, 17);
            brand_idLabel.TabIndex = 2;
            brand_idLabel.Text = "brand id:";
            // 
            // brand_nameLabel
            // 
            brand_nameLabel.AutoSize = true;
            brand_nameLabel.Location = new System.Drawing.Point(611, 122);
            brand_nameLabel.Name = "brand_nameLabel";
            brand_nameLabel.Size = new System.Drawing.Size(88, 17);
            brand_nameLabel.TabIndex = 4;
            brand_nameLabel.Text = "brand name:";
            // 
            // brand_createdAtLabel
            // 
            brand_createdAtLabel.AutoSize = true;
            brand_createdAtLabel.Location = new System.Drawing.Point(611, 179);
            brand_createdAtLabel.Name = "brand_createdAtLabel";
            brand_createdAtLabel.Size = new System.Drawing.Size(118, 17);
            brand_createdAtLabel.TabIndex = 8;
            brand_createdAtLabel.Text = "brand created At:";
            // 
            // brand_statusLabel
            // 
            brand_statusLabel.AutoSize = true;
            brand_statusLabel.Location = new System.Drawing.Point(611, 206);
            brand_statusLabel.Name = "brand_statusLabel";
            brand_statusLabel.Size = new System.Drawing.Size(91, 17);
            brand_statusLabel.TabIndex = 10;
            brand_statusLabel.Text = "brand status:";
            // 
            // country_nameLabel
            // 
            country_nameLabel.AutoSize = true;
            country_nameLabel.Location = new System.Drawing.Point(611, 149);
            country_nameLabel.Name = "country_nameLabel";
            country_nameLabel.Size = new System.Drawing.Size(59, 17);
            country_nameLabel.TabIndex = 21;
            country_nameLabel.Text = "country:";
            // 
            // brandDataGridView
            // 
            this.brandDataGridView.AllowUserToAddRows = false;
            this.brandDataGridView.AllowUserToDeleteRows = false;
            this.brandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.brandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandDataGridView.Location = new System.Drawing.Point(12, 94);
            this.brandDataGridView.MultiSelect = false;
            this.brandDataGridView.Name = "brandDataGridView";
            this.brandDataGridView.ReadOnly = true;
            this.brandDataGridView.RowTemplate.Height = 24;
            this.brandDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandDataGridView.Size = new System.Drawing.Size(593, 220);
            this.brandDataGridView.TabIndex = 1;
            this.brandDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.brandDataGridView_CellMouseClick);
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
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "countries";
            this.countriesBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // brand_idTextBox
            // 
            this.brand_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_id", true));
            this.brand_idTextBox.Enabled = false;
            this.brand_idTextBox.Location = new System.Drawing.Point(735, 91);
            this.brand_idTextBox.Name = "brand_idTextBox";
            this.brand_idTextBox.Size = new System.Drawing.Size(75, 22);
            this.brand_idTextBox.TabIndex = 3;
            // 
            // brand_nameTextBox
            // 
            this.brand_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_name", true));
            this.brand_nameTextBox.Location = new System.Drawing.Point(735, 119);
            this.brand_nameTextBox.Name = "brand_nameTextBox";
            this.brand_nameTextBox.Size = new System.Drawing.Size(244, 22);
            this.brand_nameTextBox.TabIndex = 5;
            // 
            // brand_createdAtDateTimePicker
            // 
            this.brand_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.brandBindingSource, "brand_createdAt", true));
            this.brand_createdAtDateTimePicker.Location = new System.Drawing.Point(735, 175);
            this.brand_createdAtDateTimePicker.Name = "brand_createdAtDateTimePicker";
            this.brand_createdAtDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.brand_createdAtDateTimePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Brand Management";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(897, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(735, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(816, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // country_nameComboBox
            // 
            this.country_nameComboBox.DataSource = this.countriesBindingSource;
            this.country_nameComboBox.DisplayMember = "country_name";
            this.country_nameComboBox.FormattingEnabled = true;
            this.country_nameComboBox.Location = new System.Drawing.Point(735, 144);
            this.country_nameComboBox.Name = "country_nameComboBox";
            this.country_nameComboBox.Size = new System.Drawing.Size(244, 24);
            this.country_nameComboBox.TabIndex = 22;
            this.country_nameComboBox.ValueMember = "country_id";
            // 
            // brand_statusNumericUpDown
            // 
            this.brand_statusNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.brandBindingSource, "brand_status", true));
            this.brand_statusNumericUpDown.Location = new System.Drawing.Point(735, 206);
            this.brand_statusNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brand_statusNumericUpDown.Name = "brand_statusNumericUpDown";
            this.brand_statusNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.brand_statusNumericUpDown.TabIndex = 23;
            // 
            // createPnl
            // 
            this.createPnl.Controls.Add(this.createStatusComboBox);
            this.createPnl.Controls.Add(this.createClearBtn);
            this.createPnl.Controls.Add(this.createCreateBtn);
            this.createPnl.Controls.Add(this.createCountry_idComboBox);
            this.createPnl.Controls.Add(createCountry_idLabel);
            this.createPnl.Controls.Add(createBrand_nameLabel);
            this.createPnl.Controls.Add(this.createBrand_nameTextBox);
            this.createPnl.Controls.Add(craeteBrand_statusLabel);
            this.createPnl.Controls.Add(this.returnToListBtn);
            this.createPnl.Controls.Add(this.label2);
            this.createPnl.Location = new System.Drawing.Point(7, 9);
            this.createPnl.Name = "createPnl";
            this.createPnl.Size = new System.Drawing.Size(987, 324);
            this.createPnl.TabIndex = 24;
            // 
            // returnToListBtn
            // 
            this.returnToListBtn.Location = new System.Drawing.Point(5, 4);
            this.returnToListBtn.Name = "returnToListBtn";
            this.returnToListBtn.Size = new System.Drawing.Size(110, 35);
            this.returnToListBtn.TabIndex = 3;
            this.returnToListBtn.Text = "Return to List";
            this.returnToListBtn.UseVisualStyleBackColor = true;
            this.returnToListBtn.Click += new System.EventHandler(this.returnToListBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create";
            // 
            // createBrand_nameLabel
            // 
            createBrand_nameLabel.AutoSize = true;
            createBrand_nameLabel.Location = new System.Drawing.Point(260, 65);
            createBrand_nameLabel.Name = "createBrand_nameLabel";
            createBrand_nameLabel.Size = new System.Drawing.Size(89, 17);
            createBrand_nameLabel.TabIndex = 5;
            createBrand_nameLabel.Text = "Brand name:";
            // 
            // createBrand_nameTextBox
            // 
            this.createBrand_nameTextBox.Location = new System.Drawing.Point(384, 62);
            this.createBrand_nameTextBox.Name = "createBrand_nameTextBox";
            this.createBrand_nameTextBox.Size = new System.Drawing.Size(225, 22);
            this.createBrand_nameTextBox.TabIndex = 6;
            // 
            // craeteBrand_statusLabel
            // 
            craeteBrand_statusLabel.AutoSize = true;
            craeteBrand_statusLabel.Location = new System.Drawing.Point(260, 140);
            craeteBrand_statusLabel.Name = "craeteBrand_statusLabel";
            craeteBrand_statusLabel.Size = new System.Drawing.Size(92, 17);
            craeteBrand_statusLabel.TabIndex = 11;
            craeteBrand_statusLabel.Text = "Brand status:";
            // 
            // createCountry_idLabel
            // 
            createCountry_idLabel.AutoSize = true;
            createCountry_idLabel.Location = new System.Drawing.Point(260, 102);
            createCountry_idLabel.Name = "createCountry_idLabel";
            createCountry_idLabel.Size = new System.Drawing.Size(100, 17);
            createCountry_idLabel.TabIndex = 12;
            createCountry_idLabel.Text = "Country name:";
            // 
            // createCountry_idComboBox
            // 
            this.createCountry_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_id", true));
            this.createCountry_idComboBox.DataSource = this.countriesBindingSource;
            this.createCountry_idComboBox.DisplayMember = "country_name";
            this.createCountry_idComboBox.FormattingEnabled = true;
            this.createCountry_idComboBox.Location = new System.Drawing.Point(384, 95);
            this.createCountry_idComboBox.Name = "createCountry_idComboBox";
            this.createCountry_idComboBox.Size = new System.Drawing.Size(121, 24);
            this.createCountry_idComboBox.TabIndex = 13;
            this.createCountry_idComboBox.ValueMember = "country_id";
            // 
            // createClearBtn
            // 
            this.createClearBtn.Location = new System.Drawing.Point(506, 197);
            this.createClearBtn.Name = "createClearBtn";
            this.createClearBtn.Size = new System.Drawing.Size(110, 35);
            this.createClearBtn.TabIndex = 15;
            this.createClearBtn.Text = "Clear";
            this.createClearBtn.UseVisualStyleBackColor = true;
            this.createClearBtn.Click += new System.EventHandler(this.createClearBtn_Click);
            // 
            // createCreateBtn
            // 
            this.createCreateBtn.Location = new System.Drawing.Point(384, 197);
            this.createCreateBtn.Name = "createCreateBtn";
            this.createCreateBtn.Size = new System.Drawing.Size(110, 35);
            this.createCreateBtn.TabIndex = 14;
            this.createCreateBtn.Text = "Create";
            this.createCreateBtn.UseVisualStyleBackColor = true;
            this.createCreateBtn.Click += new System.EventHandler(this.createCreateBtn_Click);
            // 
            // createStatusComboBox
            // 
            this.createStatusComboBox.FormattingEnabled = true;
            this.createStatusComboBox.Items.AddRange(new object[] {
            "Locked",
            "Active"});
            this.createStatusComboBox.Location = new System.Drawing.Point(384, 135);
            this.createStatusComboBox.Name = "createStatusComboBox";
            this.createStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.createStatusComboBox.TabIndex = 16;
            // 
            // BrandManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 345);
            this.Controls.Add(this.createPnl);
            this.Controls.Add(this.brand_statusNumericUpDown);
            this.Controls.Add(this.country_nameComboBox);
            this.Controls.Add(country_nameLabel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(brand_idLabel);
            this.Controls.Add(this.brand_idTextBox);
            this.Controls.Add(brand_nameLabel);
            this.Controls.Add(this.brand_nameTextBox);
            this.Controls.Add(brand_createdAtLabel);
            this.Controls.Add(this.brand_createdAtDateTimePicker);
            this.Controls.Add(brand_statusLabel);
            this.Controls.Add(this.brandDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BrandManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfume Store Manager | Brand Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrandManagement_FormClosed);
            this.Load += new System.EventHandler(this.BrandManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_statusNumericUpDown)).EndInit();
            this.createPnl.ResumeLayout(false);
            this.createPnl.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker brand_createdAtDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Perfume_StoreDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource fKbrandcountryi0F624AF8BindingSource;
        private System.Windows.Forms.BindingSource fKbrandcountryi0F624AF8BindingSource1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox country_nameComboBox;
        private System.Windows.Forms.BindingSource fKbrandcountryi0F624AF8BindingSource2;
        private System.Windows.Forms.NumericUpDown brand_statusNumericUpDown;
        private System.Windows.Forms.Panel createPnl;
        private System.Windows.Forms.TextBox createBrand_nameTextBox;
        private System.Windows.Forms.Button returnToListBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox createCountry_idComboBox;
        private System.Windows.Forms.Button createClearBtn;
        private System.Windows.Forms.Button createCreateBtn;
        private System.Windows.Forms.ComboBox createStatusComboBox;
    }
}