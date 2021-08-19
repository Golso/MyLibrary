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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel
            {
                Login = txtUsername.Text
            };

            if (txtPassword.Text == txtConPassword.Text)
            {
                try
                {
                    user.Password = txtPassword.Text;
                    user.Stan = 0;
                    SqlDataAccess.AddUser(user);

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";
                    checkBoxShowPass.Checked = false;

                    new LoginForm().Show();
                    Hide();
                }
                catch (Exception)
                {
                    if (SqlDataAccess.LoginExists(user.Login))
                    {
                        MessageBox.Show("Konto o takim loginie już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hasła do siebie nie pasują.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            checkBoxShowPass.Checked = false;
        }

        private void LabelToLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void TxtConPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRegister_Click(this, new EventArgs());
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
