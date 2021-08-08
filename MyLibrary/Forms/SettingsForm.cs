using System;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class SettingsForm : Form
    {
        private int userID;
        Form main;
        public SettingsForm(int userID, Form main)
        {
            this.userID = userID;
            this.main = main;

            InitializeComponent();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            //mssg asking if for sure
            SqlDataAccess.deleteUser(userID);

            new LoginForm().Show();
            main.Hide();
        }
    }
}
