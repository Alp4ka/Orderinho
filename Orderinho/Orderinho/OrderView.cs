using System;
using System.Windows.Forms;

namespace Orderinho
{
    public partial class OrderView : Form
    {
        public Order SelectedOrder;
        public OrderView()
        {
            InitializeComponent();
        }
        public OrderView(Order order) : this()
        {
            SelectedOrder = order;
            InitializeStateTb();
            InitializePaymentTb();
            InitializeOrder();
        }
        /// <summary>
        /// Initialize textBox with order.state property.
        /// </summary>
        private void InitializeStateTb()
        {
            stateTb.Items.Clear();
            stateTb.Items.Add(OrderState.Processed);
            stateTb.Items.Add(OrderState.Shipped);
            stateTb.Items.Add(OrderState.Done);
        }
        /// <summary>
        /// Initialize textBox with order.payState property.
        /// </summary>
        private void InitializePaymentTb()
        {
            paymentTb.Items.Clear();
            paymentTb.Items.Add(PaymentState.NonPaid);
            paymentTb.Items.Add(PaymentState.Paid);
        }
        /// <summary>
        /// Initialize order containing with order's  products.
        /// </summary>
        private void InitializeOrder()
        {
            idTb.Text = SelectedOrder.ID.ToString();
            customerTb.Text = SelectedOrder.Customer.Email.ToString();
            InitializeContaining();
            stateTb.SelectedIndex = stateTb.Items.IndexOf(SelectedOrder.State);
            paymentTb.SelectedIndex = paymentTb.Items.IndexOf(SelectedOrder.PayState);
        }
        /// <summary>
        /// Initialize order with order's values.
        /// </summary>
        private void InitializeContaining()
        {
            var products = SelectedOrder.Products;
            double sum = 0;
            foreach (var product in products)
            {
                var temp = ProductManager.GetProductByID(product.Key);
                contentPanel.Items.Add($"{temp.Name} | {temp.Price} RUB | {product.Value}x");
                contentPanel.Items.Add($"-");
                sum += temp.Price * product.Value;
            }
            priceLabel.Text = $"{sum} RUB";
        }
        /// <summary>
        /// Confirm button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((PaymentState)paymentTb.SelectedItem == SelectedOrder.PayState &&
                    (OrderState)stateTb.SelectedItem == SelectedOrder.State)
                {
                    Close();
                }
                else
                {
                    if ((PaymentState)paymentTb.SelectedItem != SelectedOrder.PayState)
                    {
                        SelectedOrder.PayState = (PaymentState)paymentTb.SelectedItem;
                    }
                    if ((OrderState)stateTb.SelectedItem != SelectedOrder.State)
                    {
                        SelectedOrder.State = (OrderState)stateTb.SelectedItem;
                    }
                    OrderManager.UpdateOrder(SelectedOrder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                stateTb.SelectedIndex = stateTb.Items.IndexOf(SelectedOrder.State);
                paymentTb.SelectedIndex = paymentTb.Items.IndexOf(SelectedOrder.PayState);
            }
        }
    }
}
