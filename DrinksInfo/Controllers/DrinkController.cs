using DrinksInfo.DataAccess;
using DrinksInfo.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace DrinksInfo.Controllers;
internal class DrinkController
{
    public static async Task Categories(string categoryChoice)
    {
        string json = await DrinkData.GetDrinksFromCategory(categoryChoice);

        List<DrinkModel> DeserializedDrinks = FormatJson(json);

        foreach (var item in DeserializedDrinks)
        {
            Console.WriteLine($"{item.DrinkId} - {item.DrinkName} - {item.DrinkUrlName}");
        }
    }

    private static List<DrinkModel> FormatJson(string json)
    {
        var drinksJson = JsonConvert.DeserializeObject<dynamic>(json);
        List<DrinkModel> drinks = new();

        for (int i = 0; i < drinksJson["drinks"].Count ; i++)
        {
            drinks.Add(new DrinkModel
            {
                DrinkId = drinksJson["drinks"][i].idDrink,
                DrinkName = drinksJson["drinks"][i].strDrink,
                DrinkUrlName = FormatDrinkName(drinksJson["drinks"][i].strDrink.ToString())
            });
        }

        return drinks;
    }

    private static string FormatDrinkName(string name)
    {
        string[] splitName = name.Split(" ");
        string formattedName = String.Join("_", splitName);
        return formattedName;
    }
}
