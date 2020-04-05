namespace PefumeStore.Management_Interface
{
    partial class CountryManagement
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
            System.Windows.Forms.Label country_nameLabel;
            System.Windows.Forms.Label country_statusLabel;
            System.Windows.Forms.Label country_idLabel;
            System.Windows.Forms.Label country_createdAtLabel;
            System.Windows.Forms.Label createCountry_nameLabel;
            System.Windows.Forms.Label createCountry_statusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.countriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.country_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.country_idTextBox = new System.Windows.Forms.TextBox();
            this.country_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countriesTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.countriesTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.createPnl = new System.Windows.Forms.Panel();
            this.createStatusComboBox = new System.Windows.Forms.ComboBox();
            this.createClearBtn = new System.Windows.Forms.Button();
            this.createCreateBtn = new System.Windows.Forms.Button();
            this.createCountry_nameTextBox = new System.Windows.Forms.TextBox();
            this.returnToListBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.country_statusComboBox = new System.Windows.Forms.ComboBox();
            country_nameLabel = new System.Windows.Forms.Label();
            country_statusLabel = new System.Windows.Forms.Label();
            country_idLabel = new System.Windows.Forms.Label();
            country_createdAtLabel = new System.Windows.Forms.Label();
            createCountry_nameLabel = new System.Windows.Forms.Label();
            createCountry_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            this.createPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // country_nameLabel
            // 
            country_nameLabel.AutoSize = true;
            country_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            country_nameLabel.ForeColor = System.Drawing.Color.SeaGreen;
            country_nameLabel.Location = new System.Drawing.Point(397, 107);
            country_nameLabel.Name = "country_nameLabel";
            country_nameLabel.Size = new System.Drawing.Size(118, 20);
            country_nameLabel.TabIndex = 4;
            country_nameLabel.Text = "Country name:";
            // 
            // country_statusLabel
            // 
            country_statusLabel.AutoSize = true;
            country_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            country_statusLabel.ForeColor = System.Drawing.Color.SeaGreen;
            country_statusLabel.Location = new System.Drawing.Point(397, 135);
            country_statusLabel.Name = "country_statusLabel";
            country_statusLabel.Size = new System.Drawing.Size(62, 20);
            country_statusLabel.TabIndex = 6;
            country_statusLabel.Text = "Status:";
            // 
            // country_idLabel
            // 
            country_idLabel.AutoSize = true;
            country_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            country_idLabel.ForeColor = System.Drawing.Color.SeaGreen;
            country_idLabel.Location = new System.Drawing.Point(397, 73);
            country_idLabel.Name = "country_idLabel";
            country_idLabel.Size = new System.Drawing.Size(90, 20);
            country_idLabel.TabIndex = 13;
            country_idLabel.Text = "Country id:";
            // 
            // country_createdAtLabel
            // 
            country_createdAtLabel.AutoSize = true;
            country_createdAtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            country_createdAtLabel.ForeColor = System.Drawing.Color.SeaGreen;
            country_createdAtLabel.Location = new System.Drawing.Point(397, 173);
            country_createdAtLabel.Name = "country_createdAtLabel";
            country_createdAtLabel.Size = new System.Drawing.Size(94, 20);
            country_createdAtLabel.TabIndex = 14;
            country_createdAtLabel.Text = "Created At:";
            // 
            // createCountry_nameLabel
            // 
            createCountry_nameLabel.AutoSize = true;
            createCountry_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createCountry_nameLabel.ForeColor = System.Drawing.Color.SeaGreen;
            createCountry_nameLabel.Location = new System.Drawing.Point(167, 74);
            createCountry_nameLabel.Name = "createCountry_nameLabel";
            createCountry_nameLabel.Size = new System.Drawing.Size(121, 20);
            createCountry_nameLabel.TabIndex = 4;
            createCountry_nameLabel.Text = "Country Name:";
            // 
            // createCountry_statusLabel
            // 
            createCountry_statusLabel.AutoSize = true;
            createCountry_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createCountry_statusLabel.ForeColor = System.Drawing.Color.SeaGreen;
            createCountry_statusLabel.Location = new System.Drawing.Point(167, 102);
            createCountry_statusLabel.Name = "createCountry_statusLabel";
            createCountry_statusLabel.Size = new System.Drawing.Size(125, 20);
            createCountry_statusLabel.TabIndex = 6;
            createCountry_statusLabel.Text = "Country Status:";
            // 
            // countriesDataGridView
            // 
            this.countriesDataGridView.AllowUserToAddRows = false;
            this.countriesDataGridView.AllowUserToDeleteRows = false;
            this.countriesDataGridView.AutoGenerateColumns = false;
            this.countriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.countriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.countriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.countriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.countriesDataGridView.DataSource = this.countriesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.countriesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.countriesDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.countriesDataGridView.Location = new System.Drawing.Point(14, 73);
            this.countriesDataGridView.Name = "countriesDataGridView";
            this.countriesDataGridView.ReadOnly = true;
            this.countriesDataGridView.RowTemplate.Height = 24;
            this.countriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.countriesDataGridView.Size = new System.Drawing.Size(377, 247);
            this.countriesDataGridView.TabIndex = 1;
            this.countriesDataGridView.SelectionChanged += new System.EventHandler(this.countriesDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "country_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "country_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country_status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "country_createdAt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Created At";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 104;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "countries";
            this.countriesBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // country_nameTextBox
            // 
            this.country_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_name", true));
            this.country_nameTextBox.Location = new System.Drawing.Point(531, 104);
            this.country_nameTextBox.Name = "country_nameTextBox";
            this.country_nameTextBox.Size = new System.Drawing.Size(243, 22);
            this.country_nameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(222, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Country Management";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 2;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.Location = new System.Drawing.Point(14, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(613, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(531, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(699, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // country_idTextBox
            // 
            this.country_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_id", true));
            this.country_idTextBox.Enabled = false;
            this.country_idTextBox.Location = new System.Drawing.Point(531, 70);
            this.country_idTextBox.Name = "country_idTextBox";
            this.country_idTextBox.Size = new System.Drawing.Size(143, 22);
            this.country_idTextBox.TabIndex = 14;
            // 
            // country_createdAtDateTimePicker
            // 
            this.country_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.countriesBindingSource, "country_createdAt", true));
            this.country_createdAtDateTimePicker.Location = new System.Drawing.Point(531, 169);
            this.country_createdAtDateTimePicker.Name = "country_createdAtDateTimePicker";
            this.country_createdAtDateTimePicker.Size = new System.Drawing.Size(243, 22);
            this.country_createdAtDateTimePicker.TabIndex = 15;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brandTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.countriesTableAdapter = this.countriesTableAdapter;
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
            // createPnl
            // 
            this.createPnl.BackColor = System.Drawing.Color.Transparent;
            this.createPnl.Controls.Add(this.createStatusComboBox);
            this.createPnl.Controls.Add(this.createClearBtn);
            this.createPnl.Controls.Add(this.createCreateBtn);
            this.createPnl.Controls.Add(createCountry_nameLabel);
            this.createPnl.Controls.Add(this.createCountry_nameTextBox);
            this.createPnl.Controls.Add(createCountry_statusLabel);
            this.createPnl.Controls.Add(this.returnToListBtn);
            this.createPnl.Controls.Add(this.label2);
            this.createPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createPnl.Location = new System.Drawing.Point(0, 0);
            this.createPnl.Name = "createPnl";
            this.createPnl.Size = new System.Drawing.Size(794, 347);
            this.createPnl.TabIndex = 17;
            // 
            // createStatusComboBox
            // 
            this.createStatusComboBox.FormattingEnabled = true;
            this.createStatusComboBox.Items.AddRange(new object[] {
            "Locked",
            "Active"});
            this.createStatusComboBox.Location = new System.Drawing.Point(299, 99);
            this.createStatusComboBox.Name = "createStatusComboBox";
            this.createStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.createStatusComboBox.TabIndex = 10;
            // 
            // createClearBtn
            // 
            this.createClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.createClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createClearBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.createClearBtn.Location = new System.Drawing.Point(421, 163);
            this.createClearBtn.Name = "createClearBtn";
            this.createClearBtn.Size = new System.Drawing.Size(110, 35);
            this.createClearBtn.TabIndex = 9;
            this.createClearBtn.Text = "Clear";
            this.createClearBtn.UseVisualStyleBackColor = false;
            this.createClearBtn.Click += new System.EventHandler(this.createClearBtn_Click);
            // 
            // createCreateBtn
            // 
            this.createCreateBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.createCreateBtn.FlatAppearance.BorderSize = 0;
            this.createCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCreateBtn.ForeColor = System.Drawing.Color.White;
            this.createCreateBtn.Location = new System.Drawing.Point(299, 163);
            this.createCreateBtn.Name = "createCreateBtn";
            this.createCreateBtn.Size = new System.Drawing.Size(110, 35);
            this.createCreateBtn.TabIndex = 8;
            this.createCreateBtn.Text = "Create";
            this.createCreateBtn.UseVisualStyleBackColor = false;
            this.createCreateBtn.Click += new System.EventHandler(this.createCreateBtn_Click);
            // 
            // createCountry_nameTextBox
            // 
            this.createCountry_nameTextBox.Location = new System.Drawing.Point(301, 71);
            this.createCountry_nameTextBox.Name = "createCountry_nameTextBox";
            this.createCountry_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.createCountry_nameTextBox.TabIndex = 5;
            // 
            // returnToListBtn
            // 
            this.returnToListBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnToListBtn.FlatAppearance.BorderSize = 2;
            this.returnToListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToListBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.returnToListBtn.Location = new System.Drawing.Point(12, 15);
            this.returnToListBtn.Name = "returnToListBtn";
            this.returnToListBtn.Size = new System.Drawing.Size(140, 35);
            this.returnToListBtn.TabIndex = 1;
            this.returnToListBtn.Text = "Return to List";
            this.returnToListBtn.UseVisualStyleBackColor = false;
            this.returnToListBtn.Click += new System.EventHandler(this.returnToListBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(348, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.country_statusComboBox);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.countriesDataGridView);
            this.panel1.Controls.Add(country_statusLabel);
            this.panel1.Controls.Add(country_createdAtLabel);
            this.panel1.Controls.Add(this.country_nameTextBox);
            this.panel1.Controls.Add(this.country_createdAtDateTimePicker);
            this.panel1.Controls.Add(country_nameLabel);
            this.panel1.Controls.Add(country_idLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.country_idTextBox);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 347);
            this.panel1.TabIndex = 18;
            // 
            // country_statusComboBox
            // 
            this.country_statusComboBox.FormattingEnabled = true;
            this.country_statusComboBox.Items.AddRange(new object[] {
            "Locked",
            "Active"});
            this.country_statusComboBox.Location = new System.Drawing.Point(531, 135);
            this.country_statusComboBox.Name = "country_statusComboBox";
            this.country_statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.country_statusComboBox.TabIndex = 16;
            // 
            // CountryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CountryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country Management | Perfume Store Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CountryManagement_FormClosed);
            this.Load += new System.EventHandler(this.CountryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            this.createPnl.ResumeLayout(false);
            this.createPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Perfume_StoreDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView countriesDataGridView;
        private System.Windows.Forms.TextBox country_nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox country_idTextBox;
        private System.Windows.Forms.DateTimePicker country_createdAtDateTimePicker;
        private System.Windows.Forms.Panel createPnl;
        private System.Windows.Forms.Button createCreateBtn;
        private System.Windows.Forms.TextBox createCountry_nameTextBox;
        private System.Windows.Forms.Button returnToListBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createClearBtn;
        private System.Windows.Forms.ComboBox createStatusComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox country_statusComboBox;
    }
}