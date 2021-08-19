using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClassModelsLibrary1;

namespace MyLibrary.Forms
{
    public partial class WantedForm : Form
    {
        private int currentID = 0;
        private readonly int userID;
        public WantedForm(int userID)
        {
            this.userID = userID;

            InitializeComponent();

            SetMode(SqlDataAccess.GetUserState(userID));

            LoadBooksList();
        }

        private void LoadBooksList()
        {
            DataSet ds = SqlDataAccess.LoadBooksWanted(userID);

            dataGridViewMain.DataSource = null;
            dataGridViewMain.DataSource = ds.Tables[0];
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && autorText.Text != "")
            {
                BookModel book = new BookModel
                {
                    Tytuł = titleText.Text,
                    Autor = autorText.Text,
                    DoKupienia = "Tak",
                    UserID = userID
                };

                SqlDataAccess.SaveBook(book);

                titleText.Text = "";
                autorText.Text = "";
            }

            LoadBooksList();
        }

        private void BtnBought_Click(object sender, EventArgs e)
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
