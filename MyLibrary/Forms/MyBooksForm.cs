using ClassModelsLibrary;
using ClassModelsLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class MyBooksForm : Form
    {
        int currentID = 0;
        public MyBooksForm()
        {
            InitializeComponent();

            LoadBooksList();
        }

        private void LoadBooksList()
        {
            WireUpBooksList();
        }

        private void WireUpBooksList()
        {
            DataSet ds = SqlDataAccess.LoadBooks();

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
                book.Pożyczone = "Nie";

                SqlDataAccess.SaveBook(book);

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

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && currentID != 0)
            {
                SqlDataAccess.ChangeBorrowState(currentID, true);

                currentID = 0;
                titleText.Text = "";
                autorText.Text = "";
            }
            LoadBooksList();
        }
    }
}
