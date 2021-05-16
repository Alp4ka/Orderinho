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
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
                {
                    connection.Open();
                    SQLiteCommand command =
                    new SQLiteCommand("CREATE TABLE Orders (id INTEGER , Customer INTEGER, Products TEXT, Address TEXT, Payment INTEGER, State INTEGER,  Price REAL);" +
                    "CREATE TABLE Carts (Customer INTEGER, Products TEXT);", connection);
                    command.ExecuteNonQuery();
                }
            }

        }
        public static string Path { get => _dbPath; }
        public static Cart GetCart(User user)
        {
            if (File.Exists(_dbPath))
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
                {
                    connection.Open();
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
                    connection.Open();
                    string line = $"DELETE FROM 'Carts' WHERE Customer = {cart.Customer.ID};" + $"INSERT INTO 'Carts' ('Customer' , 'Products') VALUES ('{cart.Customer.ID}', '{Utils.ProductsInline(cart.Products)}');";
                    SQLiteCommand command = new SQLiteCommand(line, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrder(Order order)
        {
            if (File.Exists(_dbPath))
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
                {
                    connection.Open();
                    string line = $"UPDATE 'Orders' SET Payment = '{(int)order.PayState}', State = '{(int)order.State}' WHERE id = '{order.ID}'; ";
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
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'Orders';", connection);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        foreach (DbDataRecord record in reader)
                        {
                            int id = int.Parse(record["id"].ToString());
                            int customerId = int.Parse(record["Customer"].ToString());
                            User customer = UserManager.GetAllUsers().Where(x => x.ID == customerId).First();
                            var products = Utils.ParseProducts(record["Products"].ToString());
                            var address = record["Address"].ToString();
                            var payment = (PaymentState)int.Parse(record["Payment"].ToString());
                            var state = (OrderState)int.Parse(record["State"].ToString());
                            Order order = new Order(id, customer, products, address, payment, state);
                            result.Add(order);
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Add order to database.
        /// </summary>
        /// <param name="order"></param>
        public static void Add(Order order)
        {
            if (File.Exists(_dbPath))
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", _dbPath)))
                {
                    connection.Open();
                    string line = $"DELETE FROM 'Carts' WHERE Customer = {order.Customer.ID};" +
                        $"INSERT INTO 'Orders' ('id', 'Customer' , 'Products', 'Address', 'Payment', 'State', 'Price') VALUES ('{order.ID}', '{order.Customer.ID}', '{Utils.ProductsInline(order.Products)}', '{order.Addresss}', '{(int)order.PayState}', '{(int)order.State}', '{order.Price}');";
                    SQLiteCommand command = new SQLiteCommand(line, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
