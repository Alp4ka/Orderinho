using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Orderinho
{
    public static class ProductsDataBase
    {
        private static string _dbPath;
        public static SQLiteConnection Connection { get; set; }
        public static void SetPath(string path)
        {
            _dbPath = path;
        }

        /// <summary>
        /// Initialize database.
        /// </summary>
        public static void Initialize()
        {
            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
                Connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath));
                Connection.Open();
                SQLiteCommand command =
                    new SQLiteCommand("CREATE TABLE Products (id INTEGER, Name TEXT,  Description TEXT, Price REAL, Image TEXT);", Connection);
                command.ExecuteNonQuery();
                Connection.Close();
            }
            else
            {
                Connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath));
                Connection.Close();
            }
        }
        public static string Path { get => _dbPath; }

        /// <summary>
        /// Read database.
        /// </summary>
        public static List<Product> Read()
        {
            var result = new List<Product>();
            if (File.Exists(_dbPath))
            {
                Connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'Products';", Connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    foreach (DbDataRecord record in reader)
                    {
                        int id = int.Parse(record["id"].ToString());
                        string name = record["Name"].ToString();
                        string description = record["Description"].ToString();
                        double price = double.Parse(record["Price"].ToString());
                        string image = record["Image"].ToString();
                        Product product = new Product(id, name, price, image, description);
                        result.Add(product);
                    }
                }
                Connection.Close();
            }
            return result;
        }
    }
}
