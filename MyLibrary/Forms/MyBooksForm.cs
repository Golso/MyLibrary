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
        List<BookModel> books = new List<BookModel>(); 
        public MyBooksForm()
        {
            InitializeComponent();

            LoadBooksList();
        }

        private void LoadBooksList()
        {
            //books = SqlDataAccess.LoadBooks();

            WireUpBooksList();
        }

        private void WireUpBooksList()
        {
            //listOfBooksBox.DataSource = null;
            //listOfBooksBox.DataSource = books;
            //listOfBooksBox.DisplayMember = "Title";

            DataSet ds = SqlDataAccess.LoadBooks();

            dataGridViewMain.DataSource = ds.Tables[0];

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "")
            {
                BookModel book = new BookModel();

                book.Title = titleText.Text;
                book.Borrowed = borrowedBox.Checked;

                SqlDataAccess.SaveBook(book);

                titleText.Text = "";
                borrowedBox.Checked = false;
            }

            LoadBooksList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
