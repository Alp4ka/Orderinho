using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.IO;

namespace Orderinho
{
    public static class UsersDataBase
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
                    new SQLiteCommand("CREATE TABLE Users (id INTEGER , Name TEXT, Surname TEXT, Midname TEXT, Email TEXT, Telephone TEXT, Password TEXT, IsAdmin INTEGER);", Connection);
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
        public static List<User> Read()
        {
            var result = new List<User>();
            if (File.Exists(_dbPath))
            {
                Connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'Users';", Connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    foreach (DbDataRecord record in reader)
                    {
                        int id = int.Parse(record["id"].ToString());
                        string name = record["Name"].ToString();
                        string surname = record["Surname"].ToString();
                        string midname = record["Midname"].ToString();
                        string telephone = record["Telephone"].ToString();
                        string email = record["Email"].ToString();
                        string password = record["Password"].ToString();
                        bool isAdmin = int.Parse(record["IsAdmin"].ToString()) == 1? true: false;
                        User user = new User(id, email, password, name, surname, midname, telephone, isAdmin: isAdmin, encoded: true);
                        result.Add(user);
                    }
                }
                Connection.Close();
            }
            return result;
        }

        public static void Add(User user)
        {
            Connection.Open();
            int isAdmin = user.IsAdmin ? 1 : 0;
            SQLiteCommand command = new SQLiteCommand($"INSERT INTO 'Users' ('id' , 'Name', 'Surname', 'Midname', 'Email', 'Telephone', 'Password', 'IsAdmin') VALUES ({user.ID}, '{user.Name}', '{user.Surname}', '{user.Midname}', '{user.Email}', '{user.Telephone}', '{user.Password}', '{isAdmin}');", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
