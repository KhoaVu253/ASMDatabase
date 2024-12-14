namespace Glocery_Shop
{
    partial class LoginFrom
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbRole = new ComboBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            btnLogin = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(222, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(308, 29);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(222, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(308, 29);
            txtPassword.TabIndex = 1;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(222, 245);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(308, 29);
            cbRole.TabIndex = 2;
            cbRole.Text = "    ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(118, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(118, 170);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(118, 248);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(41, 21);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(222, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 31);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(428, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 31);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // LoginFrom
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(cbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginFrom";
            Text = "LoginFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cbRole;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;
        private Button btnLogin;
        private Button btnClear;
    }
}