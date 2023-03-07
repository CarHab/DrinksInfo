using DrinksInfo.DataAccess;
using DrinksInfo.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace DrinksInfo.Controllers;
internal class CategoryController
{
    public static async Task<List<DrinkModel>> LoadCategories(string categoryChoice)
    {
        string json = await CategoryData.GetDrinksFromCategory(categoryChoice);

        List<DrinkModel> deserializedDrinks = FormatJson(json);

        return deserializedDrinks;
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
            });
        }

        return drinks;
    }
}
