using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Order
    {
        public int OrderId { get; set; }

        public string BaristaName { get; set; }

        public string CustomerName { get; set; }

        public int? TableId { get; set; }
    }
}
