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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryManagement));
            System.Windows.Forms.Label country_idLabel;
            System.Windows.Forms.Label country_nameLabel;
            System.Windows.Forms.Label country_statusLabel;
            System.Windows.Forms.Label country_createdAtLabel;
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.countriesTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.countriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.countriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.countriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_idTextBox = new System.Windows.Forms.TextBox();
            this.country_nameTextBox = new System.Windows.Forms.TextBox();
            this.country_statusTextBox = new System.Windows.Forms.TextBox();
            this.country_createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            country_idLabel = new System.Windows.Forms.Label();
            country_nameLabel = new System.Windows.Forms.Label();
            country_statusLabel = new System.Windows.Forms.Label();
            country_createdAtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingNavigator)).BeginInit();
            this.countriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "countries";
            this.countriesBindingSource.DataSource = this.perfume_StoreDataSet;
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
            // countriesBindingNavigator
            // 
            this.countriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.countriesBindingNavigator.BindingSource = this.countriesBindingSource;
            this.countriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.countriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.countriesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.countriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.countriesBindingNavigatorSaveItem});
            this.countriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.countriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.countriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.countriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.countriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.countriesBindingNavigator.Name = "countriesBindingNavigator";
            this.countriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.countriesBindingNavigator.Size = new System.Drawing.Size(817, 27);
            this.countriesBindingNavigator.TabIndex = 0;
            this.countriesBindingNavigator.Text = "bindingNavigator1";
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
            // countriesBindingNavigatorSaveItem
            // 
            this.countriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countriesBindingNavigatorSaveItem.Image")));
            this.countriesBindingNavigatorSaveItem.Name = "countriesBindingNavigatorSaveItem";
            this.countriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.countriesBindingNavigatorSaveItem.Text = "Save Data";
            this.countriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.countriesBindingNavigatorSaveItem_Click);
            // 
            // countriesDataGridView
            // 
            this.countriesDataGridView.AutoGenerateColumns = false;
            this.countriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.countriesDataGridView.DataSource = this.countriesBindingSource;
            this.countriesDataGridView.Location = new System.Drawing.Point(48, 88);
            this.countriesDataGridView.Name = "countriesDataGridView";
            this.countriesDataGridView.RowTemplate.Height = 24;
            this.countriesDataGridView.Size = new System.Drawing.Size(300, 220);
            this.countriesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "country_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "country_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "country_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "country_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country_status";
            this.dataGridViewTextBoxColumn3.HeaderText = "country_status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "country_createdAt";
            this.dataGridViewTextBoxColumn4.HeaderText = "country_createdAt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // country_idLabel
            // 
            country_idLabel.AutoSize = true;
            country_idLabel.Location = new System.Drawing.Point(463, 90);
            country_idLabel.Name = "country_idLabel";
            country_idLabel.Size = new System.Drawing.Size(74, 17);
            country_idLabel.TabIndex = 2;
            country_idLabel.Text = "country id:";
            // 
            // country_idTextBox
            // 
            this.country_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_id", true));
            this.country_idTextBox.Location = new System.Drawing.Point(597, 87);
            this.country_idTextBox.Name = "country_idTextBox";
            this.country_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.country_idTextBox.TabIndex = 3;
            // 
            // country_nameLabel
            // 
            country_nameLabel.AutoSize = true;
            country_nameLabel.Location = new System.Drawing.Point(463, 118);
            country_nameLabel.Name = "country_nameLabel";
            country_nameLabel.Size = new System.Drawing.Size(98, 17);
            country_nameLabel.TabIndex = 4;
            country_nameLabel.Text = "country name:";
            // 
            // country_nameTextBox
            // 
            this.country_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_name", true));
            this.country_nameTextBox.Location = new System.Drawing.Point(597, 115);
            this.country_nameTextBox.Name = "country_nameTextBox";
            this.country_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.country_nameTextBox.TabIndex = 5;
            // 
            // country_statusLabel
            // 
            country_statusLabel.AutoSize = true;
            country_statusLabel.Location = new System.Drawing.Point(463, 146);
            country_statusLabel.Name = "country_statusLabel";
            country_statusLabel.Size = new System.Drawing.Size(101, 17);
            country_statusLabel.TabIndex = 6;
            country_statusLabel.Text = "country status:";
            // 
            // country_statusTextBox
            // 
            this.country_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "country_status", true));
            this.country_statusTextBox.Location = new System.Drawing.Point(597, 143);
            this.country_statusTextBox.Name = "country_statusTextBox";
            this.country_statusTextBox.Size = new System.Drawing.Size(200, 22);
            this.country_statusTextBox.TabIndex = 7;
            // 
            // country_createdAtLabel
            // 
            country_createdAtLabel.AutoSize = true;
            country_createdAtLabel.Location = new System.Drawing.Point(463, 175);
            country_createdAtLabel.Name = "country_createdAtLabel";
            country_createdAtLabel.Size = new System.Drawing.Size(128, 17);
            country_createdAtLabel.TabIndex = 8;
            country_createdAtLabel.Text = "country created At:";
            // 
            // country_createdAtDateTimePicker
            // 
            this.country_createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.countriesBindingSource, "country_createdAt", true));
            this.country_createdAtDateTimePicker.Location = new System.Drawing.Point(597, 171);
            this.country_createdAtDateTimePicker.Name = "country_createdAtDateTimePicker";
            this.country_createdAtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.country_createdAtDateTimePicker.TabIndex = 9;
            // 
            // CountryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(country_idLabel);
            this.Controls.Add(this.country_idTextBox);
            this.Controls.Add(country_nameLabel);
            this.Controls.Add(this.country_nameTextBox);
            this.Controls.Add(country_statusLabel);
            this.Controls.Add(this.country_statusTextBox);
            this.Controls.Add(country_createdAtLabel);
            this.Controls.Add(this.country_createdAtDateTimePicker);
            this.Controls.Add(this.countriesDataGridView);
            this.Controls.Add(this.countriesBindingNavigator);
            this.Name = "CountryManagement";
            this.Text = "Country";
            this.Load += new System.EventHandler(this.CountryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingNavigator)).EndInit();
            this.countriesBindingNavigator.ResumeLayout(false);
            this.countriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Perfume_StoreDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator countriesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton countriesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView countriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox country_idTextBox;
        private System.Windows.Forms.TextBox country_nameTextBox;
        private System.Windows.Forms.TextBox country_statusTextBox;
        private System.Windows.Forms.DateTimePicker country_createdAtDateTimePicker;
    }
}