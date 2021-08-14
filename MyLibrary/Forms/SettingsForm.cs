using System;
using System.Drawing;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class SettingsForm : Form
    {
        private int userID;
        MainForm main;
        public SettingsForm(int userID, MainForm main)
        {
            this.userID = userID;
            this.main = main;

            InitializeComponent();

            setMode(SqlDataAccess.getUserState(userID));
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Czy na pewno chcesz usunąć konto?", "Na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                SqlDataAccess.deleteUser(userID);

                new LoginForm().Show();
                main.Hide();
            }
        }

        private void btnNormalMode_Click(object sender, EventArgs e)
        {
            SqlDataAccess.changeAppState(userID, 0);
            main.changeMode(0);
            setMode(0);
        }

        private void btnBlackMode_Click(object sender, EventArgs e)
        {
            SqlDataAccess.changeAppState(userID, 1);
            main.changeMode(1);
            setMode(1);
        }

        private void setNormalMode()
        {
            this.BackColor = Color.MediumBlue;
        }

        private void setDarkMode()
        {
            this.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void setMode(int state)
        {
            if (state == 1)
                setDarkMode();
            else setNormalMode();
        }
    }
}
