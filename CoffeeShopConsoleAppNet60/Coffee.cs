using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        protected Coffee(int discount)
        {
            if (discount > Price())
            {
                throw new ArgumentException("Discount kan ikke være større end pris");
            }
            Discount = discount;
        }
        public abstract int Price();

        public abstract int PriceWithDiscount();

        public abstract string Strength();

        public abstract int Discount { get; set; }
    }
}
