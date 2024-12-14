namespace Glocery_Shop
{
    partial class AdminForm
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
            gbAdminFeature = new GroupBox();
            btnCustomer = new Button();
            btnViewStatistic = new Button();
            btnManageOrder = new Button();
            btnManageEmployee = new Button();
            btnManageProduct = new Button();
            btnManageCategory = new Button();
            btnManageImport = new Button();
            gbAdminFeature.SuspendLayout();
            SuspendLayout();
            // 
            // gbAdminFeature
            // 
            gbAdminFeature.Controls.Add(btnCustomer);
            gbAdminFeature.Controls.Add(btnViewStatistic);
            gbAdminFeature.Controls.Add(btnManageOrder);
            gbAdminFeature.Controls.Add(btnManageEmployee);
            gbAdminFeature.Controls.Add(btnManageProduct);
            gbAdminFeature.Controls.Add(btnManageCategory);
            gbAdminFeature.Controls.Add(btnManageImport);
            gbAdminFeature.Location = new Point(0, 11);
            gbAdminFeature.Name = "gbAdminFeature";
            gbAdminFeature.Size = new Size(700, 406);
            gbAdminFeature.TabIndex = 0;
            gbAdminFeature.TabStop = false;
            gbAdminFeature.Text = "Admin Feature";
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(493, 151);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(152, 84);
            btnCustomer.TabIndex = 6;
            btnCustomer.Text = "Manage Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnViewStatistic
            // 
            btnViewStatistic.Location = new Point(66, 299);
            btnViewStatistic.Name = "btnViewStatistic";
            btnViewStatistic.Size = new Size(604, 89);
            btnViewStatistic.TabIndex = 5;
            btnViewStatistic.Text = "View Statistic";
            btnViewStatistic.UseVisualStyleBackColor = true;
            btnViewStatistic.Click += btnViewStatistic_Click;
            // 
            // btnManageOrder
            // 
            btnManageOrder.Location = new Point(66, 151);
            btnManageOrder.Name = "btnManageOrder";
            btnManageOrder.Size = new Size(136, 84);
            btnManageOrder.TabIndex = 4;
            btnManageOrder.Text = "Manage Order";
            btnManageOrder.UseVisualStyleBackColor = true;
            btnManageOrder.Click += btnManageOrder_Click;
            // 
            // btnManageEmployee
            // 
            btnManageEmployee.Location = new Point(66, 45);
            btnManageEmployee.Name = "btnManageEmployee";
            btnManageEmployee.Size = new Size(136, 84);
            btnManageEmployee.TabIndex = 3;
            btnManageEmployee.Text = "Manage Employee";
            btnManageEmployee.UseVisualStyleBackColor = true;
            btnManageEmployee.Click += btnManageEmployee_Click;
            // 
            // btnManageProduct
            // 
            btnManageProduct.Location = new Point(278, 45);
            btnManageProduct.Name = "btnManageProduct";
            btnManageProduct.Size = new Size(142, 84);
            btnManageProduct.TabIndex = 2;
            btnManageProduct.Text = "Manage Product";
            btnManageProduct.UseVisualStyleBackColor = true;
            btnManageProduct.Click += btnManageProduct_Click;
            // 
            // btnManageCategory
            // 
            btnManageCategory.Location = new Point(493, 45);
            btnManageCategory.Name = "btnManageCategory";
            btnManageCategory.Size = new Size(152, 84);
            btnManageCategory.TabIndex = 1;
            btnManageCategory.Text = "Manage Category";
            btnManageCategory.UseVisualStyleBackColor = true;
            btnManageCategory.Click += btnManageCategory_Click;
            // 
            // btnManageImport
            // 
            btnManageImport.Location = new Point(278, 151);
            btnManageImport.Name = "btnManageImport";
            btnManageImport.Size = new Size(142, 84);
            btnManageImport.TabIndex = 0;
            btnManageImport.Text = "Manage Import";
            btnManageImport.UseVisualStyleBackColor = true;
            btnManageImport.Click += btnManageImport_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 429);
            Controls.Add(gbAdminFeature);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            gbAdminFeature.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnViewStatistic;
        private Button btnManageOrder;
        private Button btnManageEmployee;
        private Button btnManageProduct;
        private Button btnManageCategory;
        private Button btnManageImport;
        public GroupBox gbAdminFeature;
        private Button btnCustomer;
    }
}