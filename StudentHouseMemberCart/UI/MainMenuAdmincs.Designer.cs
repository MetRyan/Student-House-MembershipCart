namespace UI
{
    partial class MainMenuAdmincs
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
            panelLogo = new Panel();
            panelDesktop = new Panel();
            panelTitleBar = new Panel();
            lbTitle = new Label();
            panelMenu = new Panel();
            btnLogOut = new Button();
            btnCart = new Button();
            btnStaffManagement = new Button();
            btnCustomerManagement = new Button();
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.AppWorkspace;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 71);
            panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 71);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1143, 634);
            panelDesktop.TabIndex = 6;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.ControlDark;
            panelTitleBar.Controls.Add(lbTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1143, 71);
            panelTitleBar.TabIndex = 5;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(545, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(87, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            lbTitle.Click += lbTitle_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnCart);
            panelMenu.Controls.Add(btnStaffManagement);
            panelMenu.Controls.Add(btnCustomerManagement);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 705);
            panelMenu.TabIndex = 4;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 431);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(250, 115);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnCart
            // 
            btnCart.Dock = DockStyle.Top;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(0, 316);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(250, 115);
            btnCart.TabIndex = 3;
            btnCart.Text = "Staff Order Management";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // btnStaffManagement
            // 
            btnStaffManagement.Dock = DockStyle.Top;
            btnStaffManagement.FlatAppearance.BorderSize = 0;
            btnStaffManagement.FlatStyle = FlatStyle.Flat;
            btnStaffManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaffManagement.Location = new Point(0, 201);
            btnStaffManagement.Name = "btnStaffManagement";
            btnStaffManagement.Size = new Size(250, 115);
            btnStaffManagement.TabIndex = 2;
            btnStaffManagement.Text = "Staff Management";
            btnStaffManagement.UseVisualStyleBackColor = true;
            btnStaffManagement.Click += btnStaffManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = SystemColors.ActiveCaption;
            btnCustomerManagement.Dock = DockStyle.Top;
            btnCustomerManagement.FlatAppearance.BorderSize = 0;
            btnCustomerManagement.FlatStyle = FlatStyle.Flat;
            btnCustomerManagement.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomerManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerManagement.Location = new Point(0, 71);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(250, 130);
            btnCustomerManagement.TabIndex = 1;
            btnCustomerManagement.Text = "Customer Managment";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // MainMenuAdmincs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 705);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainMenuAdmincs";
            Text = "MainMenuAdmincs";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel panelDesktop;
        private Panel panelTitleBar;
        private Label lbTitle;
        private Panel panelMenu;
        private Button btnLogin;
        private Button btnResgiter;
        private Button btnAboutus;
        private Button btnCart;
        private Button btnStaffManagement;
        private Button btnCustomerManagement;
        private Button btnLogOut;
    }
}