using System.Collections.Generic;
using System.Linq;

namespace Orderinho
{
    public static class ProductManager
    {
        /// <summary>
        /// Get all products method.
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetAllProducts()
        {
            return ProductsDataBase.Read();
        }
        /// <summary>
        /// Get product instance by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Product GetProductByID(int id)
        {
            return GetAllProducts().Where(x => x.ID == id).First();
        }
    }
}
