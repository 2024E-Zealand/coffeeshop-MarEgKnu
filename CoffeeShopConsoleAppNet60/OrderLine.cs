using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class OrderLine
    {

        public OrderLine(int amount, Coffee item)
        {
            if (amount > 1)
            {
                throw new ArgumentOutOfRangeException("Antal kan ikke være 0 eller mindre");
            }
            Amount = amount;
            Item = item;
        }
        public int Amount { get; set; }

        public Coffee Item { get; set; }

        public int PriceWithDiscount()
        {
            return Item.PriceWithDiscount() * Amount;
        }
        public int Price()
        {
            return Item.Price() * Amount;
        }
        public int TotalDiscount()
        {
            return Item.Price() - Item.PriceWithDiscount();
        }
    }
}
