namespace Glocery_Shop
{
    partial class SaleForm
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
            gbSaleFeature = new GroupBox();
            btnManageCustomer = new Button();
            btnManageOrder = new Button();
            gbSaleFeature.SuspendLayout();
            SuspendLayout();
            // 
            // gbSaleFeature
            // 
            gbSaleFeature.Controls.Add(btnManageOrder);
            gbSaleFeature.Controls.Add(btnManageCustomer);
            gbSaleFeature.Location = new Point(12, 12);
            gbSaleFeature.Name = "gbSaleFeature";
            gbSaleFeature.Size = new Size(776, 426);
            gbSaleFeature.TabIndex = 0;
            gbSaleFeature.TabStop = false;
            gbSaleFeature.Text = "Sale Feature";
            // 
            // btnManageCustomer
            // 
            btnManageCustomer.Location = new Point(18, 47);
            btnManageCustomer.Name = "btnManageCustomer";
            btnManageCustomer.Size = new Size(240, 114);
            btnManageCustomer.TabIndex = 0;
            btnManageCustomer.Text = "Manage Customer";
            btnManageCustomer.UseVisualStyleBackColor = true;
            btnManageCustomer.Click += btnManageCustomer_Click;
            // 
            // btnManageOrder
            // 
            btnManageOrder.Location = new Point(516, 47);
            btnManageOrder.Name = "btnManageOrder";
            btnManageOrder.Size = new Size(230, 114);
            btnManageOrder.TabIndex = 1;
            btnManageOrder.Text = "Manage Order";
            btnManageOrder.UseVisualStyleBackColor = true;
            btnManageOrder.Click += btnManageOrder_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbSaleFeature);
            Name = "SaleForm";
            Text = "SaleForm";
            gbSaleFeature.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSaleFeature;
        private Button btnManageOrder;
        private Button btnManageCustomer;
    }
}