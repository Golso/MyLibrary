using System;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class WhoBorrowsForm : Form
    {
        private readonly BorrowedBookModel book;
        private readonly int currentID;
        private readonly MyBooksForm form;

        public WhoBorrowsForm(BorrowedBookModel book, int currentID, MyBooksForm form)
        {
            this.book = book;
            this.currentID = currentID;
            this.form = form;

            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            book.Komu = txtBoxWho.Text;
            SqlDataAccess.SaveBorrowedBook(book);
            SqlDataAccess.DeleteBook(currentID);

            form.LoadBooksList();

            Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
