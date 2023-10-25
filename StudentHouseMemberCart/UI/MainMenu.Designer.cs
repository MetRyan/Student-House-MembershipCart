namespace UI
{
    partial class MainMenu
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
            panelMenu = new Panel();
            btnLogin = new Button();
            btnResgiter = new Button();
            btnAboutus = new Button();
            btnCart = new Button();
            btnProfile = new Button();
            btnHomepage = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lbTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(btnLogin);
            panelMenu.Controls.Add(btnResgiter);
            panelMenu.Controls.Add(btnAboutus);
            panelMenu.Controls.Add(btnCart);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Controls.Add(btnHomepage);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 895);
            panelMenu.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(0, 661);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 115);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += Login_Click;
            // 
            // btnResgiter
            // 
            btnResgiter.Dock = DockStyle.Top;
            btnResgiter.FlatAppearance.BorderSize = 0;
            btnResgiter.FlatStyle = FlatStyle.Flat;
            btnResgiter.ImageAlign = ContentAlignment.MiddleLeft;
            btnResgiter.Location = new Point(0, 546);
            btnResgiter.Name = "btnResgiter";
            btnResgiter.Size = new Size(250, 115);
            btnResgiter.TabIndex = 6;
            btnResgiter.Text = "Register";
            btnResgiter.UseVisualStyleBackColor = true;
            btnResgiter.Click += btnResgiter_Click;
            // 
            // btnAboutus
            // 
            btnAboutus.Dock = DockStyle.Top;
            btnAboutus.FlatAppearance.BorderSize = 0;
            btnAboutus.FlatStyle = FlatStyle.Flat;
            btnAboutus.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutus.Location = new Point(0, 431);
            btnAboutus.Name = "btnAboutus";
            btnAboutus.Size = new Size(250, 115);
            btnAboutus.TabIndex = 4;
            btnAboutus.Text = "AboutUs";
            btnAboutus.UseVisualStyleBackColor = true;
            btnAboutus.Click += btnAboutus_Click;
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
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 201);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(250, 115);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = SystemColors.ActiveCaption;
            btnHomepage.Dock = DockStyle.Top;
            btnHomepage.FlatAppearance.BorderSize = 0;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomepage.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomepage.Location = new Point(0, 71);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(250, 130);
            btnHomepage.TabIndex = 1;
            btnHomepage.Text = "Homepage";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += btnHomepage_Click;
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
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.ControlDark;
            panelTitleBar.Controls.Add(lbTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(994, 71);
            panelTitleBar.TabIndex = 2;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(449, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(87, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 71);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(994, 824);
            panelDesktop.TabIndex = 3;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 895);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainMenu";
            Text = "MainMenu";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private Panel panelMenu;
        private Button btnLogin;
        private Button btnAboutus;
        private Button btnCart;
        private Button btnProfile;
        private Button btnHomepage;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lbTitle;
        private Panel panelDesktop;
        private Button btnResgiter;
    }
}