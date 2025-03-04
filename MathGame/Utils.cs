namespace MathGame
{
    class Utils
    {
        internal static int GetInteger(string message, int min = int.MinValue, int max = int.MaxValue)
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
    }
}
