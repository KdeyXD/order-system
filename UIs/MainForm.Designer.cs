namespace DrinkOrderSystem.UIs
{
    partial class MainForm
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
            panelLogout = new Panel();
            lblLogout = new Label();
            pbLogout = new PictureBox();
            panelExit = new Panel();
            lblExit = new Label();
            pbExit = new PictureBox();
            panelOrderHistory = new Panel();
            lblSale = new Label();
            pbSaleIcon = new PictureBox();
            label1 = new Label();
            panelMenu = new Panel();
            pictureBoxIcon = new PictureBox();
            labelTitle = new Label();
            panel1.SuspendLayout();
            panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            panelOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSaleIcon).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(panelLogout);
            panel1.Controls.Add(panelExit);
            panel1.Controls.Add(panelOrderHistory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panelMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 450);
            panel1.TabIndex = 0;
            // 
            // panelLogout
            // 
            panelLogout.BackColor = Color.Salmon;
            panelLogout.Controls.Add(lblLogout);
            panelLogout.Controls.Add(pbLogout);
            panelLogout.Location = new Point(11, 378);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new Size(150, 60);
            panelLogout.TabIndex = 6;
            panelLogout.Click += panelLogout_Click;
            // 
            // lblLogout
            // 
            lblLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.ForeColor = Color.White;
            lblLogout.Location = new Point(61, 6);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(79, 48);
            lblLogout.TabIndex = 1;
            lblLogout.Text = "Logout";
            lblLogout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogout
            // 
            pbLogout.Image = Properties.Resources.logout;
            pbLogout.Location = new Point(7, 6);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(48, 48);
            pbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogout.TabIndex = 0;
            pbLogout.TabStop = false;
            // 
            // panelExit
            // 
            panelExit.BackColor = Color.Salmon;
            panelExit.Controls.Add(lblExit);
            panelExit.Controls.Add(pbExit);
            panelExit.Location = new Point(424, 378);
            panelExit.Name = "panelExit";
            panelExit.Size = new Size(150, 60);
            panelExit.TabIndex = 5;
            panelExit.Click += panelExit_Click;
            // 
            // lblExit
            // 
            lblExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(61, 6);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(86, 48);
            lblExit.TabIndex = 1;
            lblExit.Text = "Exit";
            lblExit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbExit
            // 
            pbExit.Image = Properties.Resources._switch;
            pbExit.Location = new Point(7, 6);
            pbExit.Name = "pbExit";
            pbExit.Size = new Size(48, 48);
            pbExit.SizeMode = PictureBoxSizeMode.Zoom;
            pbExit.TabIndex = 0;
            pbExit.TabStop = false;
            // 
            // panelOrderHistory
            // 
            panelOrderHistory.BackColor = Color.Chocolate;
            panelOrderHistory.Controls.Add(lblSale);
            panelOrderHistory.Controls.Add(pbSaleIcon);
            panelOrderHistory.Location = new Point(187, 248);
            panelOrderHistory.Name = "panelOrderHistory";
            panelOrderHistory.Size = new Size(200, 80);
            panelOrderHistory.TabIndex = 4;
            panelOrderHistory.Click += panelOrderHistory_Click;
            // 
            // lblSale
            // 
            lblSale.BackColor = Color.Transparent;
            lblSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSale.ForeColor = Color.White;
            lblSale.Location = new Point(63, 27);
            lblSale.Name = "lblSale";
            lblSale.Size = new Size(123, 29);
            lblSale.TabIndex = 7;
            lblSale.Text = "Order history";
            lblSale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSaleIcon
            // 
            pbSaleIcon.Image = Properties.Resources.clock;
            pbSaleIcon.Location = new Point(7, 17);
            pbSaleIcon.Name = "pbSaleIcon";
            pbSaleIcon.Size = new Size(50, 50);
            pbSaleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbSaleIcon.TabIndex = 6;
            pbSaleIcon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(208, 24);
            label1.Name = "label1";
            label1.Size = new Size(179, 41);
            label1.TabIndex = 1;
            label1.Text = "Main Menu";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Peru;
            panelMenu.Controls.Add(pictureBoxIcon);
            panelMenu.Controls.Add(labelTitle);
            panelMenu.Location = new Point(220, 84);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(140, 140);
            panelMenu.TabIndex = 0;
            panelMenu.Click += panelMenu_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources.coffee_cup;
            pictureBoxIcon.Location = new Point(34, 10);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(80, 80);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 5;
            pictureBoxIcon.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(2, 94);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(137, 44);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "New order";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 450);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
            panelOrderHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSaleIcon).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelOrderHistory;
        private Label label1;
        private Panel panelMenu;
        private Label labelTitle;
        private PictureBox pictureBoxIcon;
        private Panel panelExit;
        private PictureBox pbExit;
        private Label lblExit;
        private Panel panelLogout;
        private Label lblLogout;
        private PictureBox pbLogout;
        private Label lblSale;
        private PictureBox pbSaleIcon;
    }
}