using System;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class WhoBorrowsForm : Form
    {
        private readonly BorrowedBookModel book;
        private readonly int currentID;

        public WhoBorrowsForm(BorrowedBookModel book, int currentID)
        {
            this.book = book;
            this.currentID = currentID;

            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            book.Komu = txtBoxWho.Text;
            SqlDataAccess.SaveBorrowedBook(book);
            SqlDataAccess.DeleteBook(currentID);

            Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
