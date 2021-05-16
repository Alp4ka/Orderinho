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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            InitializeAllOrdersView();
        }
        private void InitializeUsersView()
        {
            var users = UserManager.GetAllUsers();
            usersGridView.Rows.Clear();
            foreach (User user in users)
            {
                var id = user.ID;
                var email = user.Email;
                var name = user.Name;
                var surname = user.Surname;
                var midname = user.Midname;
                var isAdmin = user.IsAdmin;
                var telephone = user.Telephone;
                usersGridView.Rows.Add(id, email, name, surname, midname, telephone, isAdmin);
            }
        }
        private void InitializeAllOrdersView()
        {
            var orders = OrderManager.GetAllOrders();
            allOrdersGridView.Rows.Clear();
            foreach (Order order in orders)
            {
                var id = order.ID;
                var customer = order.Customer.Email;
                var products = Utils.ProductsInline(order.Products);
                var address = order.Addresss;
                var payment = order.PayState;
                var state = order.State;
                allOrdersGridView.Rows.Add(id, customer, products, address, payment, state);
            }
        }
        private void InitializeActiveOrdersView()
        {
            var orders = OrderManager.GetActive();
            activeOrdersGridView.Rows.Clear();
            foreach (Order order in orders)
            {
                var id = order.ID;
                var customer = order.Customer.Email;
                var products = Utils.ProductsInline(order.Products);
                var address = order.Addresss;
                var payment = order.PayState;
                var state = order.State;
                activeOrdersGridView.Rows.Add(id, customer, products, address, payment, state);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedTab.Name)
            {
                case "allOrdersTab":
                    InitializeAllOrdersView();
                    return;
                case "activeOrdersTab":
                    InitializeActiveOrdersView();
                    return;
                case "usersTab":
                    InitializeUsersView();
                    return;
            }
        }
    }
}
