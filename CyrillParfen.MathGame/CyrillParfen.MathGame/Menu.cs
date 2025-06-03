namespace CyrillParfen.MathGame.Models;

internal class Menu
{
    internal void GameMenu(string name)
    {
        GameEngine gameEngine = new GameEngine();

        bool isGameRunning = true;

        do
        {
            Console.Clear();
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"Choose the math operation:\n1 - Addition\n2 - Subtraction\n" +
                $"3 - Multiplication\n4 - Division\n5 - View scores\n0 - Quit");

            char gameSelected = Console.ReadKey(true).KeyChar;

            switch (gameSelected)
            {
                case '1':
                    gameEngine.AdditionGame("Addition game selected");
                    break;
                case '2':
                    gameEngine.SubtractionGame("Subtraction game selected");
                    break;
                case '3':
                    gameEngine.MutiplicationGame("Multiplication game selected");
                    break;
                case '4':
                    gameEngine.DivisionGame("Division game selected");
                    break;
                case '5':
                    Helpers.PrintScores();
                    break;
                case '0':
                    Console.Clear();
                    Console.WriteLine($"Good bye, {name}!");
                    isGameRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }
        } while (isGameRunning);

    }
}
