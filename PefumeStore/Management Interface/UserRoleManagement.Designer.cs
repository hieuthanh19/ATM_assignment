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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoleManagement));
            System.Windows.Forms.Label role_idLabel;
            System.Windows.Forms.Label role_nameLabel;
            System.Windows.Forms.Label role_statusLabel;
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.user_roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_roleTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.user_roleTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.user_roleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.user_roleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.user_roleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_idTextBox = new System.Windows.Forms.TextBox();
            this.role_nameTextBox = new System.Windows.Forms.TextBox();
            this.role_statusTextBox = new System.Windows.Forms.TextBox();
            role_idLabel = new System.Windows.Forms.Label();
            role_nameLabel = new System.Windows.Forms.Label();
            role_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleBindingNavigator)).BeginInit();
            this.user_roleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // user_roleBindingNavigator
            // 
            this.user_roleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.user_roleBindingNavigator.BindingSource = this.user_roleBindingSource;
            this.user_roleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.user_roleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user_roleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.user_roleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.user_roleBindingNavigatorSaveItem});
            this.user_roleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.user_roleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.user_roleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.user_roleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.user_roleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.user_roleBindingNavigator.Name = "user_roleBindingNavigator";
            this.user_roleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.user_roleBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.user_roleBindingNavigator.TabIndex = 0;
            this.user_roleBindingNavigator.Text = "bindingNavigator1";
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
            // user_roleBindingNavigatorSaveItem
            // 
            this.user_roleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user_roleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_roleBindingNavigatorSaveItem.Image")));
            this.user_roleBindingNavigatorSaveItem.Name = "user_roleBindingNavigatorSaveItem";
            this.user_roleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.user_roleBindingNavigatorSaveItem.Text = "Save Data";
            this.user_roleBindingNavigatorSaveItem.Click += new System.EventHandler(this.user_roleBindingNavigatorSaveItem_Click);
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
            // role_idLabel
            // 
            role_idLabel.AutoSize = true;
            role_idLabel.Location = new System.Drawing.Point(410, 91);
            role_idLabel.Name = "role_idLabel";
            role_idLabel.Size = new System.Drawing.Size(51, 17);
            role_idLabel.TabIndex = 2;
            role_idLabel.Text = "role id:";
            // 
            // role_idTextBox
            // 
            this.role_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_roleBindingSource, "role_id", true));
            this.role_idTextBox.Location = new System.Drawing.Point(494, 88);
            this.role_idTextBox.Name = "role_idTextBox";
            this.role_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_idTextBox.TabIndex = 3;
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
            // role_nameTextBox
            // 
            this.role_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_roleBindingSource, "role_name", true));
            this.role_nameTextBox.Location = new System.Drawing.Point(494, 116);
            this.role_nameTextBox.Name = "role_nameTextBox";
            this.role_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_nameTextBox.TabIndex = 5;
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
            // role_statusTextBox
            // 
            this.role_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_roleBindingSource, "role_status", true));
            this.role_statusTextBox.Location = new System.Drawing.Point(494, 144);
            this.role_statusTextBox.Name = "role_statusTextBox";
            this.role_statusTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_statusTextBox.TabIndex = 7;
            // 
            // UserRoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(role_idLabel);
            this.Controls.Add(this.role_idTextBox);
            this.Controls.Add(role_nameLabel);
            this.Controls.Add(this.role_nameTextBox);
            this.Controls.Add(role_statusLabel);
            this.Controls.Add(this.role_statusTextBox);
            this.Controls.Add(this.user_roleDataGridView);
            this.Controls.Add(this.user_roleBindingNavigator);
            this.Name = "UserRoleManagement";
            this.Text = "UserRoleManagement";
            this.Load += new System.EventHandler(this.UserRoleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleBindingNavigator)).EndInit();
            this.user_roleBindingNavigator.ResumeLayout(false);
            this.user_roleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_roleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource user_roleBindingSource;
        private Perfume_StoreDataSetTableAdapters.user_roleTableAdapter user_roleTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user_roleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton user_roleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView user_roleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox role_idTextBox;
        private System.Windows.Forms.TextBox role_nameTextBox;
        private System.Windows.Forms.TextBox role_statusTextBox;
    }
}