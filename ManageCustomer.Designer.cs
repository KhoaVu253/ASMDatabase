namespace Glocery_Shop
{
    partial class ManageCustomer
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
            gbCustomerInformation = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtCustomerAddress = new TextBox();
            txtPhonenumber = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerCode = new TextBox();
            lblCustomerAddress = new Label();
            lblPhonenumber = new Label();
            lblCustomerName = new Label();
            lblCustomerCode = new Label();
            gbCustomerManager = new GroupBox();
            dvgCustomer = new DataGridView();
            txtSearch = new TextBox();
            btnBack = new Button();
            gbCustomerInformation.SuspendLayout();
            gbCustomerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCustomer).BeginInit();
            SuspendLayout();
            // 
            // gbCustomerInformation
            // 
            gbCustomerInformation.Controls.Add(btnClear);
            gbCustomerInformation.Controls.Add(btnDelete);
            gbCustomerInformation.Controls.Add(btnUpdate);
            gbCustomerInformation.Controls.Add(btnAdd);
            gbCustomerInformation.Controls.Add(txtCustomerAddress);
            gbCustomerInformation.Controls.Add(txtPhonenumber);
            gbCustomerInformation.Controls.Add(txtCustomerName);
            gbCustomerInformation.Controls.Add(txtCustomerCode);
            gbCustomerInformation.Controls.Add(lblCustomerAddress);
            gbCustomerInformation.Controls.Add(lblPhonenumber);
            gbCustomerInformation.Controls.Add(lblCustomerName);
            gbCustomerInformation.Controls.Add(lblCustomerCode);
            gbCustomerInformation.Location = new Point(6, 28);
            gbCustomerInformation.Name = "gbCustomerInformation";
            gbCustomerInformation.Size = new Size(410, 364);
            gbCustomerInformation.TabIndex = 0;
            gbCustomerInformation.TabStop = false;
            gbCustomerInformation.Text = "Customer Information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(251, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 31);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(72, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(251, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 31);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(72, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 31);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(208, 189);
            txtCustomerAddress.Multiline = true;
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(184, 88);
            txtCustomerAddress.TabIndex = 10;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(208, 138);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(184, 29);
            txtPhonenumber.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(208, 88);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(184, 29);
            txtCustomerName.TabIndex = 8;
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(208, 33);
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.Size = new Size(184, 29);
            txtCustomerCode.TabIndex = 7;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Location = new Point(72, 192);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(138, 21);
            lblCustomerAddress.TabIndex = 4;
            lblCustomerAddress.Text = "Customer Address";
            // 
            // lblPhonenumber
            // 
            lblPhonenumber.AutoSize = true;
            lblPhonenumber.Location = new Point(72, 138);
            lblPhonenumber.Name = "lblPhonenumber";
            lblPhonenumber.Size = new Size(116, 21);
            lblPhonenumber.TabIndex = 3;
            lblPhonenumber.Text = "Phone Number";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(72, 88);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(124, 21);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.AutoSize = true;
            lblCustomerCode.Location = new Point(72, 33);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new Size(118, 21);
            lblCustomerCode.TabIndex = 1;
            lblCustomerCode.Text = "Customer Code";
            // 
            // gbCustomerManager
            // 
            gbCustomerManager.Controls.Add(dvgCustomer);
            gbCustomerManager.Controls.Add(gbCustomerInformation);
            gbCustomerManager.Controls.Add(txtSearch);
            gbCustomerManager.Location = new Point(12, 12);
            gbCustomerManager.Name = "gbCustomerManager";
            gbCustomerManager.Size = new Size(776, 398);
            gbCustomerManager.TabIndex = 0;
            gbCustomerManager.TabStop = false;
            gbCustomerManager.Text = "Customer Manager";
            // 
            // dvgCustomer
            // 
            dvgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCustomer.Location = new Point(445, 60);
            dvgCustomer.Name = "dvgCustomer";
            dvgCustomer.RowHeadersWidth = 56;
            dvgCustomer.Size = new Size(325, 332);
            dvgCustomer.TabIndex = 7;
            dvgCustomer.CellClick += dvgCustomer_CellClick;
            dvgCustomer.CellDoubleClick += dvgCustomer_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(596, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 29);
            txtSearch.TabIndex = 6;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 416);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 31);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 466);
            Controls.Add(btnBack);
            Controls.Add(gbCustomerManager);
            Name = "ManageCustomer";
            Text = "ManageCustomer";
            Load += ManageCustomer_Load;
            gbCustomerInformation.ResumeLayout(false);
            gbCustomerInformation.PerformLayout();
            gbCustomerManager.ResumeLayout(false);
            gbCustomerManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCustomerInformation;
        private GroupBox gbCustomerManager;
        private TextBox txtCustomerAddress;
        private TextBox txtPhonenumber;
        private TextBox txtCustomerName;
        private TextBox txtCustomerCode;
        private Label lblCustomerAddress;
        private Label lblPhonenumber;
        private Label lblCustomerName;
        private Label lblCustomerCode;
        private TextBox txtSearch;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnBack;
        private DataGridView dvgCustomer;
    }
}