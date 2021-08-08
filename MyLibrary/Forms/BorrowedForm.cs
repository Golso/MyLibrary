using ClassModelsLibrary1;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class BorrowedForm : Form
    {
        private int currentID = 0;
        private int userID;

        public BorrowedForm(int userID)
        {
            this.userID = userID;

            InitializeComponent();

            LoadBorrowed();
        }

        private void LoadBorrowed()
        {
            DataSet ds = SqlDataAccess.LoadBooksBorrowed(userID);

            dataGridViewBorrowed.DataSource = null;
            dataGridViewBorrowed.DataSource = ds.Tables[0];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlDataAccess.ChangeBorrowState(currentID, false);

            currentID = 0;
            titleText.Text = "";
            autorText.Text = "";

            LoadBorrowed();
        }

        private void dataGridViewBorrowed_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBorrowed.Rows[e.RowIndex];

                currentID = Convert.ToInt32(row.Cells[0].Value);
                titleText.Text = row.Cells[1].Value.ToString();
                autorText.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
