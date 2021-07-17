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
        public static List<BookModel> LoadBooks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BookModel>("select * from Book", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveBook(BookModel book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Book (Title, Borrowed) values (@Title, @Borrowed)", book);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
