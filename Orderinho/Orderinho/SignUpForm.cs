using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderinho
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            string email = emailTb.Text.Trim();
            string name = nameTb.Text.Trim();
            string surname = surnameTb.Text.Trim();
            string midname = midnameTb.Text.Trim();
            string telephone = telephoneTb.Text.Trim();
            string password = passwordTb.Text;
            int id = UserManager.GetAllUsers().Count + 1;
            if (UserManager.GetAllUsers().Where(x=>x.Email == email).ToList().Count > 0)
            {
                errorLabel.Text = "There is already a user with such an email!";
                return;
            }
            if(email.Length < 5)
            {
                errorLabel.Text = $"Minimal email length is 5 characters! You have: {email.Length}";
                return;
            }
            if (password.Length < 8)
            {
                errorLabel.Text = $"Minimal password length is 8 characters! You have: {password.Length}";
                return;
            }
            UserManager.Register(id, email, password, name, surname, midname, telephone);
            errorLabel.ForeColor = Color.FromArgb(0, 255, 0);
            errorLabel.Text = "Registered";
            Close();
        }
    }
}
