namespace Glocery_Shop
{
    partial class ManageProduct
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
            gbProductInformation = new GroupBox();
            pictureBox1 = new PictureBox();
            btnUpload = new Button();
            txtProductImg = new TextBox();
            cbCategory = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtProductQuantity = new TextBox();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            lblCategory = new Label();
            lblProductImg = new Label();
            lblProductQuantity = new Label();
            lblProductPrice = new Label();
            lblProductName = new Label();
            lblProductCode = new Label();
            gbProductData = new GroupBox();
            dvgProduct = new DataGridView();
            txtSearch = new TextBox();
            btnBack = new Button();
            gbProductInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProduct).BeginInit();
            SuspendLayout();
            // 
            // gbProductInformation
            // 
            gbProductInformation.Controls.Add(pictureBox1);
            gbProductInformation.Controls.Add(btnUpload);
            gbProductInformation.Controls.Add(txtProductImg);
            gbProductInformation.Controls.Add(cbCategory);
            gbProductInformation.Controls.Add(btnClear);
            gbProductInformation.Controls.Add(btnDelete);
            gbProductInformation.Controls.Add(btnUpdate);
            gbProductInformation.Controls.Add(btnAdd);
            gbProductInformation.Controls.Add(txtProductQuantity);
            gbProductInformation.Controls.Add(txtProductPrice);
            gbProductInformation.Controls.Add(txtProductName);
            gbProductInformation.Controls.Add(txtProductCode);
            gbProductInformation.Controls.Add(lblCategory);
            gbProductInformation.Controls.Add(lblProductImg);
            gbProductInformation.Controls.Add(lblProductQuantity);
            gbProductInformation.Controls.Add(lblProductPrice);
            gbProductInformation.Controls.Add(lblProductName);
            gbProductInformation.Controls.Add(lblProductCode);
            gbProductInformation.Location = new Point(11, 11);
            gbProductInformation.Name = "gbProductInformation";
            gbProductInformation.Size = new Size(380, 562);
            gbProductInformation.TabIndex = 0;
            gbProductInformation.TabStop = false;
            gbProductInformation.Text = "Product Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(44, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 206);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(286, 168);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(43, 30);
            btnUpload.TabIndex = 14;
            btnUpload.Text = "...";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtProductImg
            // 
            txtProductImg.Enabled = false;
            txtProductImg.Location = new Point(161, 168);
            txtProductImg.Name = "txtProductImg";
            txtProductImg.ReadOnly = true;
            txtProductImg.Size = new Size(120, 27);
            txtProductImg.TabIndex = 13;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(161, 201);
            cbCategory.MaxDropDownItems = 5;
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(168, 28);
            cbCategory.TabIndex = 12;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(238, 503);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 30);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(42, 503);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(238, 472);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(42, 472);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 30);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(161, 134);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(168, 27);
            txtProductQuantity.TabIndex = 10;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(161, 101);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(168, 27);
            txtProductPrice.TabIndex = 9;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(164, 68);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(166, 27);
            txtProductName.TabIndex = 8;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(164, 32);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(166, 27);
            txtProductCode.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(44, 209);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblProductImg
            // 
            lblProductImg.AutoSize = true;
            lblProductImg.Location = new Point(44, 177);
            lblProductImg.Name = "lblProductImg";
            lblProductImg.Size = new Size(106, 20);
            lblProductImg.TabIndex = 4;
            lblProductImg.Text = "Product Image";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(44, 142);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(120, 20);
            lblProductQuantity.TabIndex = 3;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(44, 109);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(96, 20);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(44, 75);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(42, 40);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(99, 20);
            lblProductCode.TabIndex = 0;
            lblProductCode.Text = "Product Code";
            // 
            // gbProductData
            // 
            gbProductData.Controls.Add(dvgProduct);
            gbProductData.Controls.Add(txtSearch);
            gbProductData.Location = new Point(396, 11);
            gbProductData.Name = "gbProductData";
            gbProductData.Size = new Size(669, 598);
            gbProductData.TabIndex = 0;
            gbProductData.TabStop = false;
            gbProductData.Text = "Product Data";
            // 
            // dvgProduct
            // 
            dvgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProduct.Location = new Point(5, 50);
            dvgProduct.Name = "dvgProduct";
            dvgProduct.RowHeadersWidth = 56;
            dvgProduct.Size = new Size(658, 542);
            dvgProduct.TabIndex = 7;
            dvgProduct.CellClick += dvgProduct_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(165, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(120, 27);
            txtSearch.TabIndex = 6;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 579);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 30);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 621);
            Controls.Add(btnBack);
            Controls.Add(gbProductData);
            Controls.Add(gbProductInformation);
            Name = "ManageProduct";
            Text = "ManageProduct";
            Load += ManageProduct_Load;
            gbProductInformation.ResumeLayout(false);
            gbProductInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbProductData.ResumeLayout(false);
            gbProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProductInformation;
        private TextBox txtProductQuantity;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private Label lblCategory;
        private Label lblProductImg;
        private Label lblProductQuantity;
        private Label lblProductPrice;
        private Label lblProductName;
        private Label lblProductCode;
        private GroupBox gbProductData;
        private TextBox txtSearch;
        private TextBox txtProductImg;
        private ComboBox cbCategory;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnBack;
        private Button btnUpload;
        private DataGridView dvgProduct;
        private PictureBox pictureBox1;
    }
}