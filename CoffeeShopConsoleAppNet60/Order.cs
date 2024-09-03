using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Order
    {
        
        public Order(string baristaName, string customerName, int? tableId)
        {
            OrderLines = new List<OrderLine>();
            Processed = false;
            BaristaName = baristaName;
            CustomerName = customerName;
            TableId = tableId;
            OrderId = counter;
            counter++;

        }
        private static int counter = 1;
        public int OrderId { get; set; }

        public string BaristaName { get; set; }

        public string CustomerName { get; set; }

        public int? TableId { get; set; }

        public bool Processed { get; private set; }

        public List<OrderLine> OrderLines { get; set; }

        public bool AddOrderLine(OrderLine line)
        {
            if (line  == null)
            {
                return false;
            }
            OrderLines.Add(line);
            return true;
        }
        public int OrderPriceWithDiscount()
        {
            int result = 0;
            foreach (OrderLine line in OrderLines)
            {
                result += line.PriceWithDiscount();
            }
            return result;
        }
        public int OrderPrice()
        {
            int result = 0;
            foreach (OrderLine line in OrderLines)
            {
                result += line.Price();
            }
            return result;
        }
        public int OrderDiscount()
        {
            int result = 0;
            foreach (OrderLine line in OrderLines)
            {
                result += (line.Price() - line.PriceWithDiscount());
            }
            return result;
        }
        public void ProcessOrder()
        {
            Processed = true;
        }
    }
}
