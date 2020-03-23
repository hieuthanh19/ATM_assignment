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
            System.Windows.Forms.Label payment_idLabel;
            System.Windows.Forms.Label payment_nameLabel;
            System.Windows.Forms.Label payment_descriptionLabel;
            System.Windows.Forms.Label payment_statusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentMethodTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.paymentMethodTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.paymentMethodDataGridView = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.payment_idTextBox = new System.Windows.Forms.TextBox();
            this.payment_nameTextBox = new System.Windows.Forms.TextBox();
            this.payment_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.payment_statusTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            payment_idLabel = new System.Windows.Forms.Label();
            payment_nameLabel = new System.Windows.Forms.Label();
            payment_descriptionLabel = new System.Windows.Forms.Label();
            payment_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_idLabel
            // 
            payment_idLabel.AutoSize = true;
            payment_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_idLabel.Location = new System.Drawing.Point(57, 86);
            payment_idLabel.Name = "payment_idLabel";
            payment_idLabel.Size = new System.Drawing.Size(107, 24);
            payment_idLabel.TabIndex = 23;
            payment_idLabel.Text = "payment id:";
            // 
            // payment_nameLabel
            // 
            payment_nameLabel.AutoSize = true;
            payment_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_nameLabel.Location = new System.Drawing.Point(57, 122);
            payment_nameLabel.Name = "payment_nameLabel";
            payment_nameLabel.Size = new System.Drawing.Size(140, 24);
            payment_nameLabel.TabIndex = 25;
            payment_nameLabel.Text = "payment name:";
            // 
            // payment_descriptionLabel
            // 
            payment_descriptionLabel.AutoSize = true;
            payment_descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_descriptionLabel.Location = new System.Drawing.Point(57, 156);
            payment_descriptionLabel.Name = "payment_descriptionLabel";
            payment_descriptionLabel.Size = new System.Drawing.Size(184, 24);
            payment_descriptionLabel.TabIndex = 27;
            payment_descriptionLabel.Text = "payment description:";
            // 
            // payment_statusLabel
            // 
            payment_statusLabel.AutoSize = true;
            payment_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_statusLabel.Location = new System.Drawing.Point(57, 190);
            payment_statusLabel.Name = "payment_statusLabel";
            payment_statusLabel.Size = new System.Drawing.Size(139, 24);
            payment_statusLabel.TabIndex = 29;
            payment_statusLabel.Text = "payment status:";
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
            // paymentMethodDataGridView
            // 
            this.paymentMethodDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentMethodDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.paymentMethodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentMethodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.paymentMethodDataGridView.DataSource = this.paymentMethodBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymentMethodDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.paymentMethodDataGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.paymentMethodDataGridView.Location = new System.Drawing.Point(548, 63);
            this.paymentMethodDataGridView.Name = "paymentMethodDataGridView";
            this.paymentMethodDataGridView.RowTemplate.Height = 24;
            this.paymentMethodDataGridView.Size = new System.Drawing.Size(445, 235);
            this.paymentMethodDataGridView.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(23, 15);
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
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Payment Method Management";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(23, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(128, 266);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 35);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(230, 266);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 35);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.White;
            this.btnPre.Location = new System.Drawing.Point(332, 266);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(93, 35);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(434, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // payment_idTextBox
            // 
            this.payment_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_id", true));
            this.payment_idTextBox.Enabled = false;
            this.payment_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_idTextBox.Location = new System.Drawing.Point(247, 82);
            this.payment_idTextBox.Name = "payment_idTextBox";
            this.payment_idTextBox.Size = new System.Drawing.Size(209, 28);
            this.payment_idTextBox.TabIndex = 24;
            // 
            // payment_nameTextBox
            // 
            this.payment_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_name", true));
            this.payment_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_nameTextBox.Location = new System.Drawing.Point(247, 118);
            this.payment_nameTextBox.Name = "payment_nameTextBox";
            this.payment_nameTextBox.Size = new System.Drawing.Size(209, 28);
            this.payment_nameTextBox.TabIndex = 26;
            // 
            // payment_descriptionTextBox
            // 
            this.payment_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_description", true));
            this.payment_descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_descriptionTextBox.Location = new System.Drawing.Point(247, 152);
            this.payment_descriptionTextBox.Name = "payment_descriptionTextBox";
            this.payment_descriptionTextBox.Size = new System.Drawing.Size(209, 28);
            this.payment_descriptionTextBox.TabIndex = 28;
            // 
            // payment_statusTextBox
            // 
            this.payment_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentMethodBindingSource, "payment_status", true));
            this.payment_statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_statusTextBox.Location = new System.Drawing.Point(247, 186);
            this.payment_statusTextBox.Name = "payment_statusTextBox";
            this.payment_statusTextBox.Size = new System.Drawing.Size(209, 28);
            this.payment_statusTextBox.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "payment id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "payment_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "payment name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "payment_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "payment description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "payment_status";
            this.dataGridViewTextBoxColumn4.HeaderText = "payment status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // PaymentMethodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 338);
            this.Controls.Add(payment_idLabel);
            this.Controls.Add(this.payment_idTextBox);
            this.Controls.Add(payment_nameLabel);
            this.Controls.Add(this.payment_nameTextBox);
            this.Controls.Add(payment_descriptionLabel);
            this.Controls.Add(this.payment_descriptionTextBox);
            this.Controls.Add(payment_statusLabel);
            this.Controls.Add(this.payment_statusTextBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentMethodDataGridView);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaymentMethodManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfume Store Manager | Payment Method Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentMethodManagement_FormClosed);
            this.Load += new System.EventHandler(this.PaymentMethodManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private Perfume_StoreDataSetTableAdapters.paymentMethodTableAdapter paymentMethodTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView paymentMethodDataGridView;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox payment_idTextBox;
        private System.Windows.Forms.TextBox payment_nameTextBox;
        private System.Windows.Forms.TextBox payment_descriptionTextBox;
        private System.Windows.Forms.TextBox payment_statusTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}