using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkOrderSystem.UIs
{
    public partial class MainForm : Form
    {
        private Form _loginForm;
        private bool _isLoggingOut = false;
        public MainForm(Form loginForm)
        {
            InitializeComponent();

            _loginForm = loginForm;

            labelTitle.Click += panelMenu_Click;
            pictureBoxIcon.Click += panelMenu_Click;

            lblExit.Click += panelExit_Click;
            pbExit.Click += panelExit_Click;

            lblLogout.Click += panelLogout_Click;
            pbLogout.Click += panelLogout_Click;

            lblSale.Click += panelOrderHistory_Click;
            pbSaleIcon.Click += panelOrderHistory_Click;
        }

        private void panelMenu_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(this);
            this.Hide();
            orderForm.Show();
        }

        private void panelExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the program?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                _isLoggingOut = true;

                _loginForm.Show();
                this.Close();
            }
        }

        private void panelOrderHistory_Click(object sender, EventArgs e)
        {
            SaleHistoryForm saleHistoryForm = new SaleHistoryForm(this);
            this.Hide();
            saleHistoryForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLoggingOut && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();   // Only exit if NOT logging out
            }
        }
    }
}
