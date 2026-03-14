namespace DrinkOrderSystem.UIs
{
    partial class ToppingForm
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
            lblDrinkName = new Label();
            label2 = new Label();
            numericQty = new NumericUpDown();
            chkCaramel = new CheckBox();
            chkCream = new CheckBox();
            chkMilk = new CheckBox();
            chkSugar = new CheckBox();
            btnBack = new Button();
            btnAddToOrder = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQty).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDrinkName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericQty);
            panel1.Controls.Add(chkCaramel);
            panel1.Controls.Add(chkCream);
            panel1.Controls.Add(chkMilk);
            panel1.Controls.Add(chkSugar);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnAddToOrder);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 414);
            panel1.TabIndex = 0;
            // 
            // lblDrinkName
            // 
            lblDrinkName.AutoSize = true;
            lblDrinkName.Location = new Point(86, 34);
            lblDrinkName.Name = "lblDrinkName";
            lblDrinkName.Size = new Size(42, 20);
            lblDrinkName.TabIndex = 9;
            lblDrinkName.Text = "label";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 34);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 8;
            label2.Text = "Drink:";
            // 
            // numericQty
            // 
            numericQty.Location = new Point(95, 87);
            numericQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQty.Name = "numericQty";
            numericQty.Size = new Size(233, 27);
            numericQty.TabIndex = 7;
            numericQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkCaramel
            // 
            chkCaramel.AutoSize = true;
            chkCaramel.Location = new Point(24, 286);
            chkCaramel.Name = "chkCaramel";
            chkCaramel.Size = new Size(139, 24);
            chkCaramel.TabIndex = 6;
            chkCaramel.Text = "Caramel + 0.50$";
            chkCaramel.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            chkCream.AutoSize = true;
            chkCream.Location = new Point(24, 239);
            chkCream.Name = "chkCream";
            chkCream.Size = new Size(127, 24);
            chkCream.TabIndex = 5;
            chkCream.Text = "Cream + 0.25$";
            chkCream.UseVisualStyleBackColor = true;
            // 
            // chkMilk
            // 
            chkMilk.AutoSize = true;
            chkMilk.Location = new Point(24, 192);
            chkMilk.Name = "chkMilk";
            chkMilk.Size = new Size(112, 24);
            chkMilk.TabIndex = 4;
            chkMilk.Text = "Milk + 0.25$";
            chkMilk.UseVisualStyleBackColor = true;
            // 
            // chkSugar
            // 
            chkSugar.AutoSize = true;
            chkSugar.Location = new Point(24, 142);
            chkSugar.Name = "chkSugar";
            chkSugar.Size = new Size(69, 24);
            chkSugar.TabIndex = 3;
            chkSugar.Text = "Sugar";
            chkSugar.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(16, 343);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(124, 47);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(204, 343);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(124, 47);
            btnAddToOrder.TabIndex = 1;
            btnAddToOrder.Text = "Add to order";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 89);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantity";
            // 
            // ToppingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 414);
            Controls.Add(panel1);
            Name = "ToppingForm";
            Text = "ToppingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkCaramel;
        private CheckBox chkCream;
        private CheckBox chkMilk;
        private CheckBox chkSugar;
        private Button btnBack;
        private Button btnAddToOrder;
        private Label label1;
        private NumericUpDown numericQty;
        private Label lblDrinkName;
        private Label label2;
    }
}