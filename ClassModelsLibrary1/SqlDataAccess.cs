using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace ClassModelsLibrary1
{
    public class SqlDataAccess
    {
        public static void SaveBook(BookModel book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Book (Tytuł, Autor, Pożyczone) values (@Tytuł, @Autor, @Pożyczone)", book);
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

        public static DataSet LoadBooks()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("select Id, Tytuł, Autor from Book where Pożyczone == 'Nie'", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds;
            }
        }

        public static DataSet LoadBooksBorrowed()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("select Id, Tytuł, Autor from Book where Pożyczone == 'Tak'", cnn);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Info");

                return ds;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
