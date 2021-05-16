using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderinho
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show("Open README before start.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProductsDataBase.SetPath(".\\products.db");
            ProductsDataBase.Initialize();

            UsersDataBase.SetPath(".\\users.db");
            UsersDataBase.Initialize();

            OrdersDataBase.SetPath(".\\orders.db");
            OrdersDataBase.Initialize();

            while (true)
            {
                SignInForm signInForm = new SignInForm();
                signInForm.ShowDialog();
                if (!signInForm.Result)
                {
                    return;
                }
                if (UserManager.CurrentUser == null)
                {
                    return;
                }
                if (UserManager.CurrentUser.IsAdmin)
                {
                    Application.Run(new AdminForm());
                }
                else
                {
                    Application.Run(new UserForm());
                }
            }
        }
    }
}
