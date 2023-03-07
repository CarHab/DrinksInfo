namespace DrinksInfo.DataAccess;
internal class DrinkData
{
    private static readonly string _baseUrl = "https://www.thecocktaildb.com/api/json/v1/1/";

    public static async Task<string> GetDrink(string drinkId)
    {
        using HttpClient client = new();

        string json = await client.GetStringAsync($"{_baseUrl}lookup.php?i={drinkId}");

        return json;
    }
}
