using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    public abstract class Drink
    {
        protected string detail = "Unknow Drink";
        public string getDetail()
        {
            return detail;
        }
        public abstract double price();
    }
}
