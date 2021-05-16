using System;
using System.Collections.Generic;
using System.Linq;

namespace Orderinho
{
    public class Cart
    {
        public User Customer { get; set; }
        public Dictionary<int, int> Products { get; set; }
        public double Price
        {
            get
            {
                double result = 0;
                var products = ProductManager.GetAllProducts();
                foreach (int id in Products.Keys)
                {
                    result += products.Where(x => x.ID == id).First().Price * Products[id];
                }
                return result;
            }
        }
        public Cart(User customer)
        {
            Customer = customer;
            Products = new Dictionary<int, int>();
        }
        public Cart(User customer, Dictionary<int, int> products) : this(customer)
        {
            Products = new Dictionary<int, int>(products);
        }
        /// <summary>
        /// Add a product to cart.
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            if (Products.Keys.Contains(product.ID))
            {
                Products[product.ID]++;
            }
            else
            {
                Products.Add(product.ID, 1);
            }
        }
        /// <summary>
        /// Remove a product from cart.
        /// </summary>
        /// <param name="product"></param>
        public void Remove(Product product)
        {
            if (Products.Keys.Contains(product.ID))
            {
                Products[product.ID]--;
                if (Products[product.ID] == 0)
                {
                    Products.Remove(product.ID);
                }
            }
        }
        /// <summary>
        /// Make an order from existing cart.
        /// </summary>
        /// <returns></returns>
        public Order CreateOrder()
        {
            return new Order(OrderManager.GetAllOrders().Count + 1, Customer, Products);
        }
    }
}
