using MathGame;

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

                Console.Write("Enter an option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Game.StartGame("+");
                        break;
                    case "2":
                        Game.StartGame("-");
                        break;
                    case "3":
                        Game.StartGame("*");
                        break;
                    case "4":
                        Game.StartGame("/");
                        break;
                    case "5":
                        Game.StartGame("random");
                        break;
                    case "6":
                        History.ShowHistory();
                        break;
                    case "7":
                        Console.WriteLine("Goodbye!");
                        return;
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
