using DrinksInfo.Controllers;
using DrinksInfo.Models;

namespace DrinksInfo.Views;
internal static class CategoryView
{
    public static async Task ShowCategoryMenu()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("        Categories          ");
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
        await HandleChoice();
    }

    private static async Task HandleChoice()
    {
        ConsoleKeyInfo choice = Console.ReadKey(true);

        List<DrinkModel> result = await CategoryController.LoadCategories(_categoryKeyPair[choice.Key]);
        await DrinkView.ShowDrinksInCategory(result);
    }

    private static readonly Dictionary<ConsoleKey, string> _categoryKeyPair = new()
    {
        {ConsoleKey.Q, "ordinary_drink"},
        {ConsoleKey.W, "cocktail"},
        {ConsoleKey.E, "shake"},
        {ConsoleKey.R, "other%20/%20unknown"},
        {ConsoleKey.A, "cocoa"},
        {ConsoleKey.S, "shot"},
        {ConsoleKey.D, "coffee%20/%20tea"},
        {ConsoleKey.F, "homemade_liqueur"},
        {ConsoleKey.Z, "punch%20/%20party%20drink"},
        {ConsoleKey.X, "beer"},
        {ConsoleKey.C, "soft_drink"}
    };
}
