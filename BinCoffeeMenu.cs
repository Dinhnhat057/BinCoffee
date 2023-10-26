using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinCoffee1
{
    class BinCoffeeMenu
    {
        private Drink ordDrink = new Default();
        private Drink ordMilktea = new Milktea();
        private Drink ordLatte = new Latte();
        private Drink ordSmoothie = new Smoothie();
        private Drink ordFruitTea = new Fruittea();
        private Drink CusDrink;
        private bool cofirm = true;
        private char yesNo = 'N';
        private int chooseDrink;
        private int chooseTopping;
        public void Loading()
        {
            Console.WriteLine("\tWELCOME TO BINCOFFEE\t\n");
            ShowMenu();
            Console.WriteLine("\n\nPress any key to order!");
            Console.ReadLine();
            Console.Clear();
        }
        public void ShowMenu()
        {
            Drink ordPearl = new Pearl(ordDrink);
            Drink ordWhitepearl = new Whitepearl(ordDrink);
            Drink ordMilkfoam = new Milkfoam(ordDrink);
            Drink ordPudding = new Pudding(ordDrink);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|-----------   BinCoffee Menu  --------");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("|---------         Drinks     ---------");
            Console.ResetColor();
            Console.WriteLine($"| {ordMilktea.getDetail()}:     \t\t${ordMilktea.price()}");
            Console.WriteLine($"| {ordLatte.getDetail()}:         \t\t${ordLatte.price()}");
            Console.WriteLine($"| {ordSmoothie.getDetail()}:   \t\t${ordSmoothie.price()}");
            Console.WriteLine($"| {ordFruitTea.getDetail()}:   \t\t${ordFruitTea.price()}");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("|---------        Topping     ---------");
            Console.ResetColor();
            Console.WriteLine($"| {ordPearl.getDetail()}:     \t\t${ordPearl.price()}");
            Console.WriteLine($"| {ordWhitepearl.getDetail()}:\t\t${ordWhitepearl.price()}");
            Console.WriteLine($"| {ordMilkfoam.getDetail()}:  \t\t${ordMilkfoam.price()}");
            Console.WriteLine($"| {ordPudding.getDetail()}:   \t\t${ordPudding.price()}");
        }
        public void Bill()
        {
            Console.WriteLine("|-----------  Customer Order  -------|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|-----------Drink and Topping--------|");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("|---------       Price       --------|");
            Console.ResetColor();
            Console.WriteLine($"|{CusDrink.price()}");
            Console.WriteLine("|---Thank you and enjoy your drink---|");
        }
        public void ShowDrink()
        {
            Console.WriteLine("|---------        BinCoffee     ---------");
            Console.WriteLine($"| [1]\t{ordMilktea.getDetail()}: \t\t${ordMilktea.price()}");
            Console.WriteLine($"| [2]\t{ordLatte.getDetail()}: \t\t${ordLatte.price()}");
            Console.WriteLine($"| [3]\t{ordSmoothie.getDetail()}:\t\t${ordSmoothie.price()}");
            Console.WriteLine($"| [4]\t{ordFruitTea.getDetail()}: \t\t${ordFruitTea.price()}");
            Console.WriteLine("========================================");
            Console.WriteLine("|----- Press 1 - 4 to choose drink ---|");
            chooseDrink = Int32.Parse(Console.ReadLine());
            try
            {
                while (cofirm)
                {
                    switch (chooseDrink)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{ordMilktea.getDetail()}: ${ordMilktea.price()}");
                            Console.ResetColor();
                            CusDrink = new Milktea();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{ordLatte.getDetail()}: ${ordLatte.price()}");
                            Console.ResetColor();
                            CusDrink = new Latte();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{ordSmoothie.getDetail()}: ${ordSmoothie.price()}");
                            Console.ResetColor();
                            CusDrink = new Smoothie();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{ordFruitTea.getDetail()}: ${ordFruitTea.price()}");
                            Console.ResetColor();
                            CusDrink = new Milktea();
                            break;
                        default:
                            break;
                    }
                    if (chooseDrink > 4)
                    {
                        Console.WriteLine("----Please press 1 - 4 to choose drink ---");
                        chooseDrink = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("---Do you confirm this Drink? (Y o N): ");
                        yesNo = char.Parse(Console.ReadLine());
                        if (yesNo == 'Y' || yesNo == 'y')
                            break;
                        Console.WriteLine("|---- Press 1 - 4 to choose drink ---|");
                        chooseDrink = Int32.Parse(Console.ReadLine());
                        break;
                    }
                }
            }
            catch (System.Exception)
            {
                try
                {
                    Console.WriteLine("---Do you want to add topping in your drink? (Y o N): ");
                    yesNo = char.Parse(Console.ReadLine());
                    if (yesNo == 'y' || yesNo == 'Y')
                    {
                        ShowTopping();
                    }
                    else
                    {
                        cofirm = false;
                        Bill();
                    }

                }
                catch (System.Exception)
                {
                    ShowTopping();
                }
            }
            if (cofirm)
            {
                try
                {
                    Console.WriteLine("---Do you want add more Topping? (Y o N): ");
                    yesNo = char.Parse(Console.ReadLine());
                    if (yesNo == 'y' || yesNo == 'Y')
                    {
                        ShowTopping();
                    }
                    else Bill();
                }
                catch (System.Exception)
                {
                    ShowTopping();
                }
            }
        }
        public void ShowTopping()
        {
            Drink ordPearl = new Pearl(ordDrink);
            Drink ordWhitepearl = new Whitepearl(ordDrink);
            Drink ordMilkfoam = new Milkfoam(ordDrink);
            Drink ordPudding = new Pudding(ordDrink);
            Console.WriteLine("|--------       Topping      ---------|");
            Console.WriteLine($"| [1]\t{ordPearl.getDetail()}:       \t${ordPearl.price()}");
            Console.WriteLine($"| [2]\t{ordWhitepearl.getDetail()}:  \t${ordWhitepearl.price()}");
            Console.WriteLine($"| [3]\t{ordMilkfoam.getDetail()}:    \t${ordMilkfoam.price()}");
            Console.WriteLine($"| [4]\t{ordPudding.getDetail()}:     \t${ordPudding.price()}");
            try
            {
                Console.WriteLine("========================================");
                Console.WriteLine("|---- Press 1 - 4 to choose Topping ----|");
                chooseTopping = Int32.Parse(Console.ReadLine());
                while (cofirm)
                {
                    switch (chooseTopping)
                    {
                        case 1:
                            CusDrink = new Pearl(CusDrink);
                            Console.WriteLine($"Add: {ordPearl.getDetail()}");
                            break;
                        case 2:
                            CusDrink = new Whitepearl(CusDrink);
                            Console.WriteLine($"Add: {ordWhitepearl.getDetail()}");
                            break;
                        case 3:
                            CusDrink = new Milkfoam(CusDrink);
                            Console.WriteLine($"Add: {ordMilkfoam.getDetail()}");
                            break;
                        case 4:
                            CusDrink = new Pudding(CusDrink);
                            Console.WriteLine($"Add: {ordPudding.getDetail()}");
                            break;
                        default:
                            break;
                    }
                    if (chooseTopping > 4)
                    {
                        Console.WriteLine("|----Please press 1 - 4 to choose Topping---|");
                    }
                    Console.WriteLine("-----Press 1 - 4 to add more Topping or Enter to compelete----");
                    chooseTopping = Int32.Parse(Console.ReadLine());
                }
            }
            catch (System.Exception)
            {
                cofirm = false;
                Bill();
            }
        }
    }
}
