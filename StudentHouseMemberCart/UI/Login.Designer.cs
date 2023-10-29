namespace UI
{
    partial class Login
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
            lbusername = new Label();
            lbPassword = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(214, 108);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(222, 166);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(293, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(102, 107);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(60, 15);
            lbusername.TabIndex = 2;
            lbusername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(107, 171);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(284, 233);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 22);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSubmit);
            Controls.Add(lbPassword);
            Controls.Add(lbusername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbusername;
        private Label lbPassword;
        private Button btnSubmit;
    }
}