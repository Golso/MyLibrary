﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassModelsLibrary;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            if(SqlDataAccess.loginPasswordExists(userName, password))
            {
                int userID = SqlDataAccess.getUserId(userName, password);
                new MainForm(userID).Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            checkBoxShowPass.Checked = false;
        }

        private void labelCreate_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
            //this.Close();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
}
