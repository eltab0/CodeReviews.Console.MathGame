namespace CyrillParfen.MathGame.Models;

internal class Program
{
    static void Main(string[] args)
    {
        string name = GetName();
        Menu menu = new Menu();
        menu.GameMenu(name);
    }

    private static string GetName()
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        return name;
    }

}
