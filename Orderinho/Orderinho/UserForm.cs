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
        public void InitializeCart()
        {
            CurrentCart = OrderManager.GetCart();
            if(CurrentCart == null)
            {
                CurrentCart = new Cart(UserManager.CurrentUser);
                OrderManager.SaveCart(CurrentCart);
            }
        }


        public void InitializeProductCards()
        {
            var products = ProductManager.GetAllProducts();
            int cnt = 0;
            foreach(Product product in products)
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
                card.Location = new Point(0, (card.Height + 10)*cnt);
                ++cnt;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserManager.LogOut();
            Close();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            CartView cView = new CartView(CurrentCart);
            cView.ShowDialog();
            if (cView.OnClose)
            {
                Close();
            }
        }
    }
}
