namespace MathGame
{
    class History
    {
        private static List<string> gameHistory = new List<string>();

        public static void AddResult(string result)
        {
            gameHistory.Add(result);
        }

        public void ShowHistory()
        {
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
            }
        }
    }
}
