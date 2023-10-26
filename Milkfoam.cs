using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Milkfoam : Drink
    {
        private Drink drink;
        public Milkfoam(Drink drink)
        {
            this.drink = drink;
            detail = "Milk foam";
        }
        public override double price()
        {
            return drink.price() + 1.00;
        }
    }
}
