using System;
using System.Linq;
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
        /// <summary>
        /// Initialize containing.
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
        /// Initialize orders.
        /// </summary>
        private void InitializeOrders()
        {
            var orders = OrderManager.GetOrdersByCustomer(SelectedUser);
            var price = orders.Sum(x => x.PayState == PaymentState.Paid ? x.Price : 0);
            foreach (var order in orders)
            {
                ordersPanel.Items.Add($"Order ID: {order.ID}");
            }
            priceLabel.Text = $"{price} RUB";
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
