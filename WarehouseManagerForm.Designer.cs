namespace Glocery_Shop
{
    partial class WarehouseManagerForm
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
            gbWarehouseManagerFeature = new GroupBox();
            btnManageProduct = new Button();
            gbWarehouseManagerFeature.SuspendLayout();
            SuspendLayout();
            // 
            // gbWarehouseManagerFeature
            // 
            gbWarehouseManagerFeature.Controls.Add(btnManageProduct);
            gbWarehouseManagerFeature.Location = new Point(32, 12);
            gbWarehouseManagerFeature.Name = "gbWarehouseManagerFeature";
            gbWarehouseManagerFeature.Size = new Size(756, 426);
            gbWarehouseManagerFeature.TabIndex = 0;
            gbWarehouseManagerFeature.TabStop = false;
            gbWarehouseManagerFeature.Text = "Warehouse Manager Feature";
            // 
            // btnManageProduct
            // 
            btnManageProduct.Location = new Point(33, 45);
            btnManageProduct.Name = "btnManageProduct";
            btnManageProduct.Size = new Size(257, 123);
            btnManageProduct.TabIndex = 0;
            btnManageProduct.Text = "Manage Product";
            btnManageProduct.UseVisualStyleBackColor = true;
            btnManageProduct.Click += btnManageProduct_Click;
            // 
            // WarehouseManagerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbWarehouseManagerFeature);
            Name = "WarehouseManagerForm";
            Text = "WarehouseManagerForm";
            gbWarehouseManagerFeature.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbWarehouseManagerFeature;
        private Button btnManageProduct;
    }
}