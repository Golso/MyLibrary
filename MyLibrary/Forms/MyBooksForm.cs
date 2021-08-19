using ClassModelsLibrary1;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class MyBooksForm : Form
    {
        private int currentID = 0;
        private readonly int userID;

        public MyBooksForm(int userID)
        {
            this.userID = userID;

            InitializeComponent();

            SetMode(SqlDataAccess.GetUserState(userID));

            LoadBooksList();
        }

        public void LoadBooksList()
        {
            txtBoxTitleSearch.Text = "Szukaj po tytule...";

            DataSet ds = SqlDataAccess.LoadBooks(userID);

            dataGridViewMain.DataSource = null;
            dataGridViewMain.DataSource = ds.Tables[0];

            lblBooksAmount.Text = "Ilość posiadanych książek: " + SqlDataAccess.GetAmountOfBooks(userID);
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && autorText.Text != "")
            {
                BookModel book = new BookModel
                {
                    Tytuł = titleText.Text,
                    Autor = autorText.Text,
                    DoKupienia = "Nie",
                    UserID = userID
                };

                SqlDataAccess.SaveBook(book);

                titleText.Text = "";
                autorText.Text = "";
            }

            LoadBooksList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAccess.DeleteBook(currentID);

                currentID = 0;
                titleText.Text = "";
                autorText.Text = "";
            }
            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Message);
            }

            LoadBooksList();
        }

        private void DataGridViewMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[e.RowIndex];

                currentID = Convert.ToInt32(row.Cells[0].Value);
                titleText.Text = row.Cells[1].Value.ToString();
                autorText.Text = row.Cells[2].Value.ToString();
            }
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && currentID != 0)
            {
                SqlDataAccess.UpdateBook(currentID, titleText.Text, autorText.Text);

                currentID = 0;
                titleText.Text = "";
                autorText.Text = "";
            }

            LoadBooksList();
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && currentID != 0)
            {
                BorrowedBookModel book = new BorrowedBookModel
                {
                    Tytuł = titleText.Text,
                    Autor = autorText.Text,
                    UserID = userID
                };

                new WhoBorrowsForm(book, currentID, this).Show();

                currentID = 0;
                titleText.Text = "";
                autorText.Text = "";
            }

            LoadBooksList();
        }

        private void TxtBoxTitleSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = SqlDataAccess.SearchBook(userID, txtBoxTitleSearch.Text);

            dataGridViewMain.DataSource = null;
            dataGridViewMain.DataSource = ds.Tables[0];
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
            {
                SetDarkMode();
            }
            else SetNormalMode();
        }
    }
}
