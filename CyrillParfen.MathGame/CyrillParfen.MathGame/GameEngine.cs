namespace CyrillParfen.MathGame.Models;

internal class GameEngine
{
    internal void AdditionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.Write($"{firstNumber} + {secondNumber} = ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int answere) && answere == firstNumber + secondNumber)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {firstNumber + secondNumber}\n");
            }
        }

        Helpers.SaveHistory(GameType.Addition, score);

        Console.WriteLine($"Your final score is {score}. Press any key to continue...");
        Console.ReadKey(true);
    }

    internal void SubtractionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int answere) && answere == firstNumber - secondNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {firstNumber - secondNumber}");
            }
        }

        Helpers.SaveHistory(GameType.Subtraction, score);
        Console.WriteLine($"Your final score is {score}. Press any key to continue...");
        Console.ReadKey(true);
    }

    internal void MutiplicationGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int answere) && answere == firstNumber * secondNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {firstNumber * secondNumber}");
            }
        }

        Helpers.SaveHistory(GameType.Multiplication, score);
        Console.WriteLine($"Your final score is {score}. Press any key to continue...");
        Console.ReadKey(true);
    }

    internal void DivisionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            int[] divisionNumbers = Helpers.GetDivisionNumbers();
            int firstNumber = divisionNumbers[0];
            int secondNumber = divisionNumbers[1];

            Console.Write($"{firstNumber} / {secondNumber} = ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int answere) && answere == firstNumber / secondNumber)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {firstNumber / secondNumber}\n");
            }
        }

        Helpers.SaveHistory(GameType.Division, score);
        Console.WriteLine($"Your final score is {score}. Press any key to contunue...");
        Console.ReadKey(true);
    }
}

