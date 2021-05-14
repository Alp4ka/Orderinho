using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Orderinho
{
    public static class Utils
    {
        public static string Encode(string source)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
            byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
            string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            return hash;
        }
        public static string ProductsInline(Dictionary<int, int> products)
        {
            List<int> resulting = new List<int>();
            foreach(int key in products.Keys)
            {
                for(int i =0; i < products[key]; ++i)
                {
                    resulting.Add(key);
                }
            }
            return String.Join(" ", resulting);
        }
        public static Dictionary<int, int> ParseProducts(string line)
        {
            var result = new Dictionary<int, int>();
            var products = ProductManager.GetAllProducts();
            var splitted = line.Split(' ');
            foreach(var elem in splitted)
            {
                int id = int.Parse(elem);
                Product product = products.Where(x => x.ID == id).First();
                if(result.ContainsKey(product.ID))
                {
                    result[product.ID]++;
                }
                else
                {
                    result.Add(product.ID, 1);
                }
            }
            return result;
        }
    }
}
