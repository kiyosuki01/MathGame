class Program
{
    static List<string> gameHistory = new List<string>();

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
            Console.WriteLine("5. Random");
            Console.WriteLine("6. Show Game History");
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
                case "5":
                    Gameplay("~");
                    break;
                case "6":
                    ShowGameHistory();
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

            string currentOperation = operation;

            int a = 0, b = 0, result = 0;

            if (operation == "~")
            {
                string[] operations = { "+", "-", "*", "/" };
                currentOperation = operations[random.Next(4)];
            }

            if (currentOperation == "/")
            {
                result = random.Next(1, 11);

                b = random.Next(1, 11);
                a = b * result;
            }
            else
            {
                a = random.Next(0, 11);
                b = random.Next(0, 11);

                result = currentOperation switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    _ => throw new NotImplementedException(),
                };
            }

            Console.Write($"{i + 1}. {a} {currentOperation} {b}: ");
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

        gameHistory.Add($"Operation: {operation} | Score: {score}");
    }

    static void ShowGameHistory()
    {
        if (gameHistory.Count == 0)
        {
            Console.WriteLine("Game History is empty.");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();

            Console.WriteLine("--- Game History ---");

            for (int i = 0; i < gameHistory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {gameHistory[i]}");
            }

            Console.ReadKey();
        }
    }
}