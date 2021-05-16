using System.Collections.Generic;
using System.Linq;

namespace Orderinho
{
    public static class UserManager
    {
        public static User CurrentUser;
        static UserManager()
        {
            CurrentUser = null;
        }
        /// <summary>
        /// Get all users from database.
        /// </summary>
        /// <returns></returns>
        public static List<User> GetAllUsers()
        {
            return UsersDataBase.Read();
        }
        /// <summary>
        /// Login user with input parameters.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static bool LogIn(string email, string password, out string errorMessage)
        {
            var users = GetAllUsers().Where(x => x.Email == email).ToList();
            if (users.Count > 0)
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
        /// <summary>
        /// Logout from current account.
        /// </summary>
        public static void LogOut()
        {
            CurrentUser = null;
        }
        /// <summary>
        /// Get user by his id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User GetUserByID(int id)
        {
            return GetAllUsers().Where(x => x.ID == id).First();
        }
        /// <summary>
        /// Sign Up a new user with input parameters.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="midname"></param>
        /// <param name="telephone"></param>
        public static void Register(int id, string email, string password, string name, string surname, string midname, string telephone)
        {
            User user = new User(id, email, password, name, surname, midname, telephone);
            UsersDataBase.Add(user);
        }
    }
}
