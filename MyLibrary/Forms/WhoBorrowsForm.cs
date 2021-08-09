using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class WhoBorrowsForm : Form
    {
        private BorrowedBookModel book;
        private int currentID;
        public WhoBorrowsForm(BorrowedBookModel book, int currentID)
        {
            this.book = book;
            this.currentID = currentID;

            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            book.Komu = txtBoxWho.Text;
            SqlDataAccess.SaveBorrowedBook(book);
            SqlDataAccess.DeleteBook(currentID);

            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
