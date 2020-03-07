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
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_volumneTextBox = new System.Windows.Forms.TextBox();
            this.product_quantityTextBox = new System.Windows.Forms.TextBox();
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.brand_idTextBox = new System.Windows.Forms.TextBox();
            this.product_originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.product_currentPriceTextBox = new System.Windows.Forms.TextBox();
            this.product_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_statusTextBox = new System.Windows.Forms.TextBox();
            this.product_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.product_createdByTextBox = new System.Windows.Forms.TextBox();
            this.product_updatedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.product_updateByTextBox = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(428, 82);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(75, 17);
            product_idLabel.TabIndex = 2;
            product_idLabel.Text = "product id:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(428, 110);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(99, 17);
            product_nameLabel.TabIndex = 4;
            product_nameLabel.Text = "product name:";
            // 
            // product_volumneLabel
            // 
            product_volumneLabel.AutoSize = true;
            product_volumneLabel.Location = new System.Drawing.Point(428, 138);
            product_volumneLabel.Name = "product_volumneLabel";
            product_volumneLabel.Size = new System.Drawing.Size(117, 17);
            product_volumneLabel.TabIndex = 6;
            product_volumneLabel.Text = "product volumne:";
            // 
            // product_quantityLabel
            // 
            product_quantityLabel.AutoSize = true;
            product_quantityLabel.Location = new System.Drawing.Point(428, 166);
            product_quantityLabel.Name = "product_quantityLabel";
            product_quantityLabel.Size = new System.Drawing.Size(114, 17);
            product_quantityLabel.TabIndex = 8;
            product_quantityLabel.Text = "product quantity:";
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(428, 194);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(82, 17);
            category_idLabel.TabIndex = 10;
            category_idLabel.Text = "category id:";
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Location = new System.Drawing.Point(428, 222);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(64, 17);
            brand_idLabel.TabIndex = 12;
            brand_idLabel.Text = "brand id:";
            // 
            // product_originalPriceLabel
            // 
            product_originalPriceLabel.AutoSize = true;
            product_originalPriceLabel.Location = new System.Drawing.Point(428, 250);
            product_originalPriceLabel.Name = "product_originalPriceLabel";
            product_originalPriceLabel.Size = new System.Drawing.Size(146, 17);
            product_originalPriceLabel.TabIndex = 14;
            product_originalPriceLabel.Text = "product original Price:";
            // 
            // product_currentPriceLabel
            // 
            product_currentPriceLabel.AutoSize = true;
            product_currentPriceLabel.Location = new System.Drawing.Point(428, 278);
            product_currentPriceLabel.Name = "product_currentPriceLabel";
            product_currentPriceLabel.Size = new System.Drawing.Size(145, 17);
            product_currentPriceLabel.TabIndex = 16;
            product_currentPriceLabel.Text = "product current Price:";
            // 
            // product_descriptionLabel
            // 
            product_descriptionLabel.AutoSize = true;
            product_descriptionLabel.Location = new System.Drawing.Point(428, 306);
            product_descriptionLabel.Name = "product_descriptionLabel";
            product_descriptionLabel.Size = new System.Drawing.Size(133, 17);
            product_descriptionLabel.TabIndex = 18;
            product_descriptionLabel.Text = "product description:";
            // 
            // product_statusLabel
            // 
            product_statusLabel.AutoSize = true;
            product_statusLabel.Location = new System.Drawing.Point(428, 334);
            product_statusLabel.Name = "product_statusLabel";
            product_statusLabel.Size = new System.Drawing.Size(102, 17);
            product_statusLabel.TabIndex = 20;
            product_statusLabel.Text = "product status:";
            // 
            // product_createdAtLabel
            // 
            product_createdAtLabel.AutoSize = true;
            product_createdAtLabel.Location = new System.Drawing.Point(428, 363);
            product_createdAtLabel.Name = "product_createdAtLabel";
            product_createdAtLabel.Size = new System.Drawing.Size(129, 17);
            product_createdAtLabel.TabIndex = 22;
            product_createdAtLabel.Text = "product created At:";
            // 
            // product_createdByLabel
            // 
            product_createdByLabel.AutoSize = true;
            product_createdByLabel.Location = new System.Drawing.Point(428, 390);
            product_createdByLabel.Name = "product_createdByLabel";
            product_createdByLabel.Size = new System.Drawing.Size(132, 17);
            product_createdByLabel.TabIndex = 24;
            product_createdByLabel.Text = "product created By:";
            // 
            // product_updatedAtLabel
            // 
            product_updatedAtLabel.AutoSize = true;
            product_updatedAtLabel.Location = new System.Drawing.Point(428, 419);
            product_updatedAtLabel.Name = "product_updatedAtLabel";
            product_updatedAtLabel.Size = new System.Drawing.Size(133, 17);
            product_updatedAtLabel.TabIndex = 26;
            product_updatedAtLabel.Text = "product updated At:";
            // 
            // product_updateByLabel
            // 
            product_updateByLabel.AutoSize = true;
            product_updateByLabel.Location = new System.Drawing.Point(428, 446);
            product_updateByLabel.Name = "product_updateByLabel";
            product_updateByLabel.Size = new System.Drawing.Size(128, 17);
            product_updateByLabel.TabIndex = 28;
            product_updateByLabel.Text = "product update By:";
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
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(20, 82);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(402, 381);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product_volumne";
            this.dataGridViewTextBoxColumn3.HeaderText = "product_volumne";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "product_quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "product_quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "category_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "brand_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "brand_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "product_originalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "product_originalPrice";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "product_currentPrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "product_currentPrice";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "product_description";
            this.dataGridViewTextBoxColumn9.HeaderText = "product_description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "product_status";
            this.dataGridViewTextBoxColumn10.HeaderText = "product_status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "product_createdAt";
            this.dataGridViewTextBoxColumn11.HeaderText = "product_createdAt";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "product_createdBy";
            this.dataGridViewTextBoxColumn12.HeaderText = "product_createdBy";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "product_updatedAt";
            this.dataGridViewTextBoxColumn13.HeaderText = "product_updatedAt";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "product_updateBy";
            this.dataGridViewTextBoxColumn14.HeaderText = "product_updateBy";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_id", true));
            this.product_idTextBox.Location = new System.Drawing.Point(580, 79);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_idTextBox.TabIndex = 3;
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(580, 107);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_nameTextBox.TabIndex = 5;
            // 
            // product_volumneTextBox
            // 
            this.product_volumneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_volumne", true));
            this.product_volumneTextBox.Location = new System.Drawing.Point(580, 135);
            this.product_volumneTextBox.Name = "product_volumneTextBox";
            this.product_volumneTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_volumneTextBox.TabIndex = 7;
            // 
            // product_quantityTextBox
            // 
            this.product_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_quantity", true));
            this.product_quantityTextBox.Location = new System.Drawing.Point(580, 163);
            this.product_quantityTextBox.Name = "product_quantityTextBox";
            this.product_quantityTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_quantityTextBox.TabIndex = 9;
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(580, 191);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.category_idTextBox.TabIndex = 11;
            // 
            // brand_idTextBox
            // 
            this.brand_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "brand_id", true));
            this.brand_idTextBox.Location = new System.Drawing.Point(580, 219);
            this.brand_idTextBox.Name = "brand_idTextBox";
            this.brand_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.brand_idTextBox.TabIndex = 13;
            // 
            // product_originalPriceTextBox
            // 
            this.product_originalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_originalPrice", true));
            this.product_originalPriceTextBox.Location = new System.Drawing.Point(580, 247);
            this.product_originalPriceTextBox.Name = "product_originalPriceTextBox";
            this.product_originalPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_originalPriceTextBox.TabIndex = 15;
            // 
            // product_currentPriceTextBox
            // 
            this.product_currentPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_currentPrice", true));
            this.product_currentPriceTextBox.Location = new System.Drawing.Point(580, 275);
            this.product_currentPriceTextBox.Name = "product_currentPriceTextBox";
            this.product_currentPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_currentPriceTextBox.TabIndex = 17;
            // 
            // product_descriptionTextBox
            // 
            this.product_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_description", true));
            this.product_descriptionTextBox.Location = new System.Drawing.Point(580, 303);
            this.product_descriptionTextBox.Name = "product_descriptionTextBox";
            this.product_descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_descriptionTextBox.TabIndex = 19;
            // 
            // product_statusTextBox
            // 
            this.product_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_status", true));
            this.product_statusTextBox.Location = new System.Drawing.Point(580, 331);
            this.product_statusTextBox.Name = "product_statusTextBox";
            this.product_statusTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_statusTextBox.TabIndex = 21;
            // 
            // product_createdAtDateTimePicker
            // 
            this.product_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_createdAt", true));
            this.product_createdAtDateTimePicker.Location = new System.Drawing.Point(580, 359);
            this.product_createdAtDateTimePicker.Name = "product_createdAtDateTimePicker";
            this.product_createdAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.product_createdAtDateTimePicker.TabIndex = 23;
            // 
            // product_createdByTextBox
            // 
            this.product_createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_createdBy", true));
            this.product_createdByTextBox.Location = new System.Drawing.Point(580, 387);
            this.product_createdByTextBox.Name = "product_createdByTextBox";
            this.product_createdByTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_createdByTextBox.TabIndex = 25;
            // 
            // product_updatedAtDateTimePicker
            // 
            this.product_updatedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_updatedAt", true));
            this.product_updatedAtDateTimePicker.Location = new System.Drawing.Point(580, 415);
            this.product_updatedAtDateTimePicker.Name = "product_updatedAtDateTimePicker";
            this.product_updatedAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.product_updatedAtDateTimePicker.TabIndex = 27;
            // 
            // product_updateByTextBox
            // 
            this.product_updateByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_updateBy", true));
            this.product_updateByTextBox.Location = new System.Drawing.Point(580, 443);
            this.product_updateByTextBox.Name = "product_updateByTextBox";
            this.product_updateByTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_updateByTextBox.TabIndex = 29;
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
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product Management";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(product_idLabel);
            this.Controls.Add(this.product_idTextBox);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(product_volumneLabel);
            this.Controls.Add(this.product_volumneTextBox);
            this.Controls.Add(product_quantityLabel);
            this.Controls.Add(this.product_quantityTextBox);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(this.category_idTextBox);
            this.Controls.Add(brand_idLabel);
            this.Controls.Add(this.brand_idTextBox);
            this.Controls.Add(product_originalPriceLabel);
            this.Controls.Add(this.product_originalPriceTextBox);
            this.Controls.Add(product_currentPriceLabel);
            this.Controls.Add(this.product_currentPriceTextBox);
            this.Controls.Add(product_descriptionLabel);
            this.Controls.Add(this.product_descriptionTextBox);
            this.Controls.Add(product_statusLabel);
            this.Controls.Add(this.product_statusTextBox);
            this.Controls.Add(product_createdAtLabel);
            this.Controls.Add(this.product_createdAtDateTimePicker);
            this.Controls.Add(product_createdByLabel);
            this.Controls.Add(this.product_createdByTextBox);
            this.Controls.Add(product_updatedAtLabel);
            this.Controls.Add(this.product_updatedAtDateTimePicker);
            this.Controls.Add(product_updateByLabel);
            this.Controls.Add(this.product_updateByTextBox);
            this.Controls.Add(this.productDataGridView);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Perfume_StoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox product_volumneTextBox;
        private System.Windows.Forms.TextBox product_quantityTextBox;
        private System.Windows.Forms.TextBox category_idTextBox;
        private System.Windows.Forms.TextBox brand_idTextBox;
        private System.Windows.Forms.TextBox product_originalPriceTextBox;
        private System.Windows.Forms.TextBox product_currentPriceTextBox;
        private System.Windows.Forms.TextBox product_descriptionTextBox;
        private System.Windows.Forms.TextBox product_statusTextBox;
        private System.Windows.Forms.DateTimePicker product_createdAtDateTimePicker;
        private System.Windows.Forms.TextBox product_createdByTextBox;
        private System.Windows.Forms.DateTimePicker product_updatedAtDateTimePicker;
        private System.Windows.Forms.TextBox product_updateByTextBox;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
    }
}