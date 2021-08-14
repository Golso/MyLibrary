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
        private int userState;

        public MainForm(int userID)
        {
            this.userID = userID;
            userState = SqlDataAccess.getUserState(userID);
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            this.pnlFormLoader.Controls.Clear();
            MyBooksForm myBookForm = new MyBooksForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(myBookForm);
            this.userNameLabel.Text = SqlDataAccess.getUserName(this.userID);
            myBookForm.Show();

            changeMode(userState);
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

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Pożyczone";
            this.pnlFormLoader.Controls.Clear();
            BorrowedForm borrowedForm = new BorrowedForm(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            borrowedForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(borrowedForm);
            borrowedForm.Show();
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

        private void changeToNormalMode()
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

        private void changeToDarkMode()
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
