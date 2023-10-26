using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Pudding : Drink
    {
        private Drink drink;
        public Pudding(Drink drink)
        {
            this.drink = drink;
            detail = "Pudding";
        }
        public override double price()
        {
            return drink.price() + 1.00;
        }
    }
}
