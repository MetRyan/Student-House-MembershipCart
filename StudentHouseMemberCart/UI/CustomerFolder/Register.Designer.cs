namespace UI.Customer
{
    partial class Register
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
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtEmail = new TextBox();
            lbFirstName = new Label();
            txtFullName = new TextBox();
            lbLastName = new Label();
            txtLastName = new TextBox();
            lbPhone = new Label();
            lbDoB = new Label();
            lbSex = new Label();
            listBox1 = new ListBox();
            txtDoB = new MaskedTextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            btnReset = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(419, 43);
            label1.Name = "label1";
            label1.Size = new Size(213, 65);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5322132F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.46779F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tableLayoutPanel1.Controls.Add(lbDoB, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 0);
            tableLayoutPanel1.Controls.Add(lbFirstName, 0, 1);
            tableLayoutPanel1.Controls.Add(txtFullName, 1, 1);
            tableLayoutPanel1.Controls.Add(lbLastName, 0, 2);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 2);
            tableLayoutPanel1.Controls.Add(lbPhone, 2, 0);
            tableLayoutPanel1.Controls.Add(txtPhone, 3, 0);
            tableLayoutPanel1.Controls.Add(txtDoB, 3, 1);
            tableLayoutPanel1.Controls.Add(lbSex, 2, 2);
            tableLayoutPanel1.Controls.Add(listBox1, 3, 2);
            tableLayoutPanel1.Location = new Point(100, 147);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1071434F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8928566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(877, 190);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 23);
            txtEmail.TabIndex = 2;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbFirstName.Location = new Point(3, 69);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(86, 21);
            lbFirstName.TabIndex = 3;
            lbFirstName.Text = "First Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(134, 72);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(278, 23);
            txtFullName.TabIndex = 4;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLastName.Location = new Point(3, 140);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(84, 21);
            lbLastName.TabIndex = 5;
            lbLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(134, 143);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(278, 23);
            txtLastName.TabIndex = 6;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPhone.Location = new Point(434, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(54, 21);
            lbPhone.TabIndex = 7;
            lbPhone.Text = "Phone";
            // 
            // lbDoB
            // 
            lbDoB.AutoSize = true;
            lbDoB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDoB.Location = new Point(434, 69);
            lbDoB.Name = "lbDoB";
            lbDoB.Size = new Size(100, 21);
            lbDoB.TabIndex = 9;
            lbDoB.Text = "Date Of Birth";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSex.Location = new Point(434, 140);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(34, 21);
            lbSex.TabIndex = 12;
            lbSex.Text = "Sex";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "Male", "Female", "Does not want to mention" });
            listBox1.Location = new Point(569, 143);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(305, 25);
            listBox1.TabIndex = 13;
            // 
            // txtDoB
            // 
            txtDoB.Location = new Point(569, 72);
            txtDoB.Mask = "00/00/0000";
            txtDoB.Name = "txtDoB";
            txtDoB.Size = new Size(305, 23);
            txtDoB.TabIndex = 11;
            txtDoB.ValidatingType = typeof(DateTime);
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(569, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(305, 23);
            txtPhone.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(377, 373);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 32);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(534, 373);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(92, 32);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 504);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtEmail;
        private Label lbFirstName;
        private TextBox txtFullName;
        private Label lbLastName;
        private TextBox txtLastName;
        private Label lbDoB;
        private Label lbPhone;
        private TextBox txtPhone;
        private MaskedTextBox txtDoB;
        private Label lbSex;
        private ListBox listBox1;
        private Button btnRegister;
        private Button btnReset;
    }
}