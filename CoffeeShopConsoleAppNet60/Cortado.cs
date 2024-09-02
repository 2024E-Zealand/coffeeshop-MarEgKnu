using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(int discount) : base(discount)
        {
        }

        public int mlMilk()
        {
            return 40;
        }

        public override int Price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public override int PriceWithDiscount()
        {
            return Price() - Discount;
        }

        public override int Discount { get; set; }
    }
}
