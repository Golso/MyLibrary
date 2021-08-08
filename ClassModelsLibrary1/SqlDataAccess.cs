using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace ClassModelsLibrary1
{
    public class SqlDataAccess
    {
        public static void AddUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (Login, Password) values (@Login, @Password)", user);
            }
        }

        public static void deleteUser(int userID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM User WHERE UserID = {userID}");
            }
        }
        
        public static bool loginPasswordExists(string userName, string password)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"SELECT * FROM User WHERE Login='{userName}' AND Password='{password}'", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds.Tables[0].Rows.Count==1;
            }
        }
        public static int getUserId(string userName, string password)
        {
            int userID = 0;

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"SELECT UserID FROM User WHERE Login='{userName}' AND Password='{password}'", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                userID = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            }

            return userID;
        }

        public static string getUserName(int userID)
        {
            string userName = "";
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"SELECT Login FROM User WHERE UserID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                userName = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[0]);
            }
            return userName;
        }

        public static void SaveBook(BookModel book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Book (Tytuł, Autor, Pożyczone, DoKupienia, UserID) values (@Tytuł, @Autor, @Pożyczone, @DoKupienia, @UserID)", book);
            }
        }

        public static void DeleteBook(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Book WHERE ID = " + id);
            }
        }

        public static void UpdateBook(int id, string title, string author)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Book SET Tytuł = '{title}', Autor = '{author}' WHERE ID = {id}");
            }
        }

        public static void ChangeBorrowState(int id, bool borrowed)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string borrow = borrowed ? "Tak" : "Nie";
                cnn.Execute($"UPDATE Book SET Pożyczone = '{borrow}' WHERE ID = {id}");
            }
        }

        public static void BuyBook(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Book SET DoKupienia = '{"Nie"}' WHERE ID = {id}");
            }
        }

        public static DataSet LoadBooks(int userID)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select Id, Tytuł, Autor from Book where Pożyczone == 'Nie' and DoKupienia == 'Nie' and userID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds;
            }
        }

        public static DataSet LoadBooksWanted(int userID)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select Id, Tytuł, Autor from Book where DoKupienia == 'Tak' and userID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds;
            }
        }

        public static DataSet LoadBooksBorrowed(int userID)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select Id, Tytuł, Autor from Book where Pożyczone == 'Tak' and userID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds;
            }
        }

        public static DataSet SearchBook(int userID, string text)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select Id, Tytuł, Autor from Book where Pożyczone == 'Nie' and DoKupienia == 'Nie' and userID = {userID} and Tytuł like '%{text}%'", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds;
            }
        }

        public static int GetAmountOfBooks(int userID)
        {
            int amount = 0;
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select * from Book where DoKupienia == 'Nie' and userID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                amount = ds.Tables[0].Rows.Count;
            }
            return amount;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
