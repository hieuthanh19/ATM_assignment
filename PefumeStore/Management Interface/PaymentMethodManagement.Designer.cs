namespace PefumeStore.Management_Interface
{
    partial class PaymentMethodManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethodManagement));
            System.Windows.Forms.Label payment_idLabel;
            System.Windows.Forms.Label payment_nameLabel;
            System.Windows.Forms.Label payment_descriptionLabel;
            System.Windows.Forms.Label payment_statusLabel;
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentMethodTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.paymentMethodTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.paymentMethodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.paymentMethodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paymentMethodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_idTextBox = new System.Windows.Forms.TextBox();
            this.payment_nameTextBox = new System.Windows.Forms.TextBox();
            this.payment_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.payment_statusTextBox = new System.Windows.Forms.TextBox();
            payment_idLabel = new System.Windows.Forms.Label();
            payment_nameLabel = new System.Windows.Forms.Label();
            payment_descriptionLabel = new System.Windows.Forms.Label();
            payment_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingNavigator)).BeginInit();
            this.paymentMethodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "paymentMethod";
            this.paymentMethodBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.paymentMethodTableAdapter = this.paymentMethodTableAdapter;
            this.tableAdapterManager.productImgTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // paymentMethodBindingNavigator
            // 
            this.paymentMethodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentMethodBindingNavigator.BindingSource = this.paymentMethodBindingSource;
            this.paymentMethodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentMethodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentMethodBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.paymentMethodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentMethodBindingNavigatorSaveItem});
            this.paymentMethodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentMethodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentMethodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentMethodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentMethodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentMethodBindingNavigator.Name = "paymentMethodBindingNavigator";
            this.paymentMethodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentMethodBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.paymentMethodBindingNavigator.TabIndex = 0;
            this.paymentMethodBindingNavigator.Text = "bindingNavigator1";
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
            // paymentMethodBindingNavigatorSaveItem
            // 
            this.paymentMethodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentMethodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentMethodBindingNavigatorSaveItem.Image")));
            this.paymentMethodBindingNavigatorSaveItem.Name = "paymentMethodBindingNavigatorSaveItem";
            this.paymentMethodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.paymentMethodBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentMethodBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentMethodBindingNavigatorSaveItem_Click);
            // 
            // paymentMethodDataGridView
            // 
            this.paymentMethodDataGridView.AutoGenerateColumns = false;
            this.paymentMethodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentMethodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.paymentMethodDataGridView.DataSource = this.paymentMethodBindingSource;
            this.paymentMethodDataGridView.Location = new System.Drawing.Point(47, 90);
            this.paymentMethodDataGridView.Name = "paymentMethodDataGridView";
            this.paymentMethodDataGridView.RowTemplate.Height = 24;
            this.paymentMethodDataGridView.Size = new System.Drawing.Size(300, 220);
            this.paymentMethodDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "payment_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "payment_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "payment_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "payment_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "payment_description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "payment_status";
            this.dataGridViewTextBoxColumn4.HeaderText = "payment_status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // payment_idLabel
            // 
            payment_idLabel.AutoSize = true;
            payment_idLabel.Location = new System.Drawing.Point(451, 90);
            payment_idLabel.Name = "payment_idLabel";
            payment_idLabel.Size = new System.Drawing.Size(81, 17);
            payment_idLabel.TabIndex = 2;
            payment_idLabel.Text = "payment id:";
            // 
            // payment_idTextBox
            // 
            this.payment_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_id", true));
            this.payment_idTextBox.Location = new System.Drawing.Point(596, 87);
            this.payment_idTextBox.Name = "payment_idTextBox";
            this.payment_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.payment_idTextBox.TabIndex = 3;
            // 
            // payment_nameLabel
            // 
            payment_nameLabel.AutoSize = true;
            payment_nameLabel.Location = new System.Drawing.Point(451, 118);
            payment_nameLabel.Name = "payment_nameLabel";
            payment_nameLabel.Size = new System.Drawing.Size(105, 17);
            payment_nameLabel.TabIndex = 4;
            payment_nameLabel.Text = "payment name:";
            // 
            // payment_nameTextBox
            // 
            this.payment_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_name", true));
            this.payment_nameTextBox.Location = new System.Drawing.Point(596, 115);
            this.payment_nameTextBox.Name = "payment_nameTextBox";
            this.payment_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.payment_nameTextBox.TabIndex = 5;
            // 
            // payment_descriptionLabel
            // 
            payment_descriptionLabel.AutoSize = true;
            payment_descriptionLabel.Location = new System.Drawing.Point(451, 146);
            payment_descriptionLabel.Name = "payment_descriptionLabel";
            payment_descriptionLabel.Size = new System.Drawing.Size(139, 17);
            payment_descriptionLabel.TabIndex = 6;
            payment_descriptionLabel.Text = "payment description:";
            // 
            // payment_descriptionTextBox
            // 
            this.payment_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_description", true));
            this.payment_descriptionTextBox.Location = new System.Drawing.Point(596, 143);
            this.payment_descriptionTextBox.Name = "payment_descriptionTextBox";
            this.payment_descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.payment_descriptionTextBox.TabIndex = 7;
            // 
            // payment_statusLabel
            // 
            payment_statusLabel.AutoSize = true;
            payment_statusLabel.Location = new System.Drawing.Point(451, 174);
            payment_statusLabel.Name = "payment_statusLabel";
            payment_statusLabel.Size = new System.Drawing.Size(108, 17);
            payment_statusLabel.TabIndex = 8;
            payment_statusLabel.Text = "payment status:";
            // 
            // payment_statusTextBox
            // 
            this.payment_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_status", true));
            this.payment_statusTextBox.Location = new System.Drawing.Point(596, 171);
            this.payment_statusTextBox.Name = "payment_statusTextBox";
            this.payment_statusTextBox.Size = new System.Drawing.Size(100, 22);
            this.payment_statusTextBox.TabIndex = 9;
            // 
            // PaymentMethodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(payment_idLabel);
            this.Controls.Add(this.payment_idTextBox);
            this.Controls.Add(payment_nameLabel);
            this.Controls.Add(this.payment_nameTextBox);
            this.Controls.Add(payment_descriptionLabel);
            this.Controls.Add(this.payment_descriptionTextBox);
            this.Controls.Add(payment_statusLabel);
            this.Controls.Add(this.payment_statusTextBox);
            this.Controls.Add(this.paymentMethodDataGridView);
            this.Controls.Add(this.paymentMethodBindingNavigator);
            this.Name = "PaymentMethodManagement";
            this.Text = "PaymentMethodManagement";
            this.Load += new System.EventHandler(this.PaymentMethodManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingNavigator)).EndInit();
            this.paymentMethodBindingNavigator.ResumeLayout(false);
            this.paymentMethodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private Perfume_StoreDataSetTableAdapters.paymentMethodTableAdapter paymentMethodTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentMethodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paymentMethodBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView paymentMethodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox payment_idTextBox;
        private System.Windows.Forms.TextBox payment_nameTextBox;
        private System.Windows.Forms.TextBox payment_descriptionTextBox;
        private System.Windows.Forms.TextBox payment_statusTextBox;
    }
}