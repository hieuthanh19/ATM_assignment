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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.deliveryMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryMethodTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.deliveryMethodTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.deliveryMethodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.delivery_idTextBox = new System.Windows.Forms.TextBox();
            this.delivery_nameTextBox = new System.Windows.Forms.TextBox();
            this.delivery_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.delivery_statusTextBox = new System.Windows.Forms.TextBox();
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
            delivery_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delivery_idLabel.Location = new System.Drawing.Point(57, 71);
            delivery_idLabel.Name = "delivery_idLabel";
            delivery_idLabel.Size = new System.Drawing.Size(100, 24);
            delivery_idLabel.TabIndex = 28;
            delivery_idLabel.Text = "delivery id:";
            // 
            // delivery_nameLabel
            // 
            delivery_nameLabel.AutoSize = true;
            delivery_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delivery_nameLabel.Location = new System.Drawing.Point(57, 106);
            delivery_nameLabel.Name = "delivery_nameLabel";
            delivery_nameLabel.Size = new System.Drawing.Size(133, 24);
            delivery_nameLabel.TabIndex = 30;
            delivery_nameLabel.Text = "delivery name:";
            // 
            // delivery_descriptionLabel
            // 
            delivery_descriptionLabel.AutoSize = true;
            delivery_descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delivery_descriptionLabel.Location = new System.Drawing.Point(57, 142);
            delivery_descriptionLabel.Name = "delivery_descriptionLabel";
            delivery_descriptionLabel.Size = new System.Drawing.Size(177, 24);
            delivery_descriptionLabel.TabIndex = 32;
            delivery_descriptionLabel.Text = "delivery description:";
            // 
            // delivery_statusLabel
            // 
            delivery_statusLabel.AutoSize = true;
            delivery_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delivery_statusLabel.Location = new System.Drawing.Point(57, 175);
            delivery_statusLabel.Name = "delivery_statusLabel";
            delivery_statusLabel.Size = new System.Drawing.Size(132, 24);
            delivery_statusLabel.TabIndex = 34;
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
            this.deliveryMethodDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveryMethodDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deliveryMethodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryMethodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.deliveryMethodDataGridView.DataSource = this.deliveryMethodBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveryMethodDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.deliveryMethodDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.deliveryMethodDataGridView.Location = new System.Drawing.Point(587, 74);
            this.deliveryMethodDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deliveryMethodDataGridView.Name = "deliveryMethodDataGridView";
            this.deliveryMethodDataGridView.RowTemplate.Height = 24;
            this.deliveryMethodDataGridView.Size = new System.Drawing.Size(451, 220);
            this.deliveryMethodDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "delivery_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "delivery id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "delivery_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "delivery name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "delivery_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "delivery description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "delivery_status";
            this.dataGridViewTextBoxColumn4.HeaderText = "delivery status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label1.Location = new System.Drawing.Point(221, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Delivery Method Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(459, 262);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 34);
            this.btnSave.TabIndex = 24;
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
            this.btnPre.Location = new System.Drawing.Point(356, 262);
            this.btnPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(93, 34);
            this.btnPre.TabIndex = 25;
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
            this.btnNext.Location = new System.Drawing.Point(253, 262);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 34);
            this.btnNext.TabIndex = 26;
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
            this.btnDel.Location = new System.Drawing.Point(152, 262);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 34);
            this.btnDel.TabIndex = 27;
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
            this.btnAdd.Location = new System.Drawing.Point(47, 258);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 34);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // delivery_idTextBox
            // 
            this.delivery_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_id", true));
            this.delivery_idTextBox.Enabled = false;
            this.delivery_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_idTextBox.Location = new System.Drawing.Point(240, 71);
            this.delivery_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delivery_idTextBox.Name = "delivery_idTextBox";
            this.delivery_idTextBox.Size = new System.Drawing.Size(225, 28);
            this.delivery_idTextBox.TabIndex = 29;
            // 
            // delivery_nameTextBox
            // 
            this.delivery_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_name", true));
            this.delivery_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_nameTextBox.Location = new System.Drawing.Point(240, 106);
            this.delivery_nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delivery_nameTextBox.Name = "delivery_nameTextBox";
            this.delivery_nameTextBox.Size = new System.Drawing.Size(225, 28);
            this.delivery_nameTextBox.TabIndex = 31;
            // 
            // delivery_descriptionTextBox
            // 
            this.delivery_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_description", true));
            this.delivery_descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_descriptionTextBox.Location = new System.Drawing.Point(240, 142);
            this.delivery_descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delivery_descriptionTextBox.Name = "delivery_descriptionTextBox";
            this.delivery_descriptionTextBox.Size = new System.Drawing.Size(225, 28);
            this.delivery_descriptionTextBox.TabIndex = 33;
            // 
            // delivery_statusTextBox
            // 
            this.delivery_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryMethodBindingSource, "delivery_status", true));
            this.delivery_statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_statusTextBox.Location = new System.Drawing.Point(240, 175);
            this.delivery_statusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delivery_statusTextBox.Name = "delivery_statusTextBox";
            this.delivery_statusTextBox.Size = new System.Drawing.Size(225, 28);
            this.delivery_statusTextBox.TabIndex = 35;
            // 
            // DeliveryMethodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 335);
            this.Controls.Add(delivery_idLabel);
            this.Controls.Add(this.delivery_idTextBox);
            this.Controls.Add(delivery_nameLabel);
            this.Controls.Add(this.delivery_nameTextBox);
            this.Controls.Add(delivery_descriptionLabel);
            this.Controls.Add(this.delivery_descriptionTextBox);
            this.Controls.Add(delivery_statusLabel);
            this.Controls.Add(this.delivery_statusTextBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryMethodDataGridView);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "DeliveryMethodManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Method Management | Perfume Store Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeliveryMethodManagement_FormClosed);
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
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox delivery_idTextBox;
        private System.Windows.Forms.TextBox delivery_nameTextBox;
        private System.Windows.Forms.TextBox delivery_descriptionTextBox;
        private System.Windows.Forms.TextBox delivery_statusTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}