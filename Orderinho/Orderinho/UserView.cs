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
    public partial class UserView : Form
    {
        public User SelectedUser;
        public UserView()
        {
            InitializeComponent();
        }
        public UserView(User user) : this()
        {
            SelectedUser = user;
            InitializeContaining();
        }
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
        private void InitializeOrders()
        {
            var orders = OrderManager.GetOrdersByCustomer(SelectedUser);
            var price = orders.Sum(x => x.PayState == PaymentState.Paid? x.Price: 0);
            foreach (var order in orders)
            {
                ordersPanel.Items.Add($"Order ID: {order.ID}");
            }
            priceLabel.Text = $"{price} RUB";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
