using System;
using System.Drawing;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly int userID;
        private readonly MainForm main;
        public SettingsForm(int userID, MainForm main)
        {
            this.userID = userID;
            this.main = main;

            InitializeComponent();

            SetMode(SqlDataAccess.GetUserState(userID));
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Czy na pewno chcesz usunąć konto?", "Na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                SqlDataAccess.DeleteUser(userID);

                new LoginForm().Show();
                main.Hide();
            }
        }

        private void BtnNormalMode_Click(object sender, EventArgs e)
        {
            SqlDataAccess.ChangeAppState(userID, 0);
            main.ChangeMode(0);
            SetMode(0);
        }

        private void BtnBlackMode_Click(object sender, EventArgs e)
        {
            SqlDataAccess.ChangeAppState(userID, 1);
            main.ChangeMode(1);
            SetMode(1);
        }

        private void SetNormalMode()
        {
            BackColor = Color.MediumBlue;
        }

        private void SetDarkMode()
        {
            BackColor = Color.FromArgb(100, 100, 100);
        }

        private void SetMode(int state)
        {
            if (state == 1)
                SetDarkMode();
            else SetNormalMode();
        }
    }
}
