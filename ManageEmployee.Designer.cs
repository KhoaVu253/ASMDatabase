namespace Glocery_Shop
{
    partial class ManageEmployee
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
            gbManageEmployee = new GroupBox();
            dgvEmployee = new DataGridView();
            lblEmployeeList = new Label();
            gbEmployeeInformation = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cbAuthorityLevel = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtEmployeePosition = new TextBox();
            txtEmployeeName = new TextBox();
            txtEmployeeCode = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblAuthorityLevel = new Label();
            lblPosition = new Label();
            lblEmployeeName = new Label();
            lblEmployeeCode = new Label();
            txtSearch = new TextBox();
            btnBack = new Button();
            gbManageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            gbEmployeeInformation.SuspendLayout();
            SuspendLayout();
            // 
            // gbManageEmployee
            // 
            gbManageEmployee.Controls.Add(dgvEmployee);
            gbManageEmployee.Controls.Add(lblEmployeeList);
            gbManageEmployee.Controls.Add(gbEmployeeInformation);
            gbManageEmployee.Controls.Add(txtSearch);
            gbManageEmployee.Location = new Point(12, 12);
            gbManageEmployee.Name = "gbManageEmployee";
            gbManageEmployee.Size = new Size(776, 385);
            gbManageEmployee.TabIndex = 0;
            gbManageEmployee.TabStop = false;
            gbManageEmployee.Text = "Manage Employee";
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(351, 64);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 56;
            dgvEmployee.Size = new Size(403, 314);
            dgvEmployee.TabIndex = 7;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Location = new Point(351, 32);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(106, 21);
            lblEmployeeList.TabIndex = 6;
            lblEmployeeList.Text = "Employee List";
            // 
            // gbEmployeeInformation
            // 
            gbEmployeeInformation.Controls.Add(btnClear);
            gbEmployeeInformation.Controls.Add(btnDelete);
            gbEmployeeInformation.Controls.Add(btnUpdate);
            gbEmployeeInformation.Controls.Add(btnAdd);
            gbEmployeeInformation.Controls.Add(cbAuthorityLevel);
            gbEmployeeInformation.Controls.Add(txtPassword);
            gbEmployeeInformation.Controls.Add(txtUsername);
            gbEmployeeInformation.Controls.Add(txtEmployeePosition);
            gbEmployeeInformation.Controls.Add(txtEmployeeName);
            gbEmployeeInformation.Controls.Add(txtEmployeeCode);
            gbEmployeeInformation.Controls.Add(lblPassword);
            gbEmployeeInformation.Controls.Add(lblUsername);
            gbEmployeeInformation.Controls.Add(lblAuthorityLevel);
            gbEmployeeInformation.Controls.Add(lblPosition);
            gbEmployeeInformation.Controls.Add(lblEmployeeName);
            gbEmployeeInformation.Controls.Add(lblEmployeeCode);
            gbEmployeeInformation.Location = new Point(6, 20);
            gbEmployeeInformation.Name = "gbEmployeeInformation";
            gbEmployeeInformation.Size = new Size(316, 358);
            gbEmployeeInformation.TabIndex = 0;
            gbEmployeeInformation.TabStop = false;
            gbEmployeeInformation.Text = "Employee Information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(203, 319);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 31);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(29, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(203, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 31);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 31);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbAuthorityLevel
            // 
            cbAuthorityLevel.FormattingEnabled = true;
            cbAuthorityLevel.Location = new Point(116, 133);
            cbAuthorityLevel.Name = "cbAuthorityLevel";
            cbAuthorityLevel.Size = new Size(189, 29);
            cbAuthorityLevel.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 29);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(116, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 29);
            txtUsername.TabIndex = 10;
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Location = new Point(116, 98);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(189, 29);
            txtEmployeePosition.TabIndex = 9;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(116, 63);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(189, 29);
            txtEmployeeName.TabIndex = 8;
            // 
            // txtEmployeeCode
            // 
            txtEmployeeCode.Location = new Point(116, 28);
            txtEmployeeCode.Name = "txtEmployeeCode";
            txtEmployeeCode.Size = new Size(189, 29);
            txtEmployeeCode.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(24, 171);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblAuthorityLevel
            // 
            lblAuthorityLevel.AutoSize = true;
            lblAuthorityLevel.Location = new Point(29, 136);
            lblAuthorityLevel.Name = "lblAuthorityLevel";
            lblAuthorityLevel.Size = new Size(41, 21);
            lblAuthorityLevel.TabIndex = 3;
            lblAuthorityLevel.Text = "Role";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(29, 98);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(65, 21);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Position";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(29, 66);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(81, 21);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Full Name";
            // 
            // lblEmployeeCode
            // 
            lblEmployeeCode.AutoSize = true;
            lblEmployeeCode.Location = new Point(29, 31);
            lblEmployeeCode.Name = "lblEmployeeCode";
            lblEmployeeCode.Size = new Size(46, 21);
            lblEmployeeCode.TabIndex = 0;
            lblEmployeeCode.Text = "Code";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(548, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 29);
            txtSearch.TabIndex = 6;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(gbManageEmployee);
            Name = "ManageEmployee";
            Text = "ManageEmployee";
            Load += ManageEmployee_Load;
            gbManageEmployee.ResumeLayout(false);
            gbManageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            gbEmployeeInformation.ResumeLayout(false);
            gbEmployeeInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbManageEmployee;
        private GroupBox gbEmployeeInformation;
        private Label lblEmployeeList;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblAuthorityLevel;
        private Label lblPosition;
        private Label lblEmployeeName;
        private Label lblEmployeeCode;
        private DataGridView dgvEmployee;
        private ComboBox cbAuthorityLevel;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtEmployeePosition;
        private TextBox txtEmployeeName;
        private TextBox txtEmployeeCode;
        private TextBox txtSearch;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnBack;
    }
}