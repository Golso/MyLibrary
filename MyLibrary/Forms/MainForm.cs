using System;
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

            changeMode(SqlDataAccess.getUserState(userID));
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
            WantedForm wantedForm = new WantedForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

        private void changeToDarkMode()
        {
            this.BackColor = Color.FromArgb(10,10,10);
            this.pnlNavigation.BackColor = Color.FromArgb(0, 0, 0);
            this.userPanel.BackColor = Color.FromArgb(0, 0, 0);

            this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
            this.userNameLabel.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void changeToNormalMode()
        {
            this.BackColor = Color.DarkSlateBlue;
            this.pnlNavigation.BackColor = Color.DarkOrchid;
            this.userPanel.BackColor = Color.DarkOrchid;

            this.lblTitle.ForeColor = Color.Black;
            this.userNameLabel.ForeColor = Color.Black;
        }

        public void changeMode(int state)
        {
            if (state == 1)
            {
                changeToDarkMode();
            }
            else
            {
                changeToNormalMode();
            }
        }
    }
}
