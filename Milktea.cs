using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public class Milktea : Drink
    {
        public Milktea()
        {
            detail = " Milk Tea";
        }
        public override double price()
        {
            return 2.00;
        }
    }
}
