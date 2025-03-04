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
            Console.WriteLine("--- Game History ---");
            if (gameHistory.Count == 0)
            {
                Console.WriteLine("Game History is empty.");
            }
            else
            {
                foreach (string gameResult in gameHistory)
                {
                    Console.WriteLine(gameResult);
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
