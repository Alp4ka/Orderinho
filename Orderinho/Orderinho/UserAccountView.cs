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
    public partial class UserAccountView : Form
    {
        public User SelectedUser;
        public UserAccountView()
        {
            InitializeComponent();
        }
        public UserAccountView(User user) : this()
        {
            SelectedUser = user;
            InitializeContaining();
        }
        /// <summary>
        /// Init orders.
        /// </summary>
        private void InitializeOrders()
        {
            var orders = OrderManager.GetOrdersByCustomer(SelectedUser);
            ordersGridView.Rows.Clear();
            foreach (Order order in orders)
            {
                var id = order.ID;
                var products = Utils.ProductsInline(order.Products);
                var address = order.Addresss;
                var payment = order.PayState;
                var state = order.State;
                var price = $"{order.Price} RUB";
                ordersGridView.Rows.Add(id, products, address, payment, state, price);
            }
        }
        /// <summary>
        /// Init containing.
        /// </summary>
        private void InitializeContaining()
        {
            idTb.Text = SelectedUser.ID.ToString();
            nameTb.Text = SelectedUser.Name;
            surnameTb.Text = SelectedUser.Surname;
            midnameTb.Text = SelectedUser.Midname;
            emailTb.Text = SelectedUser.Email;
            telephoneTb.Text = SelectedUser.Telephone;
            InitializeOrders();
        }
        /// <summary>
        /// Confirm button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
