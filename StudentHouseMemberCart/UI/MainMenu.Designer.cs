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
            btnAboutus = new Button();
            btnCart = new Button();
            btnProfile = new Button();
            btnHomepage = new Button();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(btnLogin);
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
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(0, 600);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 115);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // btnAboutus
            // 
            btnAboutus.Dock = DockStyle.Top;
            btnAboutus.FlatStyle = FlatStyle.Flat;
            btnAboutus.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutus.Location = new Point(0, 485);
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
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(0, 370);
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
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 255);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(250, 115);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.Dock = DockStyle.Top;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomepage.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomepage.Location = new Point(0, 125);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(250, 130);
            btnHomepage.TabIndex = 1;
            btnHomepage.Text = "Homepage";
            btnHomepage.UseVisualStyleBackColor = true;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.AppWorkspace;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 125);
            panelLogo.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 895);
            Controls.Add(panelMenu);
            Name = "MainMenu";
            Text = "MainMenu";
            panelMenu.ResumeLayout(false);
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
    }
}