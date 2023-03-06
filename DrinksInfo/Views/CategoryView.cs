namespace DrinksInfo.Views;
internal static class CategoryView
{
    public static void ShowCategoryMenu()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("      Categories Menu       ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------------------");
        Console.WriteLine("| Q - Ordinary Drink       |");
        Console.WriteLine("| W - Cocktail             |");
        Console.WriteLine("| E - Milk / Float / Shake |");
        Console.WriteLine("| R - Other / Unknown      |");
        Console.WriteLine("| A - Cocoa                |");
        Console.WriteLine("| S - Shot                 |");
        Console.WriteLine("| D - Coffee / Tea         |");
        Console.WriteLine("| F - Homemade Liquour     |");
        Console.WriteLine("| Z - Punch / Party Drink  |");
        Console.WriteLine("| X - Beer                 |");
        Console.WriteLine("| C - Soft Drink / Soda    |");
        Console.WriteLine("----------------------------");
    }
}
