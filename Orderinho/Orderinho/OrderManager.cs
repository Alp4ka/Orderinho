using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderinho
{
    public static class OrderManager
    {
        public static List<Order> GetAllOrders()
        {
            return OrdersDataBase.Read();
        }
        public static Cart GetCart()
        {
            var cart = OrdersDataBase.GetCart(UserManager.CurrentUser);
            //MessageBox.Show($"{Utils.ProductsInline(cart.Products)}");
            return cart;
        }
        public static void SaveCart(Cart cart)
        {
            OrdersDataBase.SaveCart(cart);
        }
        public static List<Order> GetActive()
        {
            var temp = GetAllOrders();
            return temp.Where(x=>x.State != OrderState.Done).ToList();
        }
    }
}
