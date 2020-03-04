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
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.brandTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.brandDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_idTextBox = new System.Windows.Forms.TextBox();
            this.brand_nameTextBox = new System.Windows.Forms.TextBox();
            this.country_idTextBox = new System.Windows.Forms.TextBox();
            this.brand_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.brand_statusTextBox = new System.Windows.Forms.TextBox();
            brand_idLabel = new System.Windows.Forms.Label();
            brand_nameLabel = new System.Windows.Forms.Label();
            country_idLabel = new System.Windows.Forms.Label();
            brand_createdAtLabel = new System.Windows.Forms.Label();
            brand_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // brandDataGridView
            // 
            this.brandDataGridView.AutoGenerateColumns = false;
            this.brandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.brandDataGridView.DataSource = this.brandBindingSource;
            this.brandDataGridView.Location = new System.Drawing.Point(12, 94);
            this.brandDataGridView.Name = "brandDataGridView";
            this.brandDataGridView.RowTemplate.Height = 24;
            this.brandDataGridView.Size = new System.Drawing.Size(300, 220);
            this.brandDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "brand_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "brand_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "brand_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "brand_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "country_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "brand_createdAt";
            this.dataGridViewTextBoxColumn4.HeaderText = "brand_createdAt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "brand_status";
            this.dataGridViewTextBoxColumn5.HeaderText = "brand_status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Location = new System.Drawing.Point(421, 80);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(64, 17);
            brand_idLabel.TabIndex = 2;
            brand_idLabel.Text = "brand id:";
            // 
            // brand_idTextBox
            // 
            this.brand_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_id", true));
            this.brand_idTextBox.Location = new System.Drawing.Point(545, 77);
            this.brand_idTextBox.Name = "brand_idTextBox";
            this.brand_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.brand_idTextBox.TabIndex = 3;
            // 
            // brand_nameLabel
            // 
            brand_nameLabel.AutoSize = true;
            brand_nameLabel.Location = new System.Drawing.Point(421, 108);
            brand_nameLabel.Name = "brand_nameLabel";
            brand_nameLabel.Size = new System.Drawing.Size(88, 17);
            brand_nameLabel.TabIndex = 4;
            brand_nameLabel.Text = "brand name:";
            // 
            // brand_nameTextBox
            // 
            this.brand_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_name", true));
            this.brand_nameTextBox.Location = new System.Drawing.Point(545, 105);
            this.brand_nameTextBox.Name = "brand_nameTextBox";
            this.brand_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.brand_nameTextBox.TabIndex = 5;
            // 
            // country_idLabel
            // 
            country_idLabel.AutoSize = true;
            country_idLabel.Location = new System.Drawing.Point(421, 136);
            country_idLabel.Name = "country_idLabel";
            country_idLabel.Size = new System.Drawing.Size(74, 17);
            country_idLabel.TabIndex = 6;
            country_idLabel.Text = "country id:";
            // 
            // country_idTextBox
            // 
            this.country_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "country_id", true));
            this.country_idTextBox.Location = new System.Drawing.Point(545, 133);
            this.country_idTextBox.Name = "country_idTextBox";
            this.country_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.country_idTextBox.TabIndex = 7;
            // 
            // brand_createdAtLabel
            // 
            brand_createdAtLabel.AutoSize = true;
            brand_createdAtLabel.Location = new System.Drawing.Point(421, 165);
            brand_createdAtLabel.Name = "brand_createdAtLabel";
            brand_createdAtLabel.Size = new System.Drawing.Size(118, 17);
            brand_createdAtLabel.TabIndex = 8;
            brand_createdAtLabel.Text = "brand created At:";
            // 
            // brand_createdAtDateTimePicker
            // 
            this.brand_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.brandBindingSource, "brand_createdAt", true));
            this.brand_createdAtDateTimePicker.Location = new System.Drawing.Point(545, 161);
            this.brand_createdAtDateTimePicker.Name = "brand_createdAtDateTimePicker";
            this.brand_createdAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.brand_createdAtDateTimePicker.TabIndex = 9;
            // 
            // brand_statusLabel
            // 
            brand_statusLabel.AutoSize = true;
            brand_statusLabel.Location = new System.Drawing.Point(421, 192);
            brand_statusLabel.Name = "brand_statusLabel";
            brand_statusLabel.Size = new System.Drawing.Size(91, 17);
            brand_statusLabel.TabIndex = 10;
            brand_statusLabel.Text = "brand status:";
            // 
            // brand_statusTextBox
            // 
            this.brand_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brandBindingSource, "brand_status", true));
            this.brand_statusTextBox.Location = new System.Drawing.Point(545, 189);
            this.brand_statusTextBox.Name = "brand_statusTextBox";
            this.brand_statusTextBox.Size = new System.Drawing.Size(200, 22);
            this.brand_statusTextBox.TabIndex = 11;
            // 
            // BrandManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(brand_idLabel);
            this.Controls.Add(this.brand_idTextBox);
            this.Controls.Add(brand_nameLabel);
            this.Controls.Add(this.brand_nameTextBox);
            this.Controls.Add(country_idLabel);
            this.Controls.Add(this.country_idTextBox);
            this.Controls.Add(brand_createdAtLabel);
            this.Controls.Add(this.brand_createdAtDateTimePicker);
            this.Controls.Add(brand_statusLabel);
            this.Controls.Add(this.brand_statusTextBox);
            this.Controls.Add(this.brandDataGridView);
            this.Name = "BrandManagement";
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.BrandManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Perfume_StoreDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView brandDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox brand_idTextBox;
        private System.Windows.Forms.TextBox brand_nameTextBox;
        private System.Windows.Forms.TextBox country_idTextBox;
        private System.Windows.Forms.DateTimePicker brand_createdAtDateTimePicker;
        private System.Windows.Forms.TextBox brand_statusTextBox;
    }
}