namespace PefumeStore.Management_Interface
{
    partial class UserRoleManagement
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
            System.Windows.Forms.Label role_idLabel;
            System.Windows.Forms.Label role_nameLabel;
            System.Windows.Forms.Label role_statusLabel;
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.user_roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_roleTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.user_roleTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.user_roleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_idTextBox = new System.Windows.Forms.TextBox();
            this.role_nameTextBox = new System.Windows.Forms.TextBox();
            this.role_statusTextBox = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            role_idLabel = new System.Windows.Forms.Label();
            role_nameLabel = new System.Windows.Forms.Label();
            role_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // role_idLabel
            // 
            role_idLabel.AutoSize = true;
            role_idLabel.Location = new System.Drawing.Point(410, 91);
            role_idLabel.Name = "role_idLabel";
            role_idLabel.Size = new System.Drawing.Size(51, 17);
            role_idLabel.TabIndex = 2;
            role_idLabel.Text = "role id:";
            // 
            // role_nameLabel
            // 
            role_nameLabel.AutoSize = true;
            role_nameLabel.Location = new System.Drawing.Point(410, 119);
            role_nameLabel.Name = "role_nameLabel";
            role_nameLabel.Size = new System.Drawing.Size(75, 17);
            role_nameLabel.TabIndex = 4;
            role_nameLabel.Text = "role name:";
            // 
            // role_statusLabel
            // 
            role_statusLabel.AutoSize = true;
            role_statusLabel.Location = new System.Drawing.Point(410, 147);
            role_statusLabel.Name = "role_statusLabel";
            role_statusLabel.Size = new System.Drawing.Size(78, 17);
            role_statusLabel.TabIndex = 6;
            role_statusLabel.Text = "role status:";
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_roleBindingSource
            // 
            this.user_roleBindingSource.DataMember = "user_role";
            this.user_roleBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // user_roleTableAdapter
            // 
            this.user_roleTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.user_roleTableAdapter = this.user_roleTableAdapter;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // user_roleDataGridView
            // 
            this.user_roleDataGridView.AutoGenerateColumns = false;
            this.user_roleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_roleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.user_roleDataGridView.DataSource = this.user_roleBindingSource;
            this.user_roleDataGridView.Location = new System.Drawing.Point(37, 81);
            this.user_roleDataGridView.Name = "user_roleDataGridView";
            this.user_roleDataGridView.RowTemplate.Height = 24;
            this.user_roleDataGridView.Size = new System.Drawing.Size(300, 220);
            this.user_roleDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "role_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "role_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "role_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "role_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "role_status";
            this.dataGridViewTextBoxColumn3.HeaderText = "role_status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // role_idTextBox
            // 
            this.role_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_roleBindingSource, "role_id", true));
            this.role_idTextBox.Location = new System.Drawing.Point(494, 88);
            this.role_idTextBox.Name = "role_idTextBox";
            this.role_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_idTextBox.TabIndex = 3;
            // 
            // role_nameTextBox
            // 
            this.role_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_roleBindingSource, "role_name", true));
            this.role_nameTextBox.Location = new System.Drawing.Point(494, 116);
            this.role_nameTextBox.Name = "role_nameTextBox";
            this.role_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_nameTextBox.TabIndex = 5;
            // 
            // role_statusTextBox
            // 
            this.role_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_roleBindingSource, "role_status", true));
            this.role_statusTextBox.Location = new System.Drawing.Point(494, 144);
            this.role_statusTextBox.Name = "role_statusTextBox";
            this.role_statusTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_statusTextBox.TabIndex = 7;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(13, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "User Role Management";
            // 
            // UserRoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(role_idLabel);
            this.Controls.Add(this.role_idTextBox);
            this.Controls.Add(role_nameLabel);
            this.Controls.Add(this.role_nameTextBox);
            this.Controls.Add(role_statusLabel);
            this.Controls.Add(this.role_statusTextBox);
            this.Controls.Add(this.user_roleDataGridView);
            this.Name = "UserRoleManagement";
            this.Text = "UserRoleManagement";
            this.Load += new System.EventHandler(this.UserRoleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource user_roleBindingSource;
        private Perfume_StoreDataSetTableAdapters.user_roleTableAdapter user_roleTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView user_roleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox role_idTextBox;
        private System.Windows.Forms.TextBox role_nameTextBox;
        private System.Windows.Forms.TextBox role_statusTextBox;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
    }
}