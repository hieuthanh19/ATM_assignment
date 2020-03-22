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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryManagement));
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
            this.country_statusComboBox = new System.Windows.Forms.ComboBox();
            this.createPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.returnToListBtn = new System.Windows.Forms.Button();
            this.createCountry_nameTextBox = new System.Windows.Forms.TextBox();
            this.createCreateBtn = new System.Windows.Forms.Button();
            this.createClearBtn = new System.Windows.Forms.Button();
            this.createStatusComboBox = new System.Windows.Forms.ComboBox();
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
            this.SuspendLayout();
            // 
            // country_nameLabel
            // 
            country_nameLabel.AutoSize = true;
            country_nameLabel.Location = new System.Drawing.Point(395, 111);
            country_nameLabel.Name = "country_nameLabel";
            country_nameLabel.Size = new System.Drawing.Size(98, 17);
            country_nameLabel.TabIndex = 4;
            country_nameLabel.Text = "country name:";
            // 
            // country_statusLabel
            // 
            country_statusLabel.AutoSize = true;
            country_statusLabel.Location = new System.Drawing.Point(395, 139);
            country_statusLabel.Name = "country_statusLabel";
            country_statusLabel.Size = new System.Drawing.Size(101, 17);
            country_statusLabel.TabIndex = 6;
            country_statusLabel.Text = "country status:";
            // 
            // country_idLabel
            // 
            country_idLabel.AutoSize = true;
            country_idLabel.Location = new System.Drawing.Point(395, 77);
            country_idLabel.Name = "country_idLabel";
            country_idLabel.Size = new System.Drawing.Size(74, 17);
            country_idLabel.TabIndex = 13;
            country_idLabel.Text = "country id:";
            // 
            // country_createdAtLabel
            // 
            country_createdAtLabel.AutoSize = true;
            country_createdAtLabel.Location = new System.Drawing.Point(395, 177);
            country_createdAtLabel.Name = "country_createdAtLabel";
            country_createdAtLabel.Size = new System.Drawing.Size(128, 17);
            country_createdAtLabel.TabIndex = 14;
            country_createdAtLabel.Text = "country created At:";
            // 
            // countriesDataGridView
            // 
            this.countriesDataGridView.AllowUserToAddRows = false;
            this.countriesDataGridView.AllowUserToDeleteRows = false;
            this.countriesDataGridView.AutoGenerateColumns = false;
            this.countriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.countriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.countriesDataGridView.DataSource = this.countriesBindingSource;
            this.countriesDataGridView.Location = new System.Drawing.Point(12, 77);
            this.countriesDataGridView.Name = "countriesDataGridView";
            this.countriesDataGridView.ReadOnly = true;
            this.countriesDataGridView.RowTemplate.Height = 24;
            this.countriesDataGridView.Size = new System.Drawing.Size(357, 247);
            this.countriesDataGridView.TabIndex = 1;
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
            this.country_nameTextBox.Location = new System.Drawing.Point(529, 108);
            this.country_nameTextBox.Name = "country_nameTextBox";
            this.country_nameTextBox.Size = new System.Drawing.Size(243, 22);
            this.country_nameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Country Management";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 19);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(566, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(485, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(647, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // country_idTextBox
            // 
            this.country_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_id", true));
            this.country_idTextBox.Enabled = false;
            this.country_idTextBox.Location = new System.Drawing.Point(529, 74);
            this.country_idTextBox.Name = "country_idTextBox";
            this.country_idTextBox.Size = new System.Drawing.Size(143, 22);
            this.country_idTextBox.TabIndex = 14;
            // 
            // country_createdAtDateTimePicker
            // 
            this.country_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.countriesBindingSource, "country_createdAt", true));
            this.country_createdAtDateTimePicker.Location = new System.Drawing.Point(529, 173);
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
            // country_statusComboBox
            // 
            this.country_statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_status", true));
            this.country_statusComboBox.DataSource = this.countriesBindingSource;
            this.country_statusComboBox.DisplayMember = "country_status";
            this.country_statusComboBox.FormattingEnabled = true;
            this.country_statusComboBox.Location = new System.Drawing.Point(529, 139);
            this.country_statusComboBox.Name = "country_statusComboBox";
            this.country_statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.country_statusComboBox.TabIndex = 16;
            this.country_statusComboBox.ValueMember = "country_status";
            // 
            // createPnl
            // 
            this.createPnl.Controls.Add(this.createStatusComboBox);
            this.createPnl.Controls.Add(this.createClearBtn);
            this.createPnl.Controls.Add(this.createCreateBtn);
            this.createPnl.Controls.Add(createCountry_nameLabel);
            this.createPnl.Controls.Add(this.createCountry_nameTextBox);
            this.createPnl.Controls.Add(createCountry_statusLabel);
            this.createPnl.Controls.Add(this.returnToListBtn);
            this.createPnl.Controls.Add(this.label2);
            this.createPnl.Location = new System.Drawing.Point(12, 9);
            this.createPnl.Name = "createPnl";
            this.createPnl.Size = new System.Drawing.Size(770, 326);
            this.createPnl.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create";
            // 
            // returnToListBtn
            // 
            this.returnToListBtn.Location = new System.Drawing.Point(15, 10);
            this.returnToListBtn.Name = "returnToListBtn";
            this.returnToListBtn.Size = new System.Drawing.Size(110, 35);
            this.returnToListBtn.TabIndex = 1;
            this.returnToListBtn.Text = "Return to List";
            this.returnToListBtn.UseVisualStyleBackColor = true;
            this.returnToListBtn.Click += new System.EventHandler(this.returnToListBtn_Click);
            // 
            // createCountry_nameLabel
            // 
            createCountry_nameLabel.AutoSize = true;
            createCountry_nameLabel.Location = new System.Drawing.Point(135, 70);
            createCountry_nameLabel.Name = "createCountry_nameLabel";
            createCountry_nameLabel.Size = new System.Drawing.Size(102, 17);
            createCountry_nameLabel.TabIndex = 4;
            createCountry_nameLabel.Text = "Country Name:";
            // 
            // createCountry_nameTextBox
            // 
            this.createCountry_nameTextBox.Location = new System.Drawing.Point(269, 67);
            this.createCountry_nameTextBox.Name = "createCountry_nameTextBox";
            this.createCountry_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.createCountry_nameTextBox.TabIndex = 5;
            // 
            // createCountry_statusLabel
            // 
            createCountry_statusLabel.AutoSize = true;
            createCountry_statusLabel.Location = new System.Drawing.Point(135, 98);
            createCountry_statusLabel.Name = "createCountry_statusLabel";
            createCountry_statusLabel.Size = new System.Drawing.Size(105, 17);
            createCountry_statusLabel.TabIndex = 6;
            createCountry_statusLabel.Text = "Country Status:";
            // 
            // createCreateBtn
            // 
            this.createCreateBtn.Location = new System.Drawing.Point(267, 159);
            this.createCreateBtn.Name = "createCreateBtn";
            this.createCreateBtn.Size = new System.Drawing.Size(110, 35);
            this.createCreateBtn.TabIndex = 8;
            this.createCreateBtn.Text = "Create";
            this.createCreateBtn.UseVisualStyleBackColor = true;
            this.createCreateBtn.Click += new System.EventHandler(this.createCreateBtn_Click);
            // 
            // createClearBtn
            // 
            this.createClearBtn.Location = new System.Drawing.Point(389, 159);
            this.createClearBtn.Name = "createClearBtn";
            this.createClearBtn.Size = new System.Drawing.Size(110, 35);
            this.createClearBtn.TabIndex = 9;
            this.createClearBtn.Text = "Clear";
            this.createClearBtn.UseVisualStyleBackColor = true;
            this.createClearBtn.Click += new System.EventHandler(this.createClearBtn_Click);
            // 
            // createStatusComboBox
            // 
            this.createStatusComboBox.FormattingEnabled = true;
            this.createStatusComboBox.Items.AddRange(new object[] {
            "Locked",
            "Active"});
            this.createStatusComboBox.Location = new System.Drawing.Point(267, 95);
            this.createStatusComboBox.Name = "createStatusComboBox";
            this.createStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.createStatusComboBox.TabIndex = 10;
            // 
            // CountryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 347);
            this.Controls.Add(this.createPnl);
            this.Controls.Add(this.country_statusComboBox);
            this.Controls.Add(country_createdAtLabel);
            this.Controls.Add(this.country_createdAtDateTimePicker);
            this.Controls.Add(country_idLabel);
            this.Controls.Add(this.country_idTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(country_nameLabel);
            this.Controls.Add(this.country_nameTextBox);
            this.Controls.Add(country_statusLabel);
            this.Controls.Add(this.countriesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CountryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfume Store Manager | Country Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CountryManagement_FormClosed);
            this.Load += new System.EventHandler(this.CountryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            this.createPnl.ResumeLayout(false);
            this.createPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Perfume_StoreDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView countriesDataGridView;
        private System.Windows.Forms.TextBox country_nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox country_idTextBox;
        private System.Windows.Forms.DateTimePicker country_createdAtDateTimePicker;
        private System.Windows.Forms.ComboBox country_statusComboBox;
        private System.Windows.Forms.Panel createPnl;
        private System.Windows.Forms.Button createCreateBtn;
        private System.Windows.Forms.TextBox createCountry_nameTextBox;
        private System.Windows.Forms.Button returnToListBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createClearBtn;
        private System.Windows.Forms.ComboBox createStatusComboBox;
    }
}