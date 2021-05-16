using System;
using System.Drawing;
using System.Windows.Forms;

namespace Orderinho
{
    public partial class UserForm : Form
    {
        public static Cart CurrentCart;
        public UserForm()
        {
            InitializeComponent();
            userInfo.Text = "Hello, " + UserManager.CurrentUser.ToString() + "!";
            InitializeCart();
            //MessageBox.Show($"{Utils.ProductsInline(CurrentCart.Products)}");
            InitializeProductCards();
        }
        /// <summary>
        /// Initialize cart.
        /// </summary>
        public void InitializeCart()
        {
            CurrentCart = OrderManager.GetCart();
            if (CurrentCart == null)
            {
                CurrentCart = new Cart(UserManager.CurrentUser);
                OrderManager.SaveCart(CurrentCart);
            }
        }
        /// <summary>
        /// Initialize cards with products in panel.
        /// </summary>
        public void InitializeProductCards()
        {
            var products = ProductManager.GetAllProducts();
            int cnt = 0;
            foreach (Product product in products)
            {
                ProductCard card;
                if (CurrentCart.Products.ContainsKey(product.ID))
                {
                    card = new ProductCard(product, CurrentCart.Products[product.ID]);
                }
                else
                {
                    card = new ProductCard(product);
                }

                productsPanel.Controls.Add(card);
                card.Location = new Point(0, (card.Height + 10) * cnt);
                ++cnt;
            }
        }
        /// <summary>
        /// Logout button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserManager.LogOut();
            Close();
        }
        /// <summary>
        /// Cart button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cartButton_Click(object sender, EventArgs e)
        {
            CartView cView = new CartView(CurrentCart);
            cView.ShowDialog();
            if (cView.OnClose)
            {
                Close();
            }
        }

        private void userInfo_Click(object sender, EventArgs e)
        {
            var uAView = new UserAccountView(UserManager.CurrentUser);
            Hide();
            uAView.ShowDialog();
            Show();
        }
    }
}
