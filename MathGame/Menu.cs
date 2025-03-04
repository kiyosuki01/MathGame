using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class Menu
    {
        internal static void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Math Game ---");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Random Game");
                Console.WriteLine("6. Game History");
                Console.WriteLine("7. Exit");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3:
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
