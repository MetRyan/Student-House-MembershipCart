namespace UI.Customer
{
    partial class PaymentDetails
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
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtPaymentID = new TextBox();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            txtServiceName = new TextBox();
            txtPackageName = new TextBox();
            txtAmount = new TextBox();
            dtpDate = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(372, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 3;
            label3.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Service Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 43);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 5;
            label5.Text = "Package Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 86);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 6;
            label6.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 129);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 7;
            label7.Text = "Amount";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.19658F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.80342F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dtpDate, 1, 2);
            tableLayoutPanel1.Controls.Add(txtServiceName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPackageName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtAmount, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Location = new Point(65, 163);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(702, 172);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(txtPaymentID, 0, 1);
            tableLayoutPanel2.Controls.Add(txtCustomerID, 1, 1);
            tableLayoutPanel2.Controls.Add(txtCustomerName, 2, 1);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(65, 33);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.28571F));
            tableLayoutPanel2.Size = new Size(702, 98);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // txtPaymentID
            // 
            txtPaymentID.Location = new Point(3, 38);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(177, 27);
            txtPaymentID.TabIndex = 10;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(237, 38);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(181, 27);
            txtCustomerID.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(471, 38);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(180, 27);
            txtCustomerName.TabIndex = 12;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(222, 3);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(477, 27);
            txtServiceName.TabIndex = 13;
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(222, 46);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(477, 27);
            txtPackageName.TabIndex = 14;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(222, 132);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(477, 27);
            txtAmount.TabIndex = 16;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(222, 89);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(477, 27);
            dtpDate.TabIndex = 10;
            // 
            // PaymentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnClose);
            Name = "PaymentDetails";
            Text = "PaymentDetails";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtServiceName;
        private TextBox txtPackageName;
        private TextBox textBox6;
        private TextBox txtAmount;
        private TextBox txtPaymentID;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private DateTimePicker dtpDate;
    }
}