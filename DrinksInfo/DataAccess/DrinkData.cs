namespace DrinksInfo.DataAccess;
using System.Net.Http.Headers;

internal static class DrinkData
{
    private static readonly string _baseUrl = "https://www.thecocktaildb.com/api/json/v1/1/";
    
    public static async Task<string> GetDrinksFromCategory(string category)
    {
        using HttpClient client = new();

        string json = await client.GetStringAsync($"{_baseUrl}filter.php?c={category}");

        return json;
    }
}
