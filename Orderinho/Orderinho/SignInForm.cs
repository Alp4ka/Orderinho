using System;
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
        /// <summary>
        /// LogIn button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string message;
            if (UserManager.LogIn(emailTb.Text.Trim(), passwordTb.Text, out message))
            {
                Result = true;
                Close();
            }
            errorLabel.Text = message;
        }
        /// <summary>
        /// SignUp button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
