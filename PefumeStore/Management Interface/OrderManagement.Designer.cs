namespace PefumeStore.Management_Interface
{
    partial class OrderManagement
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
            System.Windows.Forms.Label order_idLabel;
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label order_paymentStatusLabel;
            System.Windows.Forms.Label order_handledByLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label order_paymentMethodLabel;
            System.Windows.Forms.Label order_totalCostLabel;
            System.Windows.Forms.Label order_receiverNameLabel;
            System.Windows.Forms.Label order_receiverAddressLabel;
            System.Windows.Forms.Label order_receiverPhoneLabel;
            System.Windows.Forms.Label order_receiverEmailLabel;
            System.Windows.Forms.Label deliveryMethod_idLabel;
            System.Windows.Forms.Label order_deliveryStatusLabel;
            System.Windows.Forms.Label order_createdAtLabel;
            System.Windows.Forms.Label order_updatedAtLabel;
            System.Windows.Forms.Label order_deliveredAtLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.order_idTextBox = new System.Windows.Forms.TextBox();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.order_paymentStatusTextBox = new System.Windows.Forms.TextBox();
            this.order_handledByTextBox = new System.Windows.Forms.TextBox();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.order_paymentMethodTextBox = new System.Windows.Forms.TextBox();
            this.order_totalCostTextBox = new System.Windows.Forms.TextBox();
            this.order_receiverNameTextBox = new System.Windows.Forms.TextBox();
            this.order_receiverAddressTextBox = new System.Windows.Forms.TextBox();
            this.order_receiverPhoneTextBox = new System.Windows.Forms.TextBox();
            this.order_receiverEmailTextBox = new System.Windows.Forms.TextBox();
            this.deliveryMethod_idTextBox = new System.Windows.Forms.TextBox();
            this.order_deliveryStatusTextBox = new System.Windows.Forms.TextBox();
            this.order_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_updatedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_deliveredAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            order_idLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            order_paymentStatusLabel = new System.Windows.Forms.Label();
            order_handledByLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            order_paymentMethodLabel = new System.Windows.Forms.Label();
            order_totalCostLabel = new System.Windows.Forms.Label();
            order_receiverNameLabel = new System.Windows.Forms.Label();
            order_receiverAddressLabel = new System.Windows.Forms.Label();
            order_receiverPhoneLabel = new System.Windows.Forms.Label();
            order_receiverEmailLabel = new System.Windows.Forms.Label();
            deliveryMethod_idLabel = new System.Windows.Forms.Label();
            order_deliveryStatusLabel = new System.Windows.Forms.Label();
            order_createdAtLabel = new System.Windows.Forms.Label();
            order_updatedAtLabel = new System.Windows.Forms.Label();
            order_deliveredAtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // order_idLabel
            // 
            order_idLabel.AutoSize = true;
            order_idLabel.Location = new System.Drawing.Point(581, 80);
            order_idLabel.Name = "order_idLabel";
            order_idLabel.Size = new System.Drawing.Size(61, 17);
            order_idLabel.TabIndex = 35;
            order_idLabel.Text = "order id:";
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(581, 108);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(55, 17);
            user_idLabel.TabIndex = 37;
            user_idLabel.Text = "user id:";
            // 
            // order_paymentStatusLabel
            // 
            order_paymentStatusLabel.AutoSize = true;
            order_paymentStatusLabel.Location = new System.Drawing.Point(581, 135);
            order_paymentStatusLabel.Name = "order_paymentStatusLabel";
            order_paymentStatusLabel.Size = new System.Drawing.Size(148, 17);
            order_paymentStatusLabel.TabIndex = 39;
            order_paymentStatusLabel.Text = "order payment Status:";
            // 
            // order_handledByLabel
            // 
            order_handledByLabel.AutoSize = true;
            order_handledByLabel.Location = new System.Drawing.Point(581, 164);
            order_handledByLabel.Name = "order_handledByLabel";
            order_handledByLabel.Size = new System.Drawing.Size(121, 17);
            order_handledByLabel.TabIndex = 41;
            order_handledByLabel.Text = "order handled By:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(581, 192);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(88, 17);
            order_statusLabel.TabIndex = 43;
            order_statusLabel.Text = "order status:";
            // 
            // order_paymentMethodLabel
            // 
            order_paymentMethodLabel.AutoSize = true;
            order_paymentMethodLabel.Location = new System.Drawing.Point(581, 220);
            order_paymentMethodLabel.Name = "order_paymentMethodLabel";
            order_paymentMethodLabel.Size = new System.Drawing.Size(155, 17);
            order_paymentMethodLabel.TabIndex = 45;
            order_paymentMethodLabel.Text = "order payment Method:";
            // 
            // order_totalCostLabel
            // 
            order_totalCostLabel.AutoSize = true;
            order_totalCostLabel.Location = new System.Drawing.Point(581, 249);
            order_totalCostLabel.Name = "order_totalCostLabel";
            order_totalCostLabel.Size = new System.Drawing.Size(109, 17);
            order_totalCostLabel.TabIndex = 47;
            order_totalCostLabel.Text = "order total Cost:";
            // 
            // order_receiverNameLabel
            // 
            order_receiverNameLabel.AutoSize = true;
            order_receiverNameLabel.Location = new System.Drawing.Point(581, 276);
            order_receiverNameLabel.Name = "order_receiverNameLabel";
            order_receiverNameLabel.Size = new System.Drawing.Size(142, 17);
            order_receiverNameLabel.TabIndex = 49;
            order_receiverNameLabel.Text = "order receiver Name:";
            // 
            // order_receiverAddressLabel
            // 
            order_receiverAddressLabel.AutoSize = true;
            order_receiverAddressLabel.Location = new System.Drawing.Point(581, 304);
            order_receiverAddressLabel.Name = "order_receiverAddressLabel";
            order_receiverAddressLabel.Size = new System.Drawing.Size(157, 17);
            order_receiverAddressLabel.TabIndex = 51;
            order_receiverAddressLabel.Text = "order receiver Address:";
            // 
            // order_receiverPhoneLabel
            // 
            order_receiverPhoneLabel.AutoSize = true;
            order_receiverPhoneLabel.Location = new System.Drawing.Point(581, 332);
            order_receiverPhoneLabel.Name = "order_receiverPhoneLabel";
            order_receiverPhoneLabel.Size = new System.Drawing.Size(146, 17);
            order_receiverPhoneLabel.TabIndex = 53;
            order_receiverPhoneLabel.Text = "order receiver Phone:";
            // 
            // order_receiverEmailLabel
            // 
            order_receiverEmailLabel.AutoSize = true;
            order_receiverEmailLabel.Location = new System.Drawing.Point(581, 359);
            order_receiverEmailLabel.Name = "order_receiverEmailLabel";
            order_receiverEmailLabel.Size = new System.Drawing.Size(139, 17);
            order_receiverEmailLabel.TabIndex = 55;
            order_receiverEmailLabel.Text = "order receiver Email:";
            // 
            // deliveryMethod_idLabel
            // 
            deliveryMethod_idLabel.AutoSize = true;
            deliveryMethod_idLabel.Location = new System.Drawing.Point(581, 388);
            deliveryMethod_idLabel.Name = "deliveryMethod_idLabel";
            deliveryMethod_idLabel.Size = new System.Drawing.Size(127, 17);
            deliveryMethod_idLabel.TabIndex = 57;
            deliveryMethod_idLabel.Text = "delivery Method id:";
            // 
            // order_deliveryStatusLabel
            // 
            order_deliveryStatusLabel.AutoSize = true;
            order_deliveryStatusLabel.Location = new System.Drawing.Point(581, 416);
            order_deliveryStatusLabel.Name = "order_deliveryStatusLabel";
            order_deliveryStatusLabel.Size = new System.Drawing.Size(143, 17);
            order_deliveryStatusLabel.TabIndex = 59;
            order_deliveryStatusLabel.Text = "order delivery Status:";
            // 
            // order_createdAtLabel
            // 
            order_createdAtLabel.AutoSize = true;
            order_createdAtLabel.Location = new System.Drawing.Point(581, 446);
            order_createdAtLabel.Name = "order_createdAtLabel";
            order_createdAtLabel.Size = new System.Drawing.Size(115, 17);
            order_createdAtLabel.TabIndex = 61;
            order_createdAtLabel.Text = "order created At:";
            // 
            // order_updatedAtLabel
            // 
            order_updatedAtLabel.AutoSize = true;
            order_updatedAtLabel.Location = new System.Drawing.Point(581, 473);
            order_updatedAtLabel.Name = "order_updatedAtLabel";
            order_updatedAtLabel.Size = new System.Drawing.Size(119, 17);
            order_updatedAtLabel.TabIndex = 63;
            order_updatedAtLabel.Text = "order updated At:";
            // 
            // order_deliveredAtLabel
            // 
            order_deliveredAtLabel.AutoSize = true;
            order_deliveredAtLabel.Location = new System.Drawing.Point(581, 501);
            order_deliveredAtLabel.Name = "order_deliveredAtLabel";
            order_deliveredAtLabel.Size = new System.Drawing.Size(125, 17);
            order_deliveredAtLabel.TabIndex = 65;
            order_deliveredAtLabel.Text = "order delivered At:";
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.paymentMethodTableAdapter = null;
            this.tableAdapterManager.productImgTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ordersDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.ordersDataGridView.Location = new System.Drawing.Point(15, 76);
            this.ordersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(500, 423);
            this.ordersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "order id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "user id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "order_paymentStatus";
            this.dataGridViewTextBoxColumn3.HeaderText = "order paymentStatus";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "order_handledBy";
            this.dataGridViewTextBoxColumn4.HeaderText = "order handledBy";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "order_status";
            this.dataGridViewTextBoxColumn5.HeaderText = "order status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "order_paymentMethod";
            this.dataGridViewTextBoxColumn6.HeaderText = "order paymentMethod";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "order_totalCost";
            this.dataGridViewTextBoxColumn7.HeaderText = "order totalCost";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "order_receiverName";
            this.dataGridViewTextBoxColumn8.HeaderText = "order receiverName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "order_receiverAddress";
            this.dataGridViewTextBoxColumn9.HeaderText = "order receiverAddress";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "order_receiverPhone";
            this.dataGridViewTextBoxColumn10.HeaderText = "order receiverPhone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "order_receiverEmail";
            this.dataGridViewTextBoxColumn11.HeaderText = "order receiverEmail";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "deliveryMethod_id";
            this.dataGridViewTextBoxColumn12.HeaderText = "deliveryMethod id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "order_deliveryStatus";
            this.dataGridViewTextBoxColumn13.HeaderText = "order deliveryStatus";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "order_createdAt";
            this.dataGridViewTextBoxColumn14.HeaderText = "order createdAt";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "order_updatedAt";
            this.dataGridViewTextBoxColumn15.HeaderText = "order updatedAt";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "order_deliveredAt";
            this.dataGridViewTextBoxColumn16.HeaderText = "order deliveredAt";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(15, 15);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Order Management";
            // 
            // order_idTextBox
            // 
            this.order_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_id", true));
            this.order_idTextBox.Enabled = false;
            this.order_idTextBox.Location = new System.Drawing.Point(745, 78);
            this.order_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_idTextBox.Name = "order_idTextBox";
            this.order_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_idTextBox.TabIndex = 36;
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "user_id", true));
            this.user_idTextBox.Location = new System.Drawing.Point(745, 105);
            this.user_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.user_idTextBox.TabIndex = 38;
            // 
            // order_paymentStatusTextBox
            // 
            this.order_paymentStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_paymentStatus", true));
            this.order_paymentStatusTextBox.Location = new System.Drawing.Point(745, 133);
            this.order_paymentStatusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_paymentStatusTextBox.Name = "order_paymentStatusTextBox";
            this.order_paymentStatusTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_paymentStatusTextBox.TabIndex = 40;
            // 
            // order_handledByTextBox
            // 
            this.order_handledByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_handledBy", true));
            this.order_handledByTextBox.Location = new System.Drawing.Point(745, 161);
            this.order_handledByTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_handledByTextBox.Name = "order_handledByTextBox";
            this.order_handledByTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_handledByTextBox.TabIndex = 42;
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status", true));
            this.order_statusTextBox.Location = new System.Drawing.Point(745, 190);
            this.order_statusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_statusTextBox.TabIndex = 44;
            // 
            // order_paymentMethodTextBox
            // 
            this.order_paymentMethodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_paymentMethod", true));
            this.order_paymentMethodTextBox.Location = new System.Drawing.Point(745, 217);
            this.order_paymentMethodTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_paymentMethodTextBox.Name = "order_paymentMethodTextBox";
            this.order_paymentMethodTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_paymentMethodTextBox.TabIndex = 46;
            // 
            // order_totalCostTextBox
            // 
            this.order_totalCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_totalCost", true));
            this.order_totalCostTextBox.Location = new System.Drawing.Point(745, 245);
            this.order_totalCostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_totalCostTextBox.Name = "order_totalCostTextBox";
            this.order_totalCostTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_totalCostTextBox.TabIndex = 48;
            // 
            // order_receiverNameTextBox
            // 
            this.order_receiverNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_receiverName", true));
            this.order_receiverNameTextBox.Location = new System.Drawing.Point(745, 273);
            this.order_receiverNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_receiverNameTextBox.Name = "order_receiverNameTextBox";
            this.order_receiverNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_receiverNameTextBox.TabIndex = 50;
            // 
            // order_receiverAddressTextBox
            // 
            this.order_receiverAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_receiverAddress", true));
            this.order_receiverAddressTextBox.Location = new System.Drawing.Point(745, 302);
            this.order_receiverAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_receiverAddressTextBox.Name = "order_receiverAddressTextBox";
            this.order_receiverAddressTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_receiverAddressTextBox.TabIndex = 52;
            // 
            // order_receiverPhoneTextBox
            // 
            this.order_receiverPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_receiverPhone", true));
            this.order_receiverPhoneTextBox.Location = new System.Drawing.Point(745, 329);
            this.order_receiverPhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_receiverPhoneTextBox.Name = "order_receiverPhoneTextBox";
            this.order_receiverPhoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_receiverPhoneTextBox.TabIndex = 54;
            // 
            // order_receiverEmailTextBox
            // 
            this.order_receiverEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_receiverEmail", true));
            this.order_receiverEmailTextBox.Location = new System.Drawing.Point(745, 357);
            this.order_receiverEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_receiverEmailTextBox.Name = "order_receiverEmailTextBox";
            this.order_receiverEmailTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_receiverEmailTextBox.TabIndex = 56;
            // 
            // deliveryMethod_idTextBox
            // 
            this.deliveryMethod_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "deliveryMethod_id", true));
            this.deliveryMethod_idTextBox.Location = new System.Drawing.Point(745, 385);
            this.deliveryMethod_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deliveryMethod_idTextBox.Name = "deliveryMethod_idTextBox";
            this.deliveryMethod_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.deliveryMethod_idTextBox.TabIndex = 58;
            // 
            // order_deliveryStatusTextBox
            // 
            this.order_deliveryStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_deliveryStatus", true));
            this.order_deliveryStatusTextBox.Location = new System.Drawing.Point(745, 414);
            this.order_deliveryStatusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_deliveryStatusTextBox.Name = "order_deliveryStatusTextBox";
            this.order_deliveryStatusTextBox.Size = new System.Drawing.Size(200, 22);
            this.order_deliveryStatusTextBox.TabIndex = 60;
            // 
            // order_createdAtDateTimePicker
            // 
            this.order_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_createdAt", true));
            this.order_createdAtDateTimePicker.Location = new System.Drawing.Point(745, 441);
            this.order_createdAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_createdAtDateTimePicker.Name = "order_createdAtDateTimePicker";
            this.order_createdAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.order_createdAtDateTimePicker.TabIndex = 62;
            // 
            // order_updatedAtDateTimePicker
            // 
            this.order_updatedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_updatedAt", true));
            this.order_updatedAtDateTimePicker.Location = new System.Drawing.Point(745, 469);
            this.order_updatedAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_updatedAtDateTimePicker.Name = "order_updatedAtDateTimePicker";
            this.order_updatedAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.order_updatedAtDateTimePicker.TabIndex = 64;
            // 
            // order_deliveredAtDateTimePicker
            // 
            this.order_deliveredAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_deliveredAt", true));
            this.order_deliveredAtDateTimePicker.Location = new System.Drawing.Point(745, 497);
            this.order_deliveredAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_deliveredAtDateTimePicker.Name = "order_deliveredAtDateTimePicker";
            this.order_deliveredAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.order_deliveredAtDateTimePicker.TabIndex = 66;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(668, 565);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 34);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.White;
            this.btnPre.Location = new System.Drawing.Point(565, 565);
            this.btnPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(93, 34);
            this.btnPre.TabIndex = 68;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(464, 565);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 34);
            this.btnNext.TabIndex = 69;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(363, 565);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 34);
            this.btnDel.TabIndex = 70;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(253, 565);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 34);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 682);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(order_idLabel);
            this.Controls.Add(this.order_idTextBox);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Controls.Add(order_paymentStatusLabel);
            this.Controls.Add(this.order_paymentStatusTextBox);
            this.Controls.Add(order_handledByLabel);
            this.Controls.Add(this.order_handledByTextBox);
            this.Controls.Add(order_statusLabel);
            this.Controls.Add(this.order_statusTextBox);
            this.Controls.Add(order_paymentMethodLabel);
            this.Controls.Add(this.order_paymentMethodTextBox);
            this.Controls.Add(order_totalCostLabel);
            this.Controls.Add(this.order_totalCostTextBox);
            this.Controls.Add(order_receiverNameLabel);
            this.Controls.Add(this.order_receiverNameTextBox);
            this.Controls.Add(order_receiverAddressLabel);
            this.Controls.Add(this.order_receiverAddressTextBox);
            this.Controls.Add(order_receiverPhoneLabel);
            this.Controls.Add(this.order_receiverPhoneTextBox);
            this.Controls.Add(order_receiverEmailLabel);
            this.Controls.Add(this.order_receiverEmailTextBox);
            this.Controls.Add(deliveryMethod_idLabel);
            this.Controls.Add(this.deliveryMethod_idTextBox);
            this.Controls.Add(order_deliveryStatusLabel);
            this.Controls.Add(this.order_deliveryStatusTextBox);
            this.Controls.Add(order_createdAtLabel);
            this.Controls.Add(this.order_createdAtDateTimePicker);
            this.Controls.Add(order_updatedAtLabel);
            this.Controls.Add(this.order_updatedAtDateTimePicker);
            this.Controls.Add(order_deliveredAtLabel);
            this.Controls.Add(this.order_deliveredAtDateTimePicker);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordersDataGridView);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management | Perfume Store Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderManagement_FormClosed);
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Perfume_StoreDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox order_idTextBox;
        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.TextBox order_paymentStatusTextBox;
        private System.Windows.Forms.TextBox order_handledByTextBox;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.TextBox order_paymentMethodTextBox;
        private System.Windows.Forms.TextBox order_totalCostTextBox;
        private System.Windows.Forms.TextBox order_receiverNameTextBox;
        private System.Windows.Forms.TextBox order_receiverAddressTextBox;
        private System.Windows.Forms.TextBox order_receiverPhoneTextBox;
        private System.Windows.Forms.TextBox order_receiverEmailTextBox;
        private System.Windows.Forms.TextBox deliveryMethod_idTextBox;
        private System.Windows.Forms.TextBox order_deliveryStatusTextBox;
        private System.Windows.Forms.DateTimePicker order_createdAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker order_updatedAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker order_deliveredAtDateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}