using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Fruittea : Drink
    {
        public Fruittea()
        {
            detail = " Fruit tea";
        }
        public override double price()
        {
            return 2.00;
        }
    }
}
