using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Smoothie : Drink
    {
        public Smoothie()
        {
            detail = " Smoothie";
        }
        public override double price()
        {
            return 3.00;
        }
    }
}
