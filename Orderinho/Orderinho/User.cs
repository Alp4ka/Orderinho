using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Orderinho
{
    public class User
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Midname { get; set; }
        public string Password { get; private set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public override string ToString()
        {
            return Email;
        }
        public void SetPassword(string password)
        {
            var encoded = Utils.Encode(password);
            Password = encoded;
        }
        public static bool IsEqual(User user1, User user2)
        {
            if(user1.Name == user2.Name &&
                user1.Surname == user2.Surname &&
                user1.Midname == user2.Midname &&
                user1.Password == user2.Password &&
                user1.Telephone == user2.Telephone &&
                user1.Email == user2.Email &&
                user1.ID == user2.ID)
            {
                return true;
            }
            return false;
        }
        public bool CheckPassword(string password)
        {
            var encoded = Utils.Encode(password);
            if(encoded == Password)
            {
                return true;
            }
            return false;
        }
        public User(int id, string email, string password, string name = "", string surname="", string midname="",  string telephone="", bool encoded = false, bool isAdmin = false)
        {
            ID = id;
            Email = email;
            Telephone = telephone;
            Name = name;
            Surname = surname;
            Midname = midname;
            IsAdmin = isAdmin;
            if (encoded)
            {
                Password = password;
            }
            else
            {
                SetPassword(password);
            }
            
        }
    }
}
