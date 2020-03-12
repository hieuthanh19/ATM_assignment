namespace PefumeStore.Management_Interface
{
    partial class ProductImagesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductImagesManagement));
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.perfume_StoreDataSet = new PefumeStore.Perfume_StoreDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager();
            this.All_ImageflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productImg1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.productImgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productImgTableAdapter = new PefumeStore.Perfume_StoreDataSetTableAdapters.productImgTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.All_ImageflowLayoutPanel.SuspendLayout();
            this.imageFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 33;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Product Images Management";
            // 
            // perfume_StoreDataSet
            // 
            this.perfume_StoreDataSet.DataSetName = "Perfume_StoreDataSet";
            this.perfume_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = PefumeStore.Perfume_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // All_ImageflowLayoutPanel
            // 
            this.All_ImageflowLayoutPanel.AutoScroll = true;
            this.All_ImageflowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.All_ImageflowLayoutPanel.Controls.Add(this.imageFlowLayoutPanel1);
            this.All_ImageflowLayoutPanel.Location = new System.Drawing.Point(12, 68);
            this.All_ImageflowLayoutPanel.Name = "All_ImageflowLayoutPanel";
            this.All_ImageflowLayoutPanel.Size = new System.Drawing.Size(647, 245);
            this.All_ImageflowLayoutPanel.TabIndex = 34;
            // 
            // imageFlowLayoutPanel1
            // 
            this.imageFlowLayoutPanel1.Controls.Add(this.productImg1);
            this.imageFlowLayoutPanel1.Controls.Add(this.btnDelete);
            this.imageFlowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.imageFlowLayoutPanel1.Name = "imageFlowLayoutPanel1";
            this.imageFlowLayoutPanel1.Size = new System.Drawing.Size(132, 167);
            this.imageFlowLayoutPanel1.TabIndex = 0;
            // 
            // productImg1
            // 
            this.productImg1.Location = new System.Drawing.Point(3, 3);
            this.productImg1.Name = "productImg1";
            this.productImg1.Size = new System.Drawing.Size(129, 125);
            this.productImg1.TabIndex = 0;
            this.productImg1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 30);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(665, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 30);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(665, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 30);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // productImgBindingSource
            // 
            this.productImgBindingSource.DataMember = "productImg";
            this.productImgBindingSource.DataSource = this.perfume_StoreDataSet;
            // 
            // productImgTableAdapter
            // 
            this.productImgTableAdapter.ClearBeforeFill = true;
            // 
            // ProductImagesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.All_ImageflowLayoutPanel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductImagesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfume Store Manager | Product Images Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductImagesManagement_FormClosed);
            this.Load += new System.EventHandler(this.Product_Images_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfume_StoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.All_ImageflowLayoutPanel.ResumeLayout(false);
            this.imageFlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private Perfume_StoreDataSet perfume_StoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Perfume_StoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Perfume_StoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.FlowLayoutPanel All_ImageflowLayoutPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel imageFlowLayoutPanel1;
        private System.Windows.Forms.PictureBox productImg1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource productImgBindingSource;
        private Perfume_StoreDataSetTableAdapters.productImgTableAdapter productImgTableAdapter;
    }
}