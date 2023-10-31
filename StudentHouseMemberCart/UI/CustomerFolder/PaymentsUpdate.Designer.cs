namespace UI.Customer
{
    partial class PaymentsUpdate
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
            btnUpdate = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtOrderID = new TextBox();
            txtPaymentID = new TextBox();
            dtpPaymentDate = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAmount = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(205, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(487, 336);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Payment ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Order ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 124);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "Payment Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 186);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 5;
            label4.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(274, 65);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(266, 27);
            txtOrderID.TabIndex = 7;
            // 
            // txtPaymentID
            // 
            txtPaymentID.Location = new Point(274, 3);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(266, 27);
            txtPaymentID.TabIndex = 8;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Location = new Point(274, 127);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(266, 27);
            dtpPaymentDate.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpPaymentDate, 1, 2);
            tableLayoutPanel1.Controls.Add(txtPaymentID, 1, 0);
            tableLayoutPanel1.Controls.Add(txtOrderID, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtAmount, 1, 3);
            tableLayoutPanel1.Location = new Point(122, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(543, 249);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(274, 189);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(266, 27);
            txtAmount.TabIndex = 10;
            // 
            // PaymentsUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Name = "PaymentsUpdate";
            Text = "PaymentsUpdate";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtOrderID;
        private TextBox txtPaymentID;
        private DateTimePicker dtpPaymentDate;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtAmount;
    }
}