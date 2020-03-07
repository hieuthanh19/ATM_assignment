namespace PefumeStore.Management_Interface
{
    partial class DeliveryMethodManagement
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
            System.Windows.Forms.Label delivery_idLabel;
            System.Windows.Forms.Label delivery_nameLabel;
            System.Windows.Forms.Label delivery_descriptionLabel;
            System.Windows.Forms.Label delivery_statusLabel;
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.deliveryMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryMethodTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.deliveryMethodTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.deliveryMethodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_idTextBox = new System.Windows.Forms.TextBox();
            this.delivery_nameTextBox = new System.Windows.Forms.TextBox();
            this.delivery_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.delivery_statusTextBox = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            delivery_idLabel = new System.Windows.Forms.Label();
            delivery_nameLabel = new System.Windows.Forms.Label();
            delivery_descriptionLabel = new System.Windows.Forms.Label();
            delivery_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryMethodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // delivery_idLabel
            // 
            delivery_idLabel.AutoSize = true;
            delivery_idLabel.Location = new System.Drawing.Point(483, 133);
            delivery_idLabel.Name = "delivery_idLabel";
            delivery_idLabel.Size = new System.Drawing.Size(76, 17);
            delivery_idLabel.TabIndex = 2;
            delivery_idLabel.Text = "delivery id:";
            // 
            // delivery_nameLabel
            // 
            delivery_nameLabel.AutoSize = true;
            delivery_nameLabel.Location = new System.Drawing.Point(483, 161);
            delivery_nameLabel.Name = "delivery_nameLabel";
            delivery_nameLabel.Size = new System.Drawing.Size(100, 17);
            delivery_nameLabel.TabIndex = 4;
            delivery_nameLabel.Text = "delivery name:";
            // 
            // delivery_descriptionLabel
            // 
            delivery_descriptionLabel.AutoSize = true;
            delivery_descriptionLabel.Location = new System.Drawing.Point(483, 189);
            delivery_descriptionLabel.Name = "delivery_descriptionLabel";
            delivery_descriptionLabel.Size = new System.Drawing.Size(134, 17);
            delivery_descriptionLabel.TabIndex = 6;
            delivery_descriptionLabel.Text = "delivery description:";
            // 
            // delivery_statusLabel
            // 
            delivery_statusLabel.AutoSize = true;
            delivery_statusLabel.Location = new System.Drawing.Point(483, 217);
            delivery_statusLabel.Name = "delivery_statusLabel";
            delivery_statusLabel.Size = new System.Drawing.Size(103, 17);
            delivery_statusLabel.TabIndex = 8;
            delivery_statusLabel.Text = "delivery status:";
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryMethodBindingSource
            // 
            this.deliveryMethodBindingSource.DataMember = "deliveryMethod";
            this.deliveryMethodBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // deliveryMethodTableAdapter
            // 
            this.deliveryMethodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brandTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.countriesTableAdapter = null;
            this.tableAdapterManager.deliveryMethodTableAdapter = this.deliveryMethodTableAdapter;
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
            // deliveryMethodDataGridView
            // 
            this.deliveryMethodDataGridView.AutoGenerateColumns = false;
            this.deliveryMethodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryMethodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.deliveryMethodDataGridView.DataSource = this.deliveryMethodBindingSource;
            this.deliveryMethodDataGridView.Location = new System.Drawing.Point(32, 116);
            this.deliveryMethodDataGridView.Name = "deliveryMethodDataGridView";
            this.deliveryMethodDataGridView.RowTemplate.Height = 24;
            this.deliveryMethodDataGridView.Size = new System.Drawing.Size(300, 220);
            this.deliveryMethodDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "delivery_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "delivery_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "delivery_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "delivery_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "delivery_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "delivery_description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "delivery_status";
            this.dataGridViewTextBoxColumn4.HeaderText = "delivery_status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // delivery_idTextBox
            // 
            this.delivery_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_id", true));
            this.delivery_idTextBox.Location = new System.Drawing.Point(623, 130);
            this.delivery_idTextBox.Name = "delivery_idTextBox";
            this.delivery_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.delivery_idTextBox.TabIndex = 3;
            // 
            // delivery_nameTextBox
            // 
            this.delivery_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_name", true));
            this.delivery_nameTextBox.Location = new System.Drawing.Point(623, 158);
            this.delivery_nameTextBox.Name = "delivery_nameTextBox";
            this.delivery_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.delivery_nameTextBox.TabIndex = 5;
            // 
            // delivery_descriptionTextBox
            // 
            this.delivery_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_description", true));
            this.delivery_descriptionTextBox.Location = new System.Drawing.Point(623, 186);
            this.delivery_descriptionTextBox.Name = "delivery_descriptionTextBox";
            this.delivery_descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.delivery_descriptionTextBox.TabIndex = 7;
            // 
            // delivery_statusTextBox
            // 
            this.delivery_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_status", true));
            this.delivery_statusTextBox.Location = new System.Drawing.Point(623, 214);
            this.delivery_statusTextBox.Name = "delivery_statusTextBox";
            this.delivery_statusTextBox.Size = new System.Drawing.Size(100, 22);
            this.delivery_statusTextBox.TabIndex = 9;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
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
            this.label1.Location = new System.Drawing.Point(221, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Delivery Method Management";
            // 
            // DeliveryMethodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(delivery_idLabel);
            this.Controls.Add(this.delivery_idTextBox);
            this.Controls.Add(delivery_nameLabel);
            this.Controls.Add(this.delivery_nameTextBox);
            this.Controls.Add(delivery_descriptionLabel);
            this.Controls.Add(this.delivery_descriptionTextBox);
            this.Controls.Add(delivery_statusLabel);
            this.Controls.Add(this.delivery_statusTextBox);
            this.Controls.Add(this.deliveryMethodDataGridView);
            this.Name = "DeliveryMethodManagement";
            this.Text = "DeliveryMethodManagement";
            this.Load += new System.EventHandler(this.DeliveryMethodManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryMethodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource deliveryMethodBindingSource;
        private Perfume_StoreDataSetTableAdapters.deliveryMethodTableAdapter deliveryMethodTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView deliveryMethodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox delivery_idTextBox;
        private System.Windows.Forms.TextBox delivery_nameTextBox;
        private System.Windows.Forms.TextBox delivery_descriptionTextBox;
        private System.Windows.Forms.TextBox delivery_statusTextBox;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
    }
}