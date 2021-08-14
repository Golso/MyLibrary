using ClassModelsLibrary1;
using System;
using System.Data;
using System.Drawing;
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

            setMode(SqlDataAccess.getUserState(userID));

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
            BookModel book = new BookModel();
            book.Tytuł = titleText.Text;
            book.Autor = autorText.Text;
            book.DoKupienia = "Nie";
            book.UserID = userID;

            SqlDataAccess.SaveBook(book);
            SqlDataAccess.DeleteBorrowedBook(currentID);

            currentID = 0;
            titleText.Text = "";
            autorText.Text = "";
            whoText.Text = "";

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
                whoText.Text = row.Cells[3].Value.ToString();
            }
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
            {
                setDarkMode();
            }
            else setNormalMode();
        }
    }
}
