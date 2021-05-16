using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderinho
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            InitializeAllOrdersView();
        }
        private void InitializeUsersView()
        {
            var orders = OrderManager.GetAllOrders();
            foreach(Order order in orders)
            {
                var id = order.ID;
                var customer = order.Customer.Email;
            }
        }
        private void InitializeAllOrdersView()
        {
            var orders = OrderManager.GetAllOrders();
            foreach (Order order in orders)
            {
                var id = order.ID;
                var customer = order.Customer.Email;
            }
        }
        private void InitializeActiveOrdersView()
        {
            var orders = OrderManager.GetAllOrders();
            foreach (Order order in orders)
            {
                var id = order.ID;
                var customer = order.Customer.Email;
            }
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl.SelectedTab.Name){
                case "allOrdersTab":
                    InitializeAllOrdersView();
                    return;
                case "activeOrdersTab":
                    InitializeActiveOrdersView();
                    return;
                case "usersTab":
                    InitializeUsersView();
                    return;
            }
        }
    }
}
