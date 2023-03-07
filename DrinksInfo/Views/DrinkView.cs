using DrinksInfo.Controllers;
using DrinksInfo.Models;

namespace DrinksInfo.Views;
internal class DrinkView
{
    public static async Task ShowDrinksInCategory(List<DrinkModel> drinks)
    {
        foreach (var item in drinks)
        {
            Console.WriteLine($"{item.DrinkId} - {item.DrinkName}");
        }
        Console.Write("Choose a drink(or 0 to return): ");
        string choice = Console.ReadLine();

        if (choice == "0")
        {
            await CategoryView.ShowCategoryMenu();
        }

        SingleDrinkModel drink = await DrinksController.GetDrink(choice);

        ShowDrink(drink);

        await Console.Out.WriteLineAsync("\nPress any key to return to the main menu");
        Console.ReadKey(true);
        await CategoryView.ShowCategoryMenu();
    }

    private static void ShowDrink(SingleDrinkModel drink)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"     {drink.DrinkName}     ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(drink.IsAlcholic);
        Console.WriteLine($"\nGlass type: {drink.GlassType}");
        Console.WriteLine($"\nInstructions:\n{drink.Instructions}\n");
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"                     ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
