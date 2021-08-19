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
                cnn.Execute("insert into User (Login, Password, Stan) values (@Login, @Password, @Stan)", user);
            }
        }

        public static void DeleteUser(int userID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM User WHERE UserID = {userID}");
            }
        }

        public static bool LoginExists(string userName)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"SELECT * FROM User WHERE Login='{userName}'", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds.Tables[0].Rows.Count == 1;
            }
        }

        public static bool LoginPasswordExists(string userName, string password)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"SELECT * FROM User WHERE Login='{userName}' AND Password='{password}'", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds.Tables[0].Rows.Count==1;
            }
        }

        public static int GetUserId(string userName, string password)
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

        public static string GetUserName(int userID)
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

        public static int GetUserState(int userID)
        {
            int userState = 0;

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"SELECT Stan FROM User WHERE UserID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                userState = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            }

            return userState;
        }

        public static void ChangeAppState(int userID, int state)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE User SET Stan = '{state}' WHERE UserID = {userID}");
            }
        }

        public static void SaveBook(BookModel book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Book (Tytuł, Autor, DoKupienia, UserID) values (@Tytuł, @Autor, @DoKupienia, @UserID)", book);
            }
        }

        public static void SaveBorrowedBook(BorrowedBookModel book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into BorrowedBook (Tytuł, Autor, Komu, UserID) values (@Tytuł, @Autor, @Komu, @UserID)", book);
            }
        }

        public static void DeleteBook(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Book WHERE ID = " + id);
            }
        }

        public static void DeleteBorrowedBook(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM BorrowedBook WHERE ID = " + id);
            }
        }

        public static void UpdateBook(int id, string title, string author)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Book SET Tytuł = '{title}', Autor = '{author}' WHERE ID = {id}");
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
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select Id, Tytuł, Autor from Book where DoKupienia == 'Nie' and userID = {userID}", cnn);
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
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select Id, Tytuł, Autor, Komu from BorrowedBook where userID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds;
            }
        }

        public static DataSet SearchBook(int userID, string text)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select Id, Tytuł, Autor from Book where DoKupienia == 'Nie' and userID = {userID} and Tytuł like '%{text}%'", cnn);
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

                amount += ds.Tables[0].Rows.Count;
            }
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter($"select * from BorrowedBook where userID = {userID}", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                amount += ds.Tables[0].Rows.Count;
            }
            return amount;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
