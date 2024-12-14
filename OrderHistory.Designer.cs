namespace Glocery_Shop
{
    partial class OrderHistory
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
            dvgOrderHistory = new DataGridView();
            btnBack = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dvgOrderHistory).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dvgOrderHistory
            // 
            dvgOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrderHistory.Location = new Point(6, 26);
            dvgOrderHistory.Name = "dvgOrderHistory";
            dvgOrderHistory.RowHeadersWidth = 56;
            dvgOrderHistory.Size = new Size(766, 390);
            dvgOrderHistory.TabIndex = 0;
            dvgOrderHistory.CellClick += dvgOrderHistory_CellClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(681, 422);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 30);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(103, 422);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 422);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dvgOrderHistory);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 458);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order";
            // 
            // OrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 482);
            Controls.Add(groupBox1);
            Name = "OrderHistory";
            Text = "OrderHistory";
            Load += OrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dvgOrderHistory).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgOrderHistory;
        private Button btnBack;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox1;
    }
}