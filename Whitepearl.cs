using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Whitepearl : Drink
    {
        private Drink drink;
        public Whitepearl(Drink drink)
        {
            this.drink = drink;
            detail = " White pearl";
        }
        public override double price()
        {
            return drink.price() + 0.50;
        }
    }
}
