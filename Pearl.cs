using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Pearl : Drink
    {
        private Drink drink;
        public Pearl(Drink drink)
        {
            this.drink = drink;
            detail = "Pearl";
        }
        public override double price()
        {
            return drink.price() + 0.50;
        }
    }
}
