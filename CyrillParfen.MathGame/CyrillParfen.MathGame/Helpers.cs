namespace CyrillParfen.MathGame.Models;

internal class Helpers
{
    internal static List<Game> GamesList { get; set; } = new List<Game>();

    internal static int[] GetDivisionNumbers()
    {
        Random random = new Random();
        int divisible = random.Next(0, 101);
        int divisor = random.Next(0, 101);

        int[] result = new int[2];

        while (divisor == 0 || divisible % divisor != 0)
        {
            divisible = random.Next(0, 99);
            divisor = random.Next(0, 99);
        }

        result[0] = divisible;
        result[1] = divisor;

        return result;
    }

    internal static void PrintScores()
    {
        Console.Clear();
        Console.WriteLine("*** Scores ***");
        Console.WriteLine($"| {"Date", -19} | {"Game Type", -14} | {"Scores", -3}");

        foreach (Game game in GamesList)
        {
            Console.WriteLine($"| {game.Date, 19} | {game.Type, -14} | {game.Score, -3}");
        
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
    }

    internal static void SaveHistory(GameType gameType, int score)
    {
        GamesList.Add(new Game 
        {
            Date = DateTime.Now,
            Type = gameType,
            Score = score
        });
    }
}
