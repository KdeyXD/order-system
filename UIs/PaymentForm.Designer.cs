namespace DrinkOrderSystem.UIs
{
    partial class PaymentForm
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
            panel1 = new Panel();
            label2 = new Label();
            btnBack = new Button();
            btnPay = new Button();
            rbQr = new RadioButton();
            rbCreditCard = new RadioButton();
            rbMobileWallet = new RadioButton();
            lblTotalAmount = new Label();
            rbCash = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(rbQr);
            panel1.Controls.Add(rbCreditCard);
            panel1.Controls.Add(rbMobileWallet);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(rbCash);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 350);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 13;
            label2.Text = "Pay with:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 287);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 47);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(186, 287);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(102, 47);
            btnPay.TabIndex = 11;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // rbQr
            // 
            rbQr.AutoSize = true;
            rbQr.Location = new Point(28, 226);
            rbQr.Name = "rbQr";
            rbQr.Size = new Size(70, 24);
            rbQr.TabIndex = 10;
            rbQr.TabStop = true;
            rbQr.Text = "KHQR";
            rbQr.UseVisualStyleBackColor = true;
            // 
            // rbMobileWallet
            // 
            rbMobileWallet.AutoSize = true;
            rbMobileWallet.Location = new Point(28, 203);
            rbMobileWallet.Name = "rbMobileWallet";
            rbMobileWallet.Size = new Size(112, 24);
            rbMobileWallet.TabIndex = 11;
            rbMobileWallet.TabStop = true;
            rbMobileWallet.Text = "Mobile Wallet";
            rbMobileWallet.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            rbCreditCard.AutoSize = true;
            rbCreditCard.Location = new Point(28, 180);
            rbCreditCard.Name = "rbCreditCard";
            rbCreditCard.Size = new Size(105, 24);
            rbCreditCard.TabIndex = 9;
            rbCreditCard.TabStop = true;
            rbCreditCard.Text = "Credit Card";
            rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(28, 32);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(50, 20);
            lblTotalAmount.TabIndex = 8;
            lblTotalAmount.Text = "label1";
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Location = new Point(28, 136);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(61, 24);
            rbCash.TabIndex = 7;
            rbCash.TabStop = true;
            rbCash.Text = "Cash";
            rbCash.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 350);
            Controls.Add(panel1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnBack;
        private Button btnPay;
        private RadioButton rbQr;
        private RadioButton rbCreditCard;
        private RadioButton rbMobileWallet;
        private Label lblTotalAmount;
        private RadioButton rbCash;
    }
}