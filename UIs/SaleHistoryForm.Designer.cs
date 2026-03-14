namespace DrinkOrderSystem.UIs
{
    partial class SaleHistoryForm
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
            panel4 = new Panel();
            dgvSales = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnBack = new Button();
            cmbFilter = new ComboBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 531);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvSales);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(1093, 360);
            panel4.TabIndex = 2;
            // 
            // dgvSales
            // 
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BackgroundColor = Color.White;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.Location = new Point(20, 20);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersWidth = 51;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(1053, 320);
            dgvSales.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(1093, 91);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(cmbFilter);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 80);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(811, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Filter by date";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SaddleBrown;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 23);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 45);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Today", "This Week", "This Month" });
            cmbFilter.Location = new Point(913, 23);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(160, 28);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // SaleHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 531);
            Controls.Add(panel1);
            Name = "SaleHistoryForm";
            Text = "SaleHistoryForm";
            FormClosing += SaleHistoryForm_FormClosing;
            Load += SaleHistoryForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnBack;
        private ComboBox cmbFilter;
        private Panel panel4;
        private DataGridView dgvSales;
        private Panel panel3;
        private Label label1;
    }
}