namespace MathGame
{
    class History
    {
        private static List<string> gameHistory = new List<string>();

        public static void AddResult(string result)
        {
            gameHistory.Add(result);
        }

        public static void ShowHistory()
        {
            Console.Clear();
            
            if (gameHistory.Count == 0)
            {
                Console.WriteLine("Game History is empty.");
            }
            else
            {
                Console.WriteLine("--- Game History ---\n");

                foreach (string gameResult in gameHistory)
                {
                    Console.WriteLine(gameResult);
                }

                Console.WriteLine("\n--------------------");

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
        }
    }
}
