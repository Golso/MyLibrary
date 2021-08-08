﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MyLibrary.Forms;
using ClassModelsLibrary1;

namespace MyLibrary
{
    public partial class MainForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
          );

        private int userID;

        public MainForm(int userID)
        {
            this.userID = userID;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            this.pnlFormLoader.Controls.Clear();
            MyBooksForm myBookForm = new MyBooksForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(myBookForm);
            this.userNameLabel.Text = SqlDataAccess.getUserName(this.userID);
            myBookForm.Show();
        }

        private void btnMain_Enter(object sender, EventArgs e)
        {
            btnMain.BackColor = Color.DarkViolet;
        }

        private void btnMain_Leave(object sender, EventArgs e)
        {
            btnMain.BackColor = Color.DarkOrchid;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Moje książki";
            this.pnlFormLoader.Controls.Clear();
            MyBooksForm myBookForm = new MyBooksForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(myBookForm);
            myBookForm.Show();
        }

        private void btnBorrowed_Enter(object sender, EventArgs e)
        {
            btnBorrowed.BackColor = Color.DarkViolet;
        }

        private void btnBorrowed_Leave(object sender, EventArgs e)
        {
            btnBorrowed.BackColor = Color.DarkOrchid;
        }

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Pożyczone";
            this.pnlFormLoader.Controls.Clear();
            BorrowedForm borrowedForm = new BorrowedForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            borrowedForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(borrowedForm);
            borrowedForm.Show();
        }

        private void btnWanted_Enter(object sender, EventArgs e)
        {
            btnWanted.BackColor = Color.DarkViolet;
        }

        private void btnWanted_Leave(object sender, EventArgs e)
        {
            btnWanted.BackColor = Color.DarkOrchid;
        }

        private void btnWanted_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Do kupienia";
            this.pnlFormLoader.Controls.Clear();
            WantedForm wantedForm = new WantedForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            wantedForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(wantedForm);
            wantedForm.Show();
        }

        private void btnSettings_Enter(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.DarkViolet;
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.DarkOrchid;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Ustawienia";
            this.pnlFormLoader.Controls.Clear();
            SettingsForm settingsForm = new SettingsForm(userID, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settingsForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(settingsForm);
            settingsForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
