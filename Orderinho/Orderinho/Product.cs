namespace Orderinho
{
    public class Product
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageLink { get; set; }
        /// <summary>
        /// Compares two elements. In case if they are equal ,return true; otherwise - false.
        /// </summary>
        /// <param name="product1"></param>
        /// <param name="product2"></param>
        /// <returns></returns>
        public static bool IsEqual(Product product1, Product product2)
        {
            if (product1.ID == product2.ID)
            {
                return true;
            }
            return false;
        }
        public Product(int id, string name, double price, string imageLink = "", string description = "")
        {
            Name = name;
            Description = description;
            ID = id;
            Price = price;
            ImageLink = imageLink;
        }
    }
}
