using System;
using System.Drawing;
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
        public ProductCard(Product product, int counter = 0) : this()
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
        /// <summary>
        /// Add button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            ++Counter;
            countLabel.Text = Counter.ToString();
            UserForm.CurrentCart.Add(ProductHolder);
            OrderManager.SaveCart(UserForm.CurrentCart);
        }
        /// <summary>
        /// Remvoe button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (Counter > 0)
            {
                --Counter;
            }
            countLabel.Text = Counter.ToString();
            UserForm.CurrentCart.Remove(ProductHolder);
            OrderManager.SaveCart(UserForm.CurrentCart);
        }
    }
}
