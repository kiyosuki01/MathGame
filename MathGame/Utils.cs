namespace MathGame
{
    class Utils
    {
        internal static int GetInteger(string message)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                    return number;
                Console.WriteLine("Invalid input. Enter a number: ");
            }
        }
    }
}
