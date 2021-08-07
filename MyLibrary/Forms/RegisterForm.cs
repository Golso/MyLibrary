using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            else
            {
                //msg o niepasujących hasłach
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
            //this.Close();
            this.Hide();
        }
    }
}
