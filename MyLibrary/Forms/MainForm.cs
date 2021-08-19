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

        private readonly int userID;
        private readonly int userState;

        public MainForm(int userID)
        {
            this.userID = userID;
            userState = SqlDataAccess.GetUserState(userID);
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlFormLoader.Controls.Clear();
            MyBooksForm myBookForm = new MyBooksForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookForm.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(myBookForm);
            userNameLabel.Text = SqlDataAccess.GetUserName(this.userID);
            myBookForm.Show();

            ChangeMode(userState);
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Moje książki";
            pnlFormLoader.Controls.Clear();
            MyBooksForm myBookForm = new MyBooksForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookForm.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(myBookForm);
            myBookForm.Show();
        }

        private void BtnBorrowed_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Pożyczone";
            pnlFormLoader.Controls.Clear();
            BorrowedForm borrowedForm = new BorrowedForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            borrowedForm.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(borrowedForm);
            borrowedForm.Show();
        }

        private void BtnWanted_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Do kupienia";
            pnlFormLoader.Controls.Clear();
            WantedForm wantedForm = new WantedForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            wantedForm.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(wantedForm);
            wantedForm.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Ustawienia";
            pnlFormLoader.Controls.Clear();
            SettingsForm settingsForm = new SettingsForm(userID, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settingsForm.FormBorderStyle = FormBorderStyle.None;
            pnlFormLoader.Controls.Add(settingsForm);
            settingsForm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void ChangeToNormalMode()
        {
            BackColor = Color.Navy;
            pnlNavigation.BackColor = Color.Navy;
            userPanel.BackColor = Color.MidnightBlue;

            lblTitle.ForeColor = Color.Black;
            userNameLabel.ForeColor = Color.Black;

            btnBorrowed.BackColor = Color.Navy;
            btnClose.BackColor = Color.Navy;
            btnMain.BackColor = Color.Navy;
            btnSettings.BackColor = Color.Navy;

            btnMain.ForeColor = Color.Black;
            btnBorrowed.ForeColor = Color.Black;
            btnSettings.ForeColor = Color.Black;
            btnWanted.ForeColor = Color.Black;
        }

        private void ChangeToDarkMode()
        {
            BackColor = Color.FromArgb(51, 51, 76);
            pnlNavigation.BackColor = Color.FromArgb(51, 51, 76);
            userPanel.BackColor = Color.FromArgb(39, 39, 58);

            lblTitle.ForeColor = Color.Black;
            userNameLabel.ForeColor = Color.Black;

            btnBorrowed.BackColor = Color.FromArgb(51, 51, 76);
            btnClose.BackColor = Color.FromArgb(51, 51, 76);
            btnMain.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);

            btnMain.ForeColor = Color.DarkRed;
            btnBorrowed.ForeColor = Color.DarkRed;
            btnSettings.ForeColor = Color.DarkRed;
            btnWanted.ForeColor = Color.DarkRed;
        }

        public void ChangeMode(int state)
        {
            if (state == 1)
            {
                ChangeToDarkMode();
            }
            else
            {
                ChangeToNormalMode();
            }
        }

        private void Minimaliz_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
