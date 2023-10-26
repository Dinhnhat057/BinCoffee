using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO BIN CYBER AND COFFEE");
            BinCoffeeMenu menu = new BinCoffeeMenu();
            menu.Loading();
            menu.ShowDrink();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
