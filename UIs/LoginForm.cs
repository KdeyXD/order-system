using DrinkOrderSystem.Model;
using DrinkOrderSystem.Services;

namespace DrinkOrderSystem.UIs
{
    public partial class LoginForm : Form
    {
        AuthService authService;
        public LoginForm()
        {
            InitializeComponent();
            authService = new AuthService();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                chkShowPassword.Text = "Hide password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                chkShowPassword.Text = "Show password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = authService.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            MessageBox.Show("Login Successful.");
            ClearFields();

            MainForm mainForm = new MainForm(this);
            this.Hide();
            mainForm.Show();
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
