using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Orderinho
{
    public static class OrdersDataBase
    {
        private static string _dbPath;
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
            }
            using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
            {
                SQLiteCommand command =
                new SQLiteCommand("CREATE TABLE Orders (id INTEGER , Customer INTEGER, Products TEXT);" +
                "CREATE TABLE Carts (Customer INTEGER, Products TEXT);", connection);
                command.ExecuteNonQuery();
            }
        }
        public static string Path { get => _dbPath; }
        public static Cart GetCart(User user)
        {
            if (File.Exists(_dbPath))
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
                {
                    SQLiteCommand command = new SQLiteCommand($"SELECT * FROM 'Carts' WHERE Customer = {user.ID};", connection);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        foreach (DbDataRecord record in reader)
                        {
                            int id = user.ID;
                            var products = Utils.ParseProducts(record["Products"].ToString());
                            //MessageBox.Show($"{id} | {Utils.ProductsInline(products)}");
                            return new Cart(user, products);
                        }
                    }
                }
            }
            return null;
        }
        public static void SaveCart(Cart cart)
        {
            if (File.Exists(_dbPath))
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
                {
                    //$"DELETE FROM 'Carts' WHERE Customer = {cart.Customer.ID};" +
                    string line = $"INSERT INTO 'Carts' ('Customer' , 'Products') VALUES ('{cart.Customer.ID}', '{Utils.ProductsInline(cart.Products)}');";
                    MessageBox.Show(line);
                    SQLiteCommand command = new SQLiteCommand(line, connection);
                    command.ExecuteNonQuery();
                }
            }
            
        }
        /// <summary>
        /// Read database.
        /// </summary>
        public static List<Order> Read()
        {
            var result = new List<Order>();
            if (File.Exists(_dbPath))
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
                {
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'Orders';", connection);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        foreach (DbDataRecord record in reader)
                        {
                            int id = int.Parse(record["id"].ToString());

                            int customerId = int.Parse(record["Customer"].ToString());
                            User customer = UserManager.GetAllUsers().Where(x => x.ID == customerId).First();

                            var products = Utils.ParseProducts(record["Products"].ToString());

                            Order order = new Order(customer, products, id);
                            result.Add(order);
                        }
                    }
                }
            }
            return result;
        }

        // TODO
        public static void Add(Order order)
        {
            //Connection.Open();
            //SQLiteCommand command = new SQLiteCommand($"INSERT INTO 'Users' ('id' , 'Name', 'Surname', 'Midname', 'Email', 'Telephone', 'Password', 'IsAdmin') VALUES ({user.ID}, '{user.Name}', '{user.Surname}', '{user.Midname}', '{user.Email}', '{user.Telephone}', '{user.Password}', '{isAdmin}');", Connection);
            //command.ExecuteNonQuery();
            //Connection.Close();
        }
    }
}
