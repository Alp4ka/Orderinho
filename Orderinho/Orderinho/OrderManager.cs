using System.Collections.Generic;
using System.Linq;
namespace Orderinho
{
    /// <summary>
    /// Calls commands from OrdersDataBase class.
    /// </summary>
    public static class OrderManager
    {
        public static List<Order> GetAllOrders()
        {
            return OrdersDataBase.Read();
        }
        /// <summary>
        /// Get cart linked with current user.
        /// </summary>
        /// <returns></returns>
        public static Cart GetCart()
        {
            var cart = OrdersDataBase.GetCart(UserManager.CurrentUser);
            return cart;
        }
        /// <summary>
        /// Save current cart.
        /// </summary>
        /// <param name="cart"></param>
        public static void SaveCart(Cart cart)
        {
            OrdersDataBase.SaveCart(cart);
        }
        /// <summary>
        /// Get active orders.
        /// </summary>
        /// <returns></returns>
        public static List<Order> GetActive()
        {
            var temp = GetAllOrders();
            return temp.Where(x => x.State != OrderState.Done).ToList();
        }
        /// <summary>
        /// Get orders filterd by state.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<Order> GetByState(OrderState state, User user = null)
        {
            var orders = GetAllOrders();
            return user == null ?
                orders.Where(x => x.State == state).ToList() :
                orders.Where(x => x.State == state && x.Customer.ID == user.ID).ToList();
        }
        /// <summary>
        /// Get orders filterd by state.
        /// </summary>
        /// <param name="payment"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<Order> GetByState(PaymentState payment, User user = null)
        {
            var orders = GetAllOrders();
            return user == null ?
                orders.Where(x => x.PayState == payment).ToList() :
                orders.Where(x => x.PayState == payment && x.Customer.ID == user.ID).ToList();
        }
        /// <summary>
        /// Get orders filterd by state.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="payment"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<Order> GetByState(OrderState state, PaymentState payment, User user = null)
        {
            var orders = GetAllOrders();
            return user == null ?
                orders.Where(x => x.PayState == payment && x.State == state).ToList() :
                orders.Where(x => x.PayState == payment && x.State == state && x.Customer.ID == user.ID).ToList();
        }
        /// <summary>
        /// Get order instance by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Get orders by their customer.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<Order> GetOrdersByCustomer(User user)
        {
            return GetAllOrders().Where(x => x.Customer.ID == user.ID).ToList();
        }
        /// <summary>
        /// Update existing order.
        /// </summary>
        /// <param name="order"></param>
        public static void UpdateOrder(Order order)
        {
            OrdersDataBase.UpdateOrder(order);
        }
    }
}