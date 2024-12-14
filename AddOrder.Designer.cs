namespace Glocery_Shop
{
    partial class AddOrder
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
            btnBack = new Button();
            btnSave = new Button();
            dvgOrderDetail = new DataGridView();
            gbCustomerManager = new GroupBox();
            groupBox1 = new GroupBox();
            txtProductQuantity = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            lblProductQuantity = new Label();
            lblProductName = new Label();
            lblProductCode = new Label();
            btnAdd = new Button();
            txtQuantitySolid = new TextBox();
            label2 = new Label();
            txtSearchProduct = new TextBox();
            dgvProduct = new DataGridView();
            gbCustomerInformation = new GroupBox();
            txtEmployeeID = new TextBox();
            cbxCustomer = new ComboBox();
            label1 = new Label();
            dtpOrderDate = new DateTimePicker();
            lblCustomerName = new Label();
            lblCustomerCode = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgOrderDetail).BeginInit();
            gbCustomerManager.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            gbCustomerInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 203);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 30);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dvgOrderDetail
            // 
            dvgOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrderDetail.Location = new Point(6, 372);
            dvgOrderDetail.Name = "dvgOrderDetail";
            dvgOrderDetail.RowHeadersWidth = 56;
            dvgOrderDetail.Size = new Size(1280, 275);
            dvgOrderDetail.TabIndex = 7;
            dvgOrderDetail.CellClick += dvgOrderDetail_CellClick;
            // 
            // gbCustomerManager
            // 
            gbCustomerManager.Controls.Add(groupBox1);
            gbCustomerManager.Controls.Add(dvgOrderDetail);
            gbCustomerManager.Controls.Add(gbCustomerInformation);
            gbCustomerManager.Location = new Point(12, 12);
            gbCustomerManager.Name = "gbCustomerManager";
            gbCustomerManager.Size = new Size(1292, 653);
            gbCustomerManager.TabIndex = 8;
            gbCustomerManager.TabStop = false;
            gbCustomerManager.Text = "Order Manager";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProductQuantity);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductCode);
            groupBox1.Controls.Add(lblProductQuantity);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Controls.Add(lblProductCode);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtQuantitySolid);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearchProduct);
            groupBox1.Controls.Add(dgvProduct);
            groupBox1.Location = new Point(380, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 349);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Detail";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(734, 149);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.ReadOnly = true;
            txtProductQuantity.Size = new Size(166, 27);
            txtProductQuantity.TabIndex = 22;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(734, 109);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(166, 27);
            txtProductName.TabIndex = 21;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(734, 74);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new Size(166, 27);
            txtProductCode.TabIndex = 20;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(596, 152);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(120, 20);
            lblProductQuantity.TabIndex = 19;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(596, 112);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 18;
            lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(594, 77);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(99, 20);
            lblProductCode.TabIndex = 17;
            lblProductCode.Text = "Product Code";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(809, 308);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 30);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQuantitySolid
            // 
            txtQuantitySolid.Location = new Point(734, 195);
            txtQuantitySolid.Name = "txtQuantitySolid";
            txtQuantitySolid.Size = new Size(166, 27);
            txtQuantitySolid.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 198);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 15;
            label2.Text = "Quantity Sold";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(16, 36);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(261, 27);
            txtSearchProduct.TabIndex = 1;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(16, 69);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(569, 274);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // gbCustomerInformation
            // 
            gbCustomerInformation.Controls.Add(txtEmployeeID);
            gbCustomerInformation.Controls.Add(cbxCustomer);
            gbCustomerInformation.Controls.Add(btnBack);
            gbCustomerInformation.Controls.Add(label1);
            gbCustomerInformation.Controls.Add(dtpOrderDate);
            gbCustomerInformation.Controls.Add(btnSave);
            gbCustomerInformation.Controls.Add(lblCustomerName);
            gbCustomerInformation.Controls.Add(lblCustomerCode);
            gbCustomerInformation.Location = new Point(5, 27);
            gbCustomerInformation.Name = "gbCustomerInformation";
            gbCustomerInformation.Size = new Size(364, 339);
            gbCustomerInformation.TabIndex = 0;
            gbCustomerInformation.TabStop = false;
            gbCustomerInformation.Text = "Order Information";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(133, 87);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(200, 27);
            txtEmployeeID.TabIndex = 15;
            // 
            // cbxCustomer
            // 
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(133, 136);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(200, 28);
            cbxCustomer.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 13;
            label1.Text = "Customer";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(133, 35);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 27);
            dtpOrderDate.TabIndex = 10;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(12, 90);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(75, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Employee";
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.AutoSize = true;
            lblCustomerCode.Location = new Point(12, 40);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new Size(79, 20);
            lblCustomerCode.TabIndex = 1;
            lblCustomerCode.Text = "OrderDate";
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 677);
            Controls.Add(gbCustomerManager);
            Name = "AddOrder";
            Text = "AddOrder";
            Load += AddOrder_Load_1;
            ((System.ComponentModel.ISupportInitialize)dvgOrderDetail).EndInit();
            gbCustomerManager.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            gbCustomerInformation.ResumeLayout(false);
            gbCustomerInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dvgOrderDetail;
        private GroupBox gbCustomerManager;
        private GroupBox gbCustomerInformation;
        private Label lblCustomerName;
        private Label lblCustomerCode;
        private TextBox txtSearch;
        private ComboBox cbxCustomer;
        private Label label1;
        private DateTimePicker dtpOrderDate;
        private GroupBox groupBox1;
        private TextBox txtSearchProduct;
        private DataGridView dgvProduct;
        private TextBox txtQuantitySolid;
        private Label label2;
        private Button btnAdd;
        private TextBox txtEmployeeID;
        private TextBox txtProductQuantity;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private Label lblProductQuantity;
        private Label lblProductName;
        private Label lblProductCode;
    }
}