class Program
{
    static void Main()
    {
        MainMenu();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("--- Math Game ---");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("-----------------");
            Console.Write("Your choice: ");

            string? userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return;
                case "1":
                    Gameplay("+");
                    break;
                case "2":
                    Gameplay("-");
                    break;
                case "3":
                    Gameplay("*");
                    break;
                case "4":
                    Gameplay("/");
                    break;
                default:
                    break;
            }
        }
    }

    static void Gameplay(string operation)
    {
        Random random = new();
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();

            int result = 0;
            int a = 0;
            int b = 0;

            if (operation == "/")
            {
                result = random.Next(1, 11);

                b = random.Next(1, 11);
                a = b * result;
            }
            else
            {
                a = random.Next(0, 11);
                b = random.Next(0, 11);

                result = operation switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    _ => throw new NotImplementedException(),
                };
            }

            Console.Write($"{i + 1}. {a} {operation} {b}: ");
            string? input = Console.ReadLine();
            int userAnswer = 0;

            while (!int.TryParse(input, out userAnswer))
            {
                Console.Write("Invalid input. Try again: ");
                input = Console.ReadLine();
            }

            if (userAnswer == result)
            {
                Console.WriteLine("You are right!");
                Console.ReadKey();
                score++;
            }
            else
            {
                Console.WriteLine($"You are wrong. Correct answer: {result}");
                Console.ReadKey();
            }
        }
    }
}