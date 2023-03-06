using DrinksInfo.Controllers;
using DrinksInfo.Views;

CategoryView.ShowCategoryMenu();
ConsoleKeyInfo choice = Console.ReadKey(true);

switch (choice.Key)
{
	case ConsoleKey.Q:
		await DrinkController.Categories("Ordinary_Drink");
		break;
    case ConsoleKey.W:
        DrinkController.Categories("Ordinary Drink");
        break;
}