namespace DrinkOrderSystem.UIs
{
    partial class OrderForm
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
            panel5 = new Panel();
            panel11 = new Panel();
            dgvOrder = new DataGridView();
            panel10 = new Panel();
            lblTotal = new Label();
            panel8 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            dgvDrinks = new DataGridView();
            panel12 = new Panel();
            btnAdd = new Button();
            panel6 = new Panel();
            txtSearch = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btnUpdate = new Button();
            btnProcess = new Button();
            btnRemove = new Button();
            panel2 = new Panel();
            label3 = new Label();
            btnClear = new Button();
            btnBack = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrinks).BeginInit();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 594);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(717, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(572, 385);
            panel5.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.Controls.Add(dgvOrder);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 45);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(10);
            panel11.Size = new Size(572, 297);
            panel11.TabIndex = 4;
            // 
            // dgvOrder
            // 
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.BackgroundColor = Color.AntiqueWhite;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Dock = DockStyle.Fill;
            dgvOrder.Location = new Point(10, 10);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(552, 277);
            dgvOrder.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(lblTotal);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 342);
            panel10.Name = "panel10";
            panel10.Size = new Size(572, 43);
            panel10.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(422, 7);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 28);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total: $0.00";
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(572, 45);
            panel8.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 7;
            label2.Text = "Order drinks";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(717, 385);
            panel4.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(panel12);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 45);
            panel9.Name = "panel9";
            panel9.Size = new Size(717, 340);
            panel9.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvDrinks);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10);
            panel7.Size = new Size(717, 260);
            panel7.TabIndex = 2;
            // 
            // dgvDrinks
            // 
            dgvDrinks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDrinks.BackgroundColor = Color.AntiqueWhite;
            dgvDrinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrinks.Dock = DockStyle.Fill;
            dgvDrinks.Location = new Point(10, 10);
            dgvDrinks.MultiSelect = false;
            dgvDrinks.Name = "dgvDrinks";
            dgvDrinks.ReadOnly = true;
            dgvDrinks.RowHeadersWidth = 51;
            dgvDrinks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrinks.Size = new Size(697, 240);
            dgvDrinks.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnAdd);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 260);
            panel12.Name = "panel12";
            panel12.Size = new Size(717, 80);
            panel12.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Sienna;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.SandyBrown;
            btnAdd.Location = new Point(567, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 60);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(717, 45);
            panel6.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(207, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(271, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 7;
            label1.Text = "Available drinks";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnProcess);
            panel3.Controls.Add(btnRemove);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 486);
            panel3.Name = "panel3";
            panel3.Size = new Size(1289, 108);
            panel3.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Sienna;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.SandyBrown;
            btnUpdate.Location = new Point(873, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 60);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnProcess
            // 
            btnProcess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProcess.BackColor = Color.Sienna;
            btnProcess.FlatStyle = FlatStyle.Flat;
            btnProcess.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnProcess.ForeColor = Color.SandyBrown;
            btnProcess.Location = new Point(1137, 26);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(140, 60);
            btnProcess.TabIndex = 2;
            btnProcess.Text = "Place an order";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.BackColor = Color.Sienna;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRemove.ForeColor = Color.SandyBrown;
            btnRemove.Location = new Point(727, 26);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(140, 60);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnBack);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1289, 101);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(602, 28);
            label3.Name = "label3";
            label3.Size = new Size(242, 41);
            label3.TabIndex = 5;
            label3.Text = "SLS CAFE GEN Z";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.Sienna;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = Color.SandyBrown;
            btnClear.Location = new Point(1137, 24);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 60);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear orders";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Sienna;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.SandyBrown;
            btnBack.Location = new Point(12, 24);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 60);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 594);
            Controls.Add(panel1);
            Name = "OrderForm";
            Text = "OrderForm";
            WindowState = FormWindowState.Maximized;
            FormClosing += OrderForm_FormClosing;
            Load += OrderForm_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDrinks).EndInit();
            panel12.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dgvDrinks;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvOrder;
        private Label lblTotal;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnProcess;
        private Button btnRemove;
        private TextBox txtSearch;
        private Button btnClear;
        private Button btnBack;
        private Panel panel8;
        private Label label2;
        private Panel panel7;
        private Panel panel6;
        private Label label1;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel12;
        private Label label3;
    }
}