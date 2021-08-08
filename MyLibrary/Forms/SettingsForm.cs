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
            DialogResult delete = MessageBox.Show("Czy na pewno chcesz usunąć konto?", "Na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                SqlDataAccess.deleteUser(userID);

                new LoginForm().Show();
                main.Hide();
            }
        }
    }
}
