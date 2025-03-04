namespace MathGame
{
    class Utils
    {
        private static int selectedLevel = 1;

        public static int GetInteger(string message, int min = int.MinValue, int max = int.MaxValue)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max)
                    return number;
                Console.WriteLine($"Invalid input. Enter a number between {min} and {max}: ");
            }
        }

        public static void ChangeDifficulty()
        {
            Console.Clear();
            Console.WriteLine("--- Game Difficulty ---");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            selectedLevel = GetInteger("Your choice: ", 1, 3);
            Console.WriteLine($"Difficulty set to: {GetLevelName(selectedLevel)}");
        }

        public static int GetSelectedLevel() => selectedLevel;

        private static string GetLevelName(int level)
        {
            return level switch
            {
                1 => "Easy (0-10)",
                2 => "Medium (10-100)",
                3 => "Hard (100-1000)",
                _ => "Unknown"
            };
        }
    }
}
