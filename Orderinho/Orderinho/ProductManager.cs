using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderinho
{
    public static class ProductManager
    {
        public static List<Product> GetAllProducts()
        {
            return ProductsDataBase.Read();
        }
        public static Product GetProductByID(int id)
        {
            return GetAllProducts().Where(x => x.ID == id).First();
        }
    }
}
