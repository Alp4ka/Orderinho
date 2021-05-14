using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderinho
{
    public static class UserManager
    {
        public static User CurrentUser;
        static UserManager()
        {
            CurrentUser = null;
        }
        public static List<User> GetAllUsers()
        {
            return UsersDataBase.Read();
        }
        public static bool LogIn(string email, string password, out string errorMessage)
        {
            var users = GetAllUsers().Where(x => x.Email == email).ToList();
            if(users.Count > 0)
            {
                if (users[0].CheckPassword(password))
                {
                    CurrentUser = users[0];
                    errorMessage = "";
                    return true;
                }
                errorMessage = "Wrong password!";
                return false;
            }
            else
            {
                errorMessage = "There is no user with such parameters.";
                return false;
            }
        }
        public static void LogOut()
        {
            CurrentUser = null;
        }
        public static void Register(int id, string email, string password, string name, string surname, string midname, string telephone)
        {
            User user = new User(id, email, password, name, surname, midname, telephone);
            UsersDataBase.Add(user);
        }
    }
}
