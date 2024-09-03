using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class OrderSystem
    {
        public OrderSystem()
        {
            Orders = new Dictionary<int, Order>();
        }
        public Dictionary<int, Order> Orders { get; set; }

        public bool AddOrder(Order order)
        {
            return Orders.TryAdd(order.OrderId, order);           
        }
        public bool RemoveOrder(int orderId)
        {
            return Orders.Remove(orderId);
        }
        public bool ProcessOrder(int id)
        {
            bool found = Orders.TryGetValue(id, out Order order);
            if (order == null || !found)
            {
                return false;
            }
            order.ProcessOrder();
            return true;

        }
    }
}
