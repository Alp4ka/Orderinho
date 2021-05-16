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
    public partial class OrderView : Form
    {
        public Order SelectedOrder;
        public OrderView()
        {
            InitializeComponent();
        }
        public OrderView(Order order):this()
        {
            SelectedOrder = order;
            InitializeStateTb();
            InitializePaymentTb();
            InitializeOrder();
        }
        private void InitializeStateTb()
        {
            stateTb.Items.Clear();
            stateTb.Items.Add(OrderState.Processed);
            stateTb.Items.Add(OrderState.Shipped);
            stateTb.Items.Add(OrderState.Done);
        }
        private void InitializePaymentTb()
        {
            paymentTb.Items.Clear();
            paymentTb.Items.Add(PaymentState.NonPaid);
            paymentTb.Items.Add(PaymentState.Paid);
        }
        private void InitializeOrder()
        {
            idTb.Text = SelectedOrder.ID.ToString();
            customerTb.Text = SelectedOrder.Customer.Email.ToString();
            InitializeContaining();
            stateTb.SelectedIndex= stateTb.Items.IndexOf(SelectedOrder.State);
            paymentTb.SelectedIndex = paymentTb.Items.IndexOf(SelectedOrder.PayState);
        }
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if((PaymentState)paymentTb.SelectedItem == SelectedOrder.PayState && 
                    (OrderState)stateTb.SelectedItem == SelectedOrder.State)
                {
                    Close();
                }
                else
                {
                    if((PaymentState)paymentTb.SelectedItem != SelectedOrder.PayState)
                    {
                        SelectedOrder.PayState = (PaymentState)paymentTb.SelectedItem;
                    }
                    if((OrderState)stateTb.SelectedItem != SelectedOrder.State)
                    {
                        SelectedOrder.State = (OrderState)stateTb.SelectedItem;
                    }
                    OrderManager.UpdateOrder(SelectedOrder);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                stateTb.SelectedIndex = stateTb.Items.IndexOf(SelectedOrder.State);
                paymentTb.SelectedIndex = paymentTb.Items.IndexOf(SelectedOrder.PayState);
            }
        }
    }
}
