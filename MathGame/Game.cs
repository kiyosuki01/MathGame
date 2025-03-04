using System.Diagnostics;

namespace MathGame
{
    class Game
    {
        public static void StartGame(string operation, int level)
        {
            Random random = new Random();
            int score = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();

                (int num1, int num2, int correctAnswer, string question) = GenerateQuestion(operation, level, random);

                Console.WriteLine($"Question {i}: {question}");
                int userAnswer = Utils.GetInteger("Your answer: ");

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer was: {correctAnswer}");
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }

            timer.Stop();
            TimeSpan elapsedTime = timer.Elapsed;

            string result = $"Game: {operation} | Score: {score}/5 | Time: {elapsedTime.Seconds} sec.";
            History.AddResult(result);
        }

        private static (int, int, int, string) GenerateQuestion(string operation, int level, Random random)
        {
            int min, max;

            switch (level)
            {
                case 1:
                    min = 0;
                    max = 10;
                    break;
                case 2:
                    min = 10;
                    max = 100;
                    break;
                case 3:
                    min = 100;
                    max = 1000;
                    break;
                default:
                    throw new Exception("Incorrect difficulty level");
            }

            int num1, num2, correctAnswer;
            string question;

            if (operation == "random")
            {
                string[] operations = { "+", "-", "*", "/" };
                operation = operations[random.Next(operations.Length)];
            }

            do
            {
                num1 = random.Next(min, max);
                num2 = random.Next(min, max);
            } while (operation == "/" && num1 != 0 && num1 % num2 != 0);

            switch (operation)
            {
                case "+":
                    correctAnswer = num1 + num2;
                    question = $"{num1} {operation} {num2} = ?";
                    break;
                case "-":
                    correctAnswer = num1 - num2;
                    question = $"{num1} {operation} {num2} = ?";
                    break;
                case "*":
                    correctAnswer = num1 * num2;
                    question = $"{num1} {operation} {num2} = ?";
                    break;
                case "/":
                    correctAnswer = num1 / num2;
                    question = $"{num1} {operation} {num2} = ?";
                    break;
                default:
                    throw new Exception("Unkown operation.");
            }

            return (num1, num2, correctAnswer, question);
        }
    }
}
