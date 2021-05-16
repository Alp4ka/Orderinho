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
            return temp.Where(x => x.State != OrderState.Done).ToList();
        }
        public static List<Order> GetByState(OrderState state, User user = null)
        {
            var orders = GetAllOrders();
            return user == null ? 
                orders.Where(x => x.State == state).ToList() : 
                orders.Where(x => x.State == state && x.Customer.ID == user.ID).ToList();
        }
        public static List<Order> GetByState(PaymentState payment, User user = null)
        {
            var orders = GetAllOrders();
            return user == null ? 
                orders.Where(x => x.PayState == payment).ToList() : 
                orders.Where(x => x.PayState == payment && x.Customer.ID == user.ID).ToList();
        }
        public static List<Order> GetByState(OrderState state, PaymentState payment, User user = null)
        {
            var orders = GetAllOrders();
            return user == null ?
                orders.Where(x => x.PayState == payment && x.State == state).ToList() :
                orders.Where(x => x.PayState == payment && x.State == state && x.Customer.ID == user.ID).ToList();
        }
        public static Order GetOrderByID(int id)
        {
            return GetAllOrders().Where(x => x.ID == id).First();
        }
        /// <summary>
        /// Add order to database.
        /// </summary>
        /// <param name="order"></param>
        public static void Confirm(Order order, string address)
        {
            order.Addresss = address;
            OrdersDataBase.Add(order);
        }
        public static List<Order> GetOrdersByCustomer(User user)
        {
            return GetAllOrders().Where(x => x.Customer.ID == user.ID).ToList();
        }
        public static void UpdateOrder(Order order)
        {
            OrdersDataBase.UpdateOrder(order);
        }
    }
}