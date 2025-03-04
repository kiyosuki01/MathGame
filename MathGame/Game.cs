using System.Diagnostics;

namespace MathGame
{
    class Game
    {
        public static void StartGame(string operation)
        {
            Random random = new Random();
            int score = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 1; i < 6; i++)
            {
                Console.Clear();

                (int num1, int num2, int correctAnswer, string question) = GenerateQuestion(operation, random);

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

        private static (int, int, int, string) GenerateQuestion(string operation, Random random)
        {
            int num1, num2, correctAnswer;
            string question;

            if (operation == "random")
            {
                string[] operations = { "+", "-", "*", "/" };
                operation = operations[random.Next(operations.Length)];
            }

            do
            {
                num1 = random.Next(0, 101);
                num2 = random.Next(1, 101);
            } while (operation == "/" && num1 % num2 != 0);

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
