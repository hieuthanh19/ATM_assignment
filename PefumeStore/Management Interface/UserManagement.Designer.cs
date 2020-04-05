namespace PefumeStore.Management_Interface
{
    partial class UserManagement
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
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label user_usernameLabel;
            System.Windows.Forms.Label user_passwordLabel;
            System.Windows.Forms.Label user_roleIdLabel;
            System.Windows.Forms.Label user_fullNameLabel;
            System.Windows.Forms.Label user_addressLabel;
            System.Windows.Forms.Label user_phoneLabel;
            System.Windows.Forms.Label user_emailLabel;
            System.Windows.Forms.Label user_avartarLabel;
            System.Windows.Forms.Label user_createdAtLabel;
            System.Windows.Forms.Label user_statusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.user_usernameTextBox = new System.Windows.Forms.TextBox();
            this.user_passwordTextBox = new System.Windows.Forms.TextBox();
            this.user_roleIdTextBox = new System.Windows.Forms.TextBox();
            this.user_fullNameTextBox = new System.Windows.Forms.TextBox();
            this.user_addressTextBox = new System.Windows.Forms.TextBox();
            this.user_phoneTextBox = new System.Windows.Forms.TextBox();
            this.user_emailTextBox = new System.Windows.Forms.TextBox();
            this.user_avartarTextBox = new System.Windows.Forms.TextBox();
            this.user_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.user_statusTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            user_idLabel = new System.Windows.Forms.Label();
            user_usernameLabel = new System.Windows.Forms.Label();
            user_passwordLabel = new System.Windows.Forms.Label();
            user_roleIdLabel = new System.Windows.Forms.Label();
            user_fullNameLabel = new System.Windows.Forms.Label();
            user_addressLabel = new System.Windows.Forms.Label();
            user_phoneLabel = new System.Windows.Forms.Label();
            user_emailLabel = new System.Windows.Forms.Label();
            user_avartarLabel = new System.Windows.Forms.Label();
            user_createdAtLabel = new System.Windows.Forms.Label();
            user_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(405, 68);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(55, 17);
            user_idLabel.TabIndex = 25;
            user_idLabel.Text = "user id:";
            // 
            // user_usernameLabel
            // 
            user_usernameLabel.AutoSize = true;
            user_usernameLabel.Location = new System.Drawing.Point(405, 96);
            user_usernameLabel.Name = "user_usernameLabel";
            user_usernameLabel.Size = new System.Drawing.Size(107, 17);
            user_usernameLabel.TabIndex = 27;
            user_usernameLabel.Text = "user username:";
            // 
            // user_passwordLabel
            // 
            user_passwordLabel.AutoSize = true;
            user_passwordLabel.Location = new System.Drawing.Point(405, 124);
            user_passwordLabel.Name = "user_passwordLabel";
            user_passwordLabel.Size = new System.Drawing.Size(104, 17);
            user_passwordLabel.TabIndex = 29;
            user_passwordLabel.Text = "user password:";
            // 
            // user_roleIdLabel
            // 
            user_roleIdLabel.AutoSize = true;
            user_roleIdLabel.Location = new System.Drawing.Point(405, 153);
            user_roleIdLabel.Name = "user_roleIdLabel";
            user_roleIdLabel.Size = new System.Drawing.Size(83, 17);
            user_roleIdLabel.TabIndex = 31;
            user_roleIdLabel.Text = "user role Id:";
            // 
            // user_fullNameLabel
            // 
            user_fullNameLabel.AutoSize = true;
            user_fullNameLabel.Location = new System.Drawing.Point(405, 180);
            user_fullNameLabel.Name = "user_fullNameLabel";
            user_fullNameLabel.Size = new System.Drawing.Size(103, 17);
            user_fullNameLabel.TabIndex = 33;
            user_fullNameLabel.Text = "user full Name:";
            // 
            // user_addressLabel
            // 
            user_addressLabel.AutoSize = true;
            user_addressLabel.Location = new System.Drawing.Point(405, 208);
            user_addressLabel.Name = "user_addressLabel";
            user_addressLabel.Size = new System.Drawing.Size(95, 17);
            user_addressLabel.TabIndex = 35;
            user_addressLabel.Text = "user address:";
            // 
            // user_phoneLabel
            // 
            user_phoneLabel.AutoSize = true;
            user_phoneLabel.Location = new System.Drawing.Point(405, 236);
            user_phoneLabel.Name = "user_phoneLabel";
            user_phoneLabel.Size = new System.Drawing.Size(84, 17);
            user_phoneLabel.TabIndex = 37;
            user_phoneLabel.Text = "user phone:";
            // 
            // user_emailLabel
            // 
            user_emailLabel.AutoSize = true;
            user_emailLabel.Location = new System.Drawing.Point(405, 263);
            user_emailLabel.Name = "user_emailLabel";
            user_emailLabel.Size = new System.Drawing.Size(77, 17);
            user_emailLabel.TabIndex = 39;
            user_emailLabel.Text = "user email:";
            // 
            // user_avartarLabel
            // 
            user_avartarLabel.AutoSize = true;
            user_avartarLabel.Location = new System.Drawing.Point(405, 292);
            user_avartarLabel.Name = "user_avartarLabel";
            user_avartarLabel.Size = new System.Drawing.Size(89, 17);
            user_avartarLabel.TabIndex = 41;
            user_avartarLabel.Text = "user avartar:";
            // 
            // user_createdAtLabel
            // 
            user_createdAtLabel.AutoSize = true;
            user_createdAtLabel.Location = new System.Drawing.Point(405, 321);
            user_createdAtLabel.Name = "user_createdAtLabel";
            user_createdAtLabel.Size = new System.Drawing.Size(109, 17);
            user_createdAtLabel.TabIndex = 43;
            user_createdAtLabel.Text = "user created At:";
            // 
            // user_statusLabel
            // 
            user_statusLabel.AutoSize = true;
            user_statusLabel.Location = new System.Drawing.Point(405, 348);
            user_statusLabel.Name = "user_statusLabel";
            user_statusLabel.Size = new System.Drawing.Size(82, 17);
            user_statusLabel.TabIndex = 45;
            user_statusLabel.Text = "user status:";
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn11});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.usersDataGridView.Location = new System.Drawing.Point(48, 68);
            this.usersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.usersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "user id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_username";
            this.dataGridViewTextBoxColumn2.HeaderText = "user username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "user_password";
            this.dataGridViewTextBoxColumn3.HeaderText = "user password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "user_roleId";
            this.dataGridViewTextBoxColumn4.HeaderText = "user roleId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "user_fullName";
            this.dataGridViewTextBoxColumn5.HeaderText = "user fullname";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "user_address";
            this.dataGridViewTextBoxColumn6.HeaderText = "user address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "user_phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "user phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "user_email";
            this.dataGridViewTextBoxColumn8.HeaderText = "user email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "user_avartar";
            this.dataGridViewTextBoxColumn9.HeaderText = "user avartar";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "user_createdAt";
            this.dataGridViewTextBoxColumn10.HeaderText = "user created at";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "user_status";
            this.dataGridViewTextBoxColumn11.HeaderText = "user status";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(15, 15);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 25;
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
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "User Management";
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_id", true));
            this.user_idTextBox.Enabled = false;
            this.user_idTextBox.Location = new System.Drawing.Point(520, 65);
            this.user_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_idTextBox.TabIndex = 26;
            // 
            // user_usernameTextBox
            // 
            this.user_usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_username", true));
            this.user_usernameTextBox.Enabled = false;
            this.user_usernameTextBox.Location = new System.Drawing.Point(520, 94);
            this.user_usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_usernameTextBox.Name = "user_usernameTextBox";
            this.user_usernameTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_usernameTextBox.TabIndex = 28;
            // 
            // user_passwordTextBox
            // 
            this.user_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_password", true));
            this.user_passwordTextBox.Enabled = false;
            this.user_passwordTextBox.Location = new System.Drawing.Point(520, 121);
            this.user_passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_passwordTextBox.Name = "user_passwordTextBox";
            this.user_passwordTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_passwordTextBox.TabIndex = 30;
            // 
            // user_roleIdTextBox
            // 
            this.user_roleIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_roleId", true));
            this.user_roleIdTextBox.Enabled = false;
            this.user_roleIdTextBox.Location = new System.Drawing.Point(520, 149);
            this.user_roleIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_roleIdTextBox.Name = "user_roleIdTextBox";
            this.user_roleIdTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_roleIdTextBox.TabIndex = 32;
            // 
            // user_fullNameTextBox
            // 
            this.user_fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_fullName", true));
            this.user_fullNameTextBox.Location = new System.Drawing.Point(520, 177);
            this.user_fullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_fullNameTextBox.Name = "user_fullNameTextBox";
            this.user_fullNameTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_fullNameTextBox.TabIndex = 34;
            // 
            // user_addressTextBox
            // 
            this.user_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_address", true));
            this.user_addressTextBox.Location = new System.Drawing.Point(520, 206);
            this.user_addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_addressTextBox.Name = "user_addressTextBox";
            this.user_addressTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_addressTextBox.TabIndex = 36;
            // 
            // user_phoneTextBox
            // 
            this.user_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_phone", true));
            this.user_phoneTextBox.Location = new System.Drawing.Point(520, 233);
            this.user_phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_phoneTextBox.Name = "user_phoneTextBox";
            this.user_phoneTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_phoneTextBox.TabIndex = 38;
            // 
            // user_emailTextBox
            // 
            this.user_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_email", true));
            this.user_emailTextBox.Location = new System.Drawing.Point(520, 261);
            this.user_emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_emailTextBox.Name = "user_emailTextBox";
            this.user_emailTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_emailTextBox.TabIndex = 40;
            // 
            // user_avartarTextBox
            // 
            this.user_avartarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_avartar", true));
            this.user_avartarTextBox.Location = new System.Drawing.Point(520, 289);
            this.user_avartarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_avartarTextBox.Name = "user_avartarTextBox";
            this.user_avartarTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_avartarTextBox.TabIndex = 42;
            // 
            // user_createdAtDateTimePicker
            // 
            this.user_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "user_createdAt", true));
            this.user_createdAtDateTimePicker.Location = new System.Drawing.Point(520, 318);
            this.user_createdAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_createdAtDateTimePicker.Name = "user_createdAtDateTimePicker";
            this.user_createdAtDateTimePicker.Size = new System.Drawing.Size(239, 22);
            this.user_createdAtDateTimePicker.TabIndex = 44;
            // 
            // user_statusTextBox
            // 
            this.user_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_status", true));
            this.user_statusTextBox.Location = new System.Drawing.Point(520, 345);
            this.user_statusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_statusTextBox.Name = "user_statusTextBox";
            this.user_statusTextBox.Size = new System.Drawing.Size(239, 22);
            this.user_statusTextBox.TabIndex = 46;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(509, 409);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 34);
            this.btnSave.TabIndex = 77;
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
            this.btnPre.Location = new System.Drawing.Point(408, 409);
            this.btnPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(93, 34);
            this.btnPre.TabIndex = 78;
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
            this.btnNext.Location = new System.Drawing.Point(307, 409);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 34);
            this.btnNext.TabIndex = 79;
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
            this.btnDel.Location = new System.Drawing.Point(204, 409);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 34);
            this.btnDel.TabIndex = 80;
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
            this.btnAdd.Location = new System.Drawing.Point(95, 409);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 34);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Controls.Add(user_usernameLabel);
            this.Controls.Add(this.user_usernameTextBox);
            this.Controls.Add(user_passwordLabel);
            this.Controls.Add(this.user_passwordTextBox);
            this.Controls.Add(user_roleIdLabel);
            this.Controls.Add(this.user_roleIdTextBox);
            this.Controls.Add(user_fullNameLabel);
            this.Controls.Add(this.user_fullNameTextBox);
            this.Controls.Add(user_addressLabel);
            this.Controls.Add(this.user_addressTextBox);
            this.Controls.Add(user_phoneLabel);
            this.Controls.Add(this.user_phoneTextBox);
            this.Controls.Add(user_emailLabel);
            this.Controls.Add(this.user_emailTextBox);
            this.Controls.Add(user_avartarLabel);
            this.Controls.Add(this.user_avartarTextBox);
            this.Controls.Add(user_createdAtLabel);
            this.Controls.Add(this.user_createdAtDateTimePicker);
            this.Controls.Add(user_statusLabel);
            this.Controls.Add(this.user_statusTextBox);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersDataGridView);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management | Perfume Store Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserManagement_FormClosed);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Perfume_StoreDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.TextBox user_usernameTextBox;
        private System.Windows.Forms.TextBox user_passwordTextBox;
        private System.Windows.Forms.TextBox user_roleIdTextBox;
        private System.Windows.Forms.TextBox user_fullNameTextBox;
        private System.Windows.Forms.TextBox user_addressTextBox;
        private System.Windows.Forms.TextBox user_phoneTextBox;
        private System.Windows.Forms.TextBox user_emailTextBox;
        private System.Windows.Forms.TextBox user_avartarTextBox;
        private System.Windows.Forms.DateTimePicker user_createdAtDateTimePicker;
        private System.Windows.Forms.TextBox user_statusTextBox;
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
    }
}