using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderinho
{
    public class Order
    {
        public int ID { get; private set; }
        public User Customer { get; set; }
        private OrderState _state;
        private PaymentState _payState;
        public OrderState State
        {
            get
            {
                return _state;
            }
            set
            {
                if(value != OrderState.Processed && PayState == PaymentState.NonPaid)
                {
                    throw new ArgumentException("Order is unpaid. You can't change its status!"); 
                }
                else
                {
                    _state = value;
                }
            }
        }
        public PaymentState PayState { 
            get => _payState;
            set 
            {
                if(_payState == PaymentState.NonPaid &&
                    value == PaymentState.Paid && 
                    State == OrderState.Processed)
                {
                    _payState = value;
                }
                else
                {
                    throw new ArgumentException("You can pay only for processed orders!");
                }
            }
        }
        // product_id, count
        public Dictionary<int, int> Products { get; set; }
        public double Price {
            get
            {
                double result = 0;
                var products = ProductManager.GetAllProducts();
                foreach(int id in Products.Keys)
                {
                    result += products.Where(x => x.ID == id).First().Price * Products[id];
                }
                return result;
            }
        }
        public Order(User customer, Dictionary<int, int> products, int id)
        {
            ID = id;
            Customer = customer;
            PayState = PaymentState.NonPaid;
            State = OrderState.Processed;
            Products = new Dictionary<int, int>(products);
        }
    }
    
    public enum PaymentState
    {
        NonPaid = 0,
        Paid = 1
    }
    public enum OrderState
    {
        Processed = 0,
        Shipped = 1,
        Done = 2
    }
}
