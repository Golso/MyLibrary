using System;
using System.Data;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class WantedForm : Form
    {
        private int currentID = 0;
        private int userID;
        public WantedForm(int userID)
        {
            this.userID = userID;

            InitializeComponent();

            LoadBooksList();
        }

        private void LoadBooksList()
        {
            DataSet ds = SqlDataAccess.LoadBooksWanted(userID);

            dataGridViewMain.DataSource = null;
            dataGridViewMain.DataSource = ds.Tables[0];

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && autorText.Text != "")
            {
                BookModel book = new BookModel();

                book.Tytuł = titleText.Text;
                book.Autor = autorText.Text;
                book.DoKupienia = "Tak";
                book.UserID = userID;

                SqlDataAccess.SaveBook(book);

                titleText.Text = "";
                autorText.Text = "";
            }

            LoadBooksList();
        }

        private void btnBought_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && currentID != 0)
            {
                SqlDataAccess.BuyBook(currentID);

                currentID = 0;
                titleText.Text = "";
                autorText.Text = "";
            }
            LoadBooksList();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
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
    

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void dataGridViewMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[e.RowIndex];

                currentID = Convert.ToInt32(row.Cells[0].Value);
                titleText.Text = row.Cells[1].Value.ToString();
                autorText.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
