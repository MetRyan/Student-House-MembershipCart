namespace UI.Admin
{
    partial class StaffManagement
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
            label1 = new Label();
            lbStaffId = new Label();
            lbStaffName = new Label();
            lbEmail = new Label();
            lbPhone = new Label();
            lbdob = new Label();
            lbSex = new Label();
            lbStatus = new Label();
            txtStaffId = new TextBox();
            txtStaffName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtStatus = new TextBox();
            txtdob = new TextBox();
            txtSex = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 4);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 0;
            label1.Text = " ";
            // 
            // lbStaffId
            // 
            lbStaffId.AutoSize = true;
            lbStaffId.Location = new Point(49, 49);
            lbStaffId.Name = "lbStaffId";
            lbStaffId.Size = new Size(53, 20);
            lbStaffId.TabIndex = 1;
            lbStaffId.Text = "StaffId";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.Location = new Point(46, 97);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(80, 20);
            lbStaffName.TabIndex = 2;
            lbStaffName.Text = "StaffName";
            lbStaffName.Click += label3_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(46, 145);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(372, 45);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "Phone";
            // 
            // lbdob
            // 
            lbdob.AutoSize = true;
            lbdob.Location = new Point(350, 145);
            lbdob.Name = "lbdob";
            lbdob.Size = new Size(96, 20);
            lbdob.TabIndex = 5;
            lbdob.Text = "Date Of Birth";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(47, 201);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(32, 20);
            lbSex.TabIndex = 6;
            lbSex.Text = "Sex";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(369, 90);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 7;
            lbStatus.Text = "Status";
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new Point(165, 42);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new Size(125, 27);
            txtStaffId.TabIndex = 8;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(165, 94);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(125, 27);
            txtStaffName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(491, 42);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(491, 87);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 12;
            // 
            // txtdob
            // 
            txtdob.Location = new Point(491, 142);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(125, 27);
            txtdob.TabIndex = 13;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(165, 198);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(125, 27);
            txtSex.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 265);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 16;
            label2.Text = "SearchStatus";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "true", "false" });
            comboBox1.Location = new Point(165, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 17;
            // 
            // StaffManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(txtSex);
            Controls.Add(txtdob);
            Controls.Add(txtStatus);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffId);
            Controls.Add(lbStatus);
            Controls.Add(lbSex);
            Controls.Add(lbdob);
            Controls.Add(lbPhone);
            Controls.Add(lbEmail);
            Controls.Add(lbStaffName);
            Controls.Add(lbStaffId);
            Controls.Add(label1);
            Name = "StaffManagement";
            Text = "StaffManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbStaffId;
        private Label lbStaffName;
        private Label lbEmail;
        private Label lbPhone;
        private Label lbdob;
        private Label lbSex;
        private Label lbStatus;
        private TextBox txtStaffId;
        private TextBox txtStaffName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtStatus;
        private TextBox txtdob;
        private TextBox txtSex;
        private Label label2;
        private ComboBox comboBox1;
    }
}