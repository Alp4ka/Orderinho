using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderinho
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        public bool Result = false;

        private void loginButton_Click(object sender, EventArgs e)
        {
            string message;
            if(UserManager.LogIn(emailTb.Text.Trim(), passwordTb.Text, out message))
            {
                Result = true;
                Close();
            }
            errorLabel.Text = message;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
