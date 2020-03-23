namespace PefumeStore.Management_Interface
{
    partial class OrderItemManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label order_idLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label orderItem_quantityLabel;
            System.Windows.Forms.Label product_priceLabel;
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.orderItemTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.orderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_idTextBox = new System.Windows.Forms.TextBox();
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.orderItem_quantityTextBox = new System.Windows.Forms.TextBox();
            this.product_priceTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            order_idLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            orderItem_quantityLabel = new System.Windows.Forms.Label();
            product_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "orderItem";
            this.orderItemBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // orderItemTableAdapter
            // 
            this.orderItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brandTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.countriesTableAdapter = null;
            this.tableAdapterManager.deliveryMethodTableAdapter = null;
            this.tableAdapterManager.favListTableAdapter = null;
            this.tableAdapterManager.orderItemTableAdapter = this.orderItemTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.paymentMethodTableAdapter = null;
            this.tableAdapterManager.productImgTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // orderItemDataGridView
            // 
            this.orderItemDataGridView.AutoGenerateColumns = false;
            this.orderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.orderItemDataGridView.DataSource = this.orderItemBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderItemDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.orderItemDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.orderItemDataGridView.Location = new System.Drawing.Point(421, 55);
            this.orderItemDataGridView.Name = "orderItemDataGridView";
            this.orderItemDataGridView.RowTemplate.Height = 24;
            this.orderItemDataGridView.Size = new System.Drawing.Size(445, 220);
            this.orderItemDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "orderItem_quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "orderItem_quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "product_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "product_price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // order_idLabel
            // 
            order_idLabel.AutoSize = true;
            order_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_idLabel.Location = new System.Drawing.Point(42, 58);
            order_idLabel.Name = "order_idLabel";
            order_idLabel.Size = new System.Drawing.Size(83, 25);
            order_idLabel.TabIndex = 2;
            order_idLabel.Text = "order id:";
            // 
            // order_idTextBox
            // 
            this.order_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderItemBindingSource, "order_id", true));
            this.order_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_idTextBox.Location = new System.Drawing.Point(227, 55);
            this.order_idTextBox.Name = "order_idTextBox";
            this.order_idTextBox.Size = new System.Drawing.Size(147, 30);
            this.order_idTextBox.TabIndex = 3;
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_idLabel.Location = new System.Drawing.Point(42, 100);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(103, 25);
            product_idLabel.TabIndex = 4;
            product_idLabel.Text = "product id:";
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderItemBindingSource, "product_id", true));
            this.product_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_idTextBox.Location = new System.Drawing.Point(227, 97);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(147, 30);
            this.product_idTextBox.TabIndex = 5;
            // 
            // orderItem_quantityLabel
            // 
            orderItem_quantityLabel.AutoSize = true;
            orderItem_quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderItem_quantityLabel.Location = new System.Drawing.Point(42, 139);
            orderItem_quantityLabel.Name = "orderItem_quantityLabel";
            orderItem_quantityLabel.Size = new System.Drawing.Size(178, 25);
            orderItem_quantityLabel.TabIndex = 6;
            orderItem_quantityLabel.Text = "order Item quantity:";
            // 
            // orderItem_quantityTextBox
            // 
            this.orderItem_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderItemBindingSource, "orderItem_quantity", true));
            this.orderItem_quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItem_quantityTextBox.Location = new System.Drawing.Point(227, 136);
            this.orderItem_quantityTextBox.Name = "orderItem_quantityTextBox";
            this.orderItem_quantityTextBox.Size = new System.Drawing.Size(147, 30);
            this.orderItem_quantityTextBox.TabIndex = 7;
            // 
            // product_priceLabel
            // 
            product_priceLabel.AutoSize = true;
            product_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_priceLabel.Location = new System.Drawing.Point(42, 184);
            product_priceLabel.Name = "product_priceLabel";
            product_priceLabel.Size = new System.Drawing.Size(130, 25);
            product_priceLabel.TabIndex = 8;
            product_priceLabel.Text = "product price:";
            // 
            // product_priceTextBox
            // 
            this.product_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderItemBindingSource, "product_price", true));
            this.product_priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_priceTextBox.Location = new System.Drawing.Point(227, 181);
            this.product_priceTextBox.Name = "product_priceTextBox";
            this.product_priceTextBox.Size = new System.Drawing.Size(147, 30);
            this.product_priceTextBox.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(587, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 35);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPre
            // 
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(485, 311);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(93, 35);
            this.btnPre.TabIndex = 73;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(383, 311);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 35);
            this.btnNext.TabIndex = 74;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(281, 311);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 35);
            this.btnDel.TabIndex = 75;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(172, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 35);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(23, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 77;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // OrderItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 463);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(order_idLabel);
            this.Controls.Add(this.order_idTextBox);
            this.Controls.Add(product_idLabel);
            this.Controls.Add(this.product_idTextBox);
            this.Controls.Add(orderItem_quantityLabel);
            this.Controls.Add(this.orderItem_quantityTextBox);
            this.Controls.Add(product_priceLabel);
            this.Controls.Add(this.product_priceTextBox);
            this.Controls.Add(this.orderItemDataGridView);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "OrderItemManagement";
            this.Text = "OrderItemManagement";
            this.Load += new System.EventHandler(this.OrderItemManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private Perfume_StoreDataSetTableAdapters.orderItemTableAdapter orderItemTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView orderItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox order_idTextBox;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.TextBox orderItem_quantityTextBox;
        private System.Windows.Forms.TextBox product_priceTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
    }
}