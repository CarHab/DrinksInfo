using DrinksInfo.DataAccess;
using DrinksInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DrinksInfo.Controllers;
internal class DrinksController
{
    public static async Task<SingleDrinkModel> GetDrink(string id)
    {
        string result = await DrinkData.GetDrink(id);

        SingleDrinkModel FormatedDrink = FormatJson(result);

        return FormatedDrink;
    }

    private static SingleDrinkModel FormatJson(string json)
    {
        var drinksJson = JsonConvert.DeserializeObject<JObject>(json);
        var first = drinksJson.First.First.First;

        SingleDrinkModel drink = new()
        {
            DrinkName = first["strDrink"].ToString(),
            IsAlcholic = first["strAlcoholic"].ToString(),
            GlassType = first["strGlass"].ToString(),
            Instructions = first["strInstructions"].ToString(),
        };

        return drink;
    }
}
