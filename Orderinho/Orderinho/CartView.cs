using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Orderinho
{
    public partial class CartView : Form
    {
        public bool OnClose { get; private set; }
        private Cart CurrentCart;
        private List<Product> Products;
        public CartView()
        {
            OnClose = false;
            Products = new List<Product>();
            InitializeComponent();
        }
        public CartView(Cart cart) : this()
        {
            CurrentCart = cart;
            InitializeContaining();
        }
        /// <summary>
        /// Initialize containing method.
        /// </summary>
        private void InitializeContaining()
        {
            var products = CurrentCart.Products;
            double sum = 0;
            foreach (var product in products)
            {
                var temp = ProductManager.GetProductByID(product.Key);
                Products.Add(temp);
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
            if (String.IsNullOrWhiteSpace(addressTb.Text))
            {
                MessageBox.Show("Fill adrress field!");
            }
            else if (addressTb.Text.Length > 128)
            {
                MessageBox.Show("I am not sure your address may content more than 128 symbols.");
            }
            else if (Products.Count == 0)
            {
                MessageBox.Show("Emty Cart:c");
            }
            else
            {
                var order = CurrentCart.CreateOrder();
                OrderManager.Confirm(order, addressTb.Text);
                OnClose = true;
                MessageBox.Show("You have successfully made an order!");
                Close();
            }
        }
    }
}
