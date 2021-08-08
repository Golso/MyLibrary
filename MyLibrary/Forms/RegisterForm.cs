using System;
using System.Windows.Forms;
using ClassModelsLibrary1;


namespace MyLibrary.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }
        //Co w przypadku gdy login już taki istnieje ?
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.Login = txtUsername.Text;

            if (txtPassword.Text == txtConPassword.Text)
            {
                user.Password = txtPassword.Text;
                SqlDataAccess.AddUser(user);

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConPassword.Text = "";
                checkBoxShowPass.Checked = false;

                new LoginForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hasła do siebie nie pasują.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            checkBoxShowPass.Checked = false;
        }

        private void labelToLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void txtConPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister_Click(this, new EventArgs());
            }
        }
    }
}
