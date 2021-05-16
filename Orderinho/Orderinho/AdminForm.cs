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
                var price = order.Price;
                allOrdersGridView.Rows.Add(id, customer, products, address, payment, state, price);
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
                var price = order.Price;
                activeOrdersGridView.Rows.Add(id, customer, products, address, payment, state, price);
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

        private void ordersEditButton_Click(object sender, EventArgs e)
        {
            int id = (int)allOrdersGridView.SelectedCells[0].OwningRow.Cells[0].Value;
            var order = OrderManager.GetOrderByID(id);
            var oView = new OrderView(order);
            oView.ShowDialog();
            InitializeAllOrdersView();
        }

        private void activeEditButton_Click(object sender, EventArgs e)
        {
            int id = (int)activeOrdersGridView.SelectedCells[0].OwningRow.Cells[0].Value;
            var order = OrderManager.GetOrderByID(id);
            var oView = new OrderView(order);
            oView.ShowDialog();
            InitializeActiveOrdersView();
        }

        private void usersEditButton_Click(object sender, EventArgs e)
        {
            int id = (int)usersGridView.SelectedCells[0].OwningRow.Cells[0].Value;
            var user = UserManager.GetUserByID(id);
            var uView= new UserView(user);
            uView.ShowDialog();
            InitializeUsersView();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserManager.LogOut();
            Close();
        }
    }
}
