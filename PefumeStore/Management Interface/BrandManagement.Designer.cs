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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.createStatusComboBox = new System.Windows.Forms.ComboBox();
            this.createClearBtn = new System.Windows.Forms.Button();
            this.createCreateBtn = new System.Windows.Forms.Button();
            this.createCountry_idComboBox = new System.Windows.Forms.ComboBox();
            this.createBrand_nameTextBox = new System.Windows.Forms.TextBox();
            this.returnToListBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brand_idLabel.ForeColor = System.Drawing.Color.SeaGreen;
            brand_idLabel.Location = new System.Drawing.Point(541, 82);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(77, 20);
            brand_idLabel.TabIndex = 2;
            brand_idLabel.Text = "Brand id:";
            // 
            // brand_nameLabel
            // 
            brand_nameLabel.AutoSize = true;
            brand_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brand_nameLabel.ForeColor = System.Drawing.Color.SeaGreen;
            brand_nameLabel.Location = new System.Drawing.Point(541, 110);
            brand_nameLabel.Name = "brand_nameLabel";
            brand_nameLabel.Size = new System.Drawing.Size(105, 20);
            brand_nameLabel.TabIndex = 4;
            brand_nameLabel.Text = "Brand name:";
            // 
            // brand_createdAtLabel
            // 
            brand_createdAtLabel.AutoSize = true;
            brand_createdAtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brand_createdAtLabel.ForeColor = System.Drawing.Color.SeaGreen;
            brand_createdAtLabel.Location = new System.Drawing.Point(541, 167);
            brand_createdAtLabel.Name = "brand_createdAtLabel";
            brand_createdAtLabel.Size = new System.Drawing.Size(94, 20);
            brand_createdAtLabel.TabIndex = 8;
            brand_createdAtLabel.Text = "Created At:";
            // 
            // brand_statusLabel
            // 
            brand_statusLabel.AutoSize = true;
            brand_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brand_statusLabel.ForeColor = System.Drawing.Color.SeaGreen;
            brand_statusLabel.Location = new System.Drawing.Point(541, 194);
            brand_statusLabel.Name = "brand_statusLabel";
            brand_statusLabel.Size = new System.Drawing.Size(62, 20);
            brand_statusLabel.TabIndex = 10;
            brand_statusLabel.Text = "Status:";
            // 
            // country_nameLabel
            // 
            country_nameLabel.AutoSize = true;
            country_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            country_nameLabel.ForeColor = System.Drawing.Color.SeaGreen;
            country_nameLabel.Location = new System.Drawing.Point(541, 137);
            country_nameLabel.Name = "country_nameLabel";
            country_nameLabel.Size = new System.Drawing.Size(72, 20);
            country_nameLabel.TabIndex = 21;
            country_nameLabel.Text = "Country:";
            // 
            // createBrand_nameLabel
            // 
            createBrand_nameLabel.AutoSize = true;
            createBrand_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createBrand_nameLabel.ForeColor = System.Drawing.Color.SeaGreen;
            createBrand_nameLabel.Location = new System.Drawing.Point(254, 70);
            createBrand_nameLabel.Name = "createBrand_nameLabel";
            createBrand_nameLabel.Size = new System.Drawing.Size(105, 20);
            createBrand_nameLabel.TabIndex = 5;
            createBrand_nameLabel.Text = "Brand name:";
            // 
            // craeteBrand_statusLabel
            // 
            craeteBrand_statusLabel.AutoSize = true;
            craeteBrand_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            craeteBrand_statusLabel.ForeColor = System.Drawing.Color.SeaGreen;
            craeteBrand_statusLabel.Location = new System.Drawing.Point(254, 145);
            craeteBrand_statusLabel.Name = "craeteBrand_statusLabel";
            craeteBrand_statusLabel.Size = new System.Drawing.Size(110, 20);
            craeteBrand_statusLabel.TabIndex = 11;
            craeteBrand_statusLabel.Text = "Brand status:";
            // 
            // createCountry_idLabel
            // 
            createCountry_idLabel.AutoSize = true;
            createCountry_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createCountry_idLabel.ForeColor = System.Drawing.Color.SeaGreen;
            createCountry_idLabel.Location = new System.Drawing.Point(254, 107);
            createCountry_idLabel.Name = "createCountry_idLabel";
            createCountry_idLabel.Size = new System.Drawing.Size(118, 20);
            createCountry_idLabel.TabIndex = 12;
            createCountry_idLabel.Text = "Country name:";
            // 
            // brandDataGridView
            // 
            this.brandDataGridView.AllowUserToAddRows = false;
            this.brandDataGridView.AllowUserToDeleteRows = false;
            this.brandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.brandDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.brandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.brandDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.brandDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.brandDataGridView.Location = new System.Drawing.Point(3, 82);
            this.brandDataGridView.MultiSelect = false;
            this.brandDataGridView.Name = "brandDataGridView";
            this.brandDataGridView.ReadOnly = true;
            this.brandDataGridView.RowTemplate.Height = 24;
            this.brandDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandDataGridView.Size = new System.Drawing.Size(509, 220);
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
            this.brand_idTextBox.Location = new System.Drawing.Point(665, 79);
            this.brand_idTextBox.Name = "brand_idTextBox";
            this.brand_idTextBox.Size = new System.Drawing.Size(75, 22);
            this.brand_idTextBox.TabIndex = 3;
            // 
            // brand_nameTextBox
            // 
            this.brand_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_name", true));
            this.brand_nameTextBox.Location = new System.Drawing.Point(665, 107);
            this.brand_nameTextBox.Name = "brand_nameTextBox";
            this.brand_nameTextBox.Size = new System.Drawing.Size(244, 22);
            this.brand_nameTextBox.TabIndex = 5;
            // 
            // brand_createdAtDateTimePicker
            // 
            this.brand_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.brandBindingSource, "brand_createdAt", true));
            this.brand_createdAtDateTimePicker.Location = new System.Drawing.Point(665, 163);
            this.brand_createdAtDateTimePicker.Name = "brand_createdAtDateTimePicker";
            this.brand_createdAtDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.brand_createdAtDateTimePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(323, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Brand Management";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(837, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(665, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(746, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.FlatAppearance.BorderSize = 2;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 30);
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
            this.country_nameComboBox.Location = new System.Drawing.Point(665, 132);
            this.country_nameComboBox.Name = "country_nameComboBox";
            this.country_nameComboBox.Size = new System.Drawing.Size(244, 24);
            this.country_nameComboBox.TabIndex = 22;
            this.country_nameComboBox.ValueMember = "country_id";
            // 
            // brand_statusNumericUpDown
            // 
            this.brand_statusNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.brandBindingSource, "brand_status", true));
            this.brand_statusNumericUpDown.Location = new System.Drawing.Point(665, 194);
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
            this.createPnl.BackColor = System.Drawing.Color.Transparent;
            this.createPnl.Controls.Add(this.createStatusComboBox);
            this.createPnl.Controls.Add(this.createClearBtn);
            this.createPnl.Controls.Add(this.createCreateBtn);
            this.createPnl.Controls.Add(this.createCountry_idComboBox);
            this.createPnl.Controls.Add(this.createBrand_nameTextBox);
            this.createPnl.Controls.Add(this.returnToListBtn);
            this.createPnl.Controls.Add(createCountry_idLabel);
            this.createPnl.Controls.Add(createBrand_nameLabel);
            this.createPnl.Controls.Add(craeteBrand_statusLabel);
            this.createPnl.Controls.Add(this.label2);
            this.createPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createPnl.ForeColor = System.Drawing.Color.SeaGreen;
            this.createPnl.Location = new System.Drawing.Point(0, 0);
            this.createPnl.Name = "createPnl";
            this.createPnl.Size = new System.Drawing.Size(941, 345);
            this.createPnl.TabIndex = 24;
            this.createPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.createPnl_Paint);
            // 
            // createStatusComboBox
            // 
            this.createStatusComboBox.FormattingEnabled = true;
            this.createStatusComboBox.Items.AddRange(new object[] {
            "Locked",
            "Active"});
            this.createStatusComboBox.Location = new System.Drawing.Point(391, 143);
            this.createStatusComboBox.Name = "createStatusComboBox";
            this.createStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.createStatusComboBox.TabIndex = 16;
            // 
            // createClearBtn
            // 
            this.createClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.createClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createClearBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.createClearBtn.Location = new System.Drawing.Point(513, 205);
            this.createClearBtn.Name = "createClearBtn";
            this.createClearBtn.Size = new System.Drawing.Size(92, 35);
            this.createClearBtn.TabIndex = 15;
            this.createClearBtn.Text = "Clear";
            this.createClearBtn.UseVisualStyleBackColor = true;
            this.createClearBtn.Click += new System.EventHandler(this.createClearBtn_Click);
            // 
            // createCreateBtn
            // 
            this.createCreateBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.createCreateBtn.FlatAppearance.BorderSize = 0;
            this.createCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCreateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.createCreateBtn.Location = new System.Drawing.Point(391, 205);
            this.createCreateBtn.Name = "createCreateBtn";
            this.createCreateBtn.Size = new System.Drawing.Size(110, 35);
            this.createCreateBtn.TabIndex = 14;
            this.createCreateBtn.Text = "Create";
            this.createCreateBtn.UseVisualStyleBackColor = false;
            this.createCreateBtn.Click += new System.EventHandler(this.createCreateBtn_Click);
            // 
            // createCountry_idComboBox
            // 
            this.createCountry_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_id", true));
            this.createCountry_idComboBox.DataSource = this.countriesBindingSource;
            this.createCountry_idComboBox.DisplayMember = "country_name";
            this.createCountry_idComboBox.FormattingEnabled = true;
            this.createCountry_idComboBox.Location = new System.Drawing.Point(391, 103);
            this.createCountry_idComboBox.Name = "createCountry_idComboBox";
            this.createCountry_idComboBox.Size = new System.Drawing.Size(121, 24);
            this.createCountry_idComboBox.TabIndex = 13;
            this.createCountry_idComboBox.ValueMember = "country_id";
            // 
            // createBrand_nameTextBox
            // 
            this.createBrand_nameTextBox.Location = new System.Drawing.Point(391, 70);
            this.createBrand_nameTextBox.Name = "createBrand_nameTextBox";
            this.createBrand_nameTextBox.Size = new System.Drawing.Size(225, 22);
            this.createBrand_nameTextBox.TabIndex = 6;
            // 
            // returnToListBtn
            // 
            this.returnToListBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.returnToListBtn.FlatAppearance.BorderSize = 2;
            this.returnToListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToListBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.returnToListBtn.Location = new System.Drawing.Point(12, 12);
            this.returnToListBtn.Name = "returnToListBtn";
            this.returnToListBtn.Size = new System.Drawing.Size(141, 35);
            this.returnToListBtn.TabIndex = 3;
            this.returnToListBtn.Text = "Return to List";
            this.returnToListBtn.UseVisualStyleBackColor = true;
            this.returnToListBtn.Click += new System.EventHandler(this.returnToListBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.brand_statusNumericUpDown);
            this.panel1.Controls.Add(this.brandDataGridView);
            this.panel1.Controls.Add(this.country_nameComboBox);
            this.panel1.Controls.Add(brand_statusLabel);
            this.panel1.Controls.Add(country_nameLabel);
            this.panel1.Controls.Add(this.brand_createdAtDateTimePicker);
            this.panel1.Controls.Add(brand_createdAtLabel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.brand_nameTextBox);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(brand_nameLabel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.brand_idTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(brand_idLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 345);
            this.panel1.TabIndex = 25;
            // 
            // BrandManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 345);
            this.Controls.Add(this.createPnl);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}