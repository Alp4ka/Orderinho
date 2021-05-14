using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderinho
{
    public partial class ProductCard : UserControl
    {
        public int Counter { get; set; }
        public ProductCard()
        {
            InitializeComponent();
        }
        public ProductCard(Product product, int counter = 0):this()
        {
            ProductHolder = product;
            nameLabel.Text = product.Name;
            descriptionLabel.Text = product.Description;
            priceLabel.Text = product.Price.ToString() + " RUB";
            try
            {
                productImage.Image = Image.FromFile(product.ImageLink);
            }
            catch
            {
                // Nothing special.
            }
            Counter = counter;
            countLabel.Text = Counter.ToString();
        }
        public Product ProductHolder { get; private set; }

        private void addButton_Click(object sender, EventArgs e)
        {
            ++Counter;
            countLabel.Text = Counter.ToString();
            UserForm.CurrentCart.Add(ProductHolder);
            OrderManager.SaveCart(UserForm.CurrentCart);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(Counter > 0)
            {
                --Counter;
            }
            countLabel.Text = Counter.ToString();
            UserForm.CurrentCart.Remove(ProductHolder);
            OrderManager.SaveCart(UserForm.CurrentCart);
        }
    }
}
