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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
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
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
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
            this.productDataGridView.Size = new System.Drawing.Size(300, 220);
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
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(359, 82);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(75, 17);
            product_idLabel.TabIndex = 2;
            product_idLabel.Text = "product id:";
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_id", true));
            this.product_idTextBox.Location = new System.Drawing.Point(511, 79);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_idTextBox.TabIndex = 3;
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(359, 110);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(99, 17);
            product_nameLabel.TabIndex = 4;
            product_nameLabel.Text = "product name:";
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(511, 107);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_nameTextBox.TabIndex = 5;
            // 
            // product_volumneLabel
            // 
            product_volumneLabel.AutoSize = true;
            product_volumneLabel.Location = new System.Drawing.Point(359, 138);
            product_volumneLabel.Name = "product_volumneLabel";
            product_volumneLabel.Size = new System.Drawing.Size(117, 17);
            product_volumneLabel.TabIndex = 6;
            product_volumneLabel.Text = "product volumne:";
            // 
            // product_volumneTextBox
            // 
            this.product_volumneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_volumne", true));
            this.product_volumneTextBox.Location = new System.Drawing.Point(511, 135);
            this.product_volumneTextBox.Name = "product_volumneTextBox";
            this.product_volumneTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_volumneTextBox.TabIndex = 7;
            // 
            // product_quantityLabel
            // 
            product_quantityLabel.AutoSize = true;
            product_quantityLabel.Location = new System.Drawing.Point(359, 166);
            product_quantityLabel.Name = "product_quantityLabel";
            product_quantityLabel.Size = new System.Drawing.Size(114, 17);
            product_quantityLabel.TabIndex = 8;
            product_quantityLabel.Text = "product quantity:";
            // 
            // product_quantityTextBox
            // 
            this.product_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_quantity", true));
            this.product_quantityTextBox.Location = new System.Drawing.Point(511, 163);
            this.product_quantityTextBox.Name = "product_quantityTextBox";
            this.product_quantityTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_quantityTextBox.TabIndex = 9;
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(359, 194);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(82, 17);
            category_idLabel.TabIndex = 10;
            category_idLabel.Text = "category id:";
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(511, 191);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.category_idTextBox.TabIndex = 11;
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Location = new System.Drawing.Point(359, 222);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(64, 17);
            brand_idLabel.TabIndex = 12;
            brand_idLabel.Text = "brand id:";
            // 
            // brand_idTextBox
            // 
            this.brand_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "brand_id", true));
            this.brand_idTextBox.Location = new System.Drawing.Point(511, 219);
            this.brand_idTextBox.Name = "brand_idTextBox";
            this.brand_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.brand_idTextBox.TabIndex = 13;
            // 
            // product_originalPriceLabel
            // 
            product_originalPriceLabel.AutoSize = true;
            product_originalPriceLabel.Location = new System.Drawing.Point(359, 250);
            product_originalPriceLabel.Name = "product_originalPriceLabel";
            product_originalPriceLabel.Size = new System.Drawing.Size(146, 17);
            product_originalPriceLabel.TabIndex = 14;
            product_originalPriceLabel.Text = "product original Price:";
            // 
            // product_originalPriceTextBox
            // 
            this.product_originalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_originalPrice", true));
            this.product_originalPriceTextBox.Location = new System.Drawing.Point(511, 247);
            this.product_originalPriceTextBox.Name = "product_originalPriceTextBox";
            this.product_originalPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_originalPriceTextBox.TabIndex = 15;
            // 
            // product_currentPriceLabel
            // 
            product_currentPriceLabel.AutoSize = true;
            product_currentPriceLabel.Location = new System.Drawing.Point(359, 278);
            product_currentPriceLabel.Name = "product_currentPriceLabel";
            product_currentPriceLabel.Size = new System.Drawing.Size(145, 17);
            product_currentPriceLabel.TabIndex = 16;
            product_currentPriceLabel.Text = "product current Price:";
            // 
            // product_currentPriceTextBox
            // 
            this.product_currentPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_currentPrice", true));
            this.product_currentPriceTextBox.Location = new System.Drawing.Point(511, 275);
            this.product_currentPriceTextBox.Name = "product_currentPriceTextBox";
            this.product_currentPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_currentPriceTextBox.TabIndex = 17;
            // 
            // product_descriptionLabel
            // 
            product_descriptionLabel.AutoSize = true;
            product_descriptionLabel.Location = new System.Drawing.Point(359, 306);
            product_descriptionLabel.Name = "product_descriptionLabel";
            product_descriptionLabel.Size = new System.Drawing.Size(133, 17);
            product_descriptionLabel.TabIndex = 18;
            product_descriptionLabel.Text = "product description:";
            // 
            // product_descriptionTextBox
            // 
            this.product_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_description", true));
            this.product_descriptionTextBox.Location = new System.Drawing.Point(511, 303);
            this.product_descriptionTextBox.Name = "product_descriptionTextBox";
            this.product_descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_descriptionTextBox.TabIndex = 19;
            // 
            // product_statusLabel
            // 
            product_statusLabel.AutoSize = true;
            product_statusLabel.Location = new System.Drawing.Point(359, 334);
            product_statusLabel.Name = "product_statusLabel";
            product_statusLabel.Size = new System.Drawing.Size(102, 17);
            product_statusLabel.TabIndex = 20;
            product_statusLabel.Text = "product status:";
            // 
            // product_statusTextBox
            // 
            this.product_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_status", true));
            this.product_statusTextBox.Location = new System.Drawing.Point(511, 331);
            this.product_statusTextBox.Name = "product_statusTextBox";
            this.product_statusTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_statusTextBox.TabIndex = 21;
            // 
            // product_createdAtLabel
            // 
            product_createdAtLabel.AutoSize = true;
            product_createdAtLabel.Location = new System.Drawing.Point(359, 363);
            product_createdAtLabel.Name = "product_createdAtLabel";
            product_createdAtLabel.Size = new System.Drawing.Size(129, 17);
            product_createdAtLabel.TabIndex = 22;
            product_createdAtLabel.Text = "product created At:";
            // 
            // product_createdAtDateTimePicker
            // 
            this.product_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_createdAt", true));
            this.product_createdAtDateTimePicker.Location = new System.Drawing.Point(511, 359);
            this.product_createdAtDateTimePicker.Name = "product_createdAtDateTimePicker";
            this.product_createdAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.product_createdAtDateTimePicker.TabIndex = 23;
            // 
            // product_createdByLabel
            // 
            product_createdByLabel.AutoSize = true;
            product_createdByLabel.Location = new System.Drawing.Point(359, 390);
            product_createdByLabel.Name = "product_createdByLabel";
            product_createdByLabel.Size = new System.Drawing.Size(132, 17);
            product_createdByLabel.TabIndex = 24;
            product_createdByLabel.Text = "product created By:";
            // 
            // product_createdByTextBox
            // 
            this.product_createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_createdBy", true));
            this.product_createdByTextBox.Location = new System.Drawing.Point(511, 387);
            this.product_createdByTextBox.Name = "product_createdByTextBox";
            this.product_createdByTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_createdByTextBox.TabIndex = 25;
            // 
            // product_updatedAtLabel
            // 
            product_updatedAtLabel.AutoSize = true;
            product_updatedAtLabel.Location = new System.Drawing.Point(359, 419);
            product_updatedAtLabel.Name = "product_updatedAtLabel";
            product_updatedAtLabel.Size = new System.Drawing.Size(133, 17);
            product_updatedAtLabel.TabIndex = 26;
            product_updatedAtLabel.Text = "product updated At:";
            // 
            // product_updatedAtDateTimePicker
            // 
            this.product_updatedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "product_updatedAt", true));
            this.product_updatedAtDateTimePicker.Location = new System.Drawing.Point(511, 415);
            this.product_updatedAtDateTimePicker.Name = "product_updatedAtDateTimePicker";
            this.product_updatedAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.product_updatedAtDateTimePicker.TabIndex = 27;
            // 
            // product_updateByLabel
            // 
            product_updateByLabel.AutoSize = true;
            product_updateByLabel.Location = new System.Drawing.Point(359, 446);
            product_updateByLabel.Name = "product_updateByLabel";
            product_updateByLabel.Size = new System.Drawing.Size(128, 17);
            product_updateByLabel.TabIndex = 28;
            product_updateByLabel.Text = "product update By:";
            // 
            // product_updateByTextBox
            // 
            this.product_updateByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_updateBy", true));
            this.product_updateByTextBox.Location = new System.Drawing.Point(511, 443);
            this.product_updateByTextBox.Name = "product_updateByTextBox";
            this.product_updateByTextBox.Size = new System.Drawing.Size(200, 22);
            this.product_updateByTextBox.TabIndex = 29;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
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
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Perfume_StoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
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
    }
}