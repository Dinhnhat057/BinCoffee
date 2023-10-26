using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Latte : Drink
    {
        public Latte()
        {
            detail = " Latte";
        }
        public override double price()
        {
            return 2.50;
        }

    }
}
