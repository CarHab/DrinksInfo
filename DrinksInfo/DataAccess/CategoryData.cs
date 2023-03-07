namespace DrinksInfo.DataAccess;

internal static class CategoryData
{
    private static readonly string _baseUrl = "https://www.thecocktaildb.com/api/json/v1/1/";

    public static async Task<string> GetDrinksFromCategory(string category)
    {
        using HttpClient client = new();

        string url = $"{_baseUrl}filter.php?c={category}";

        string json = await client.GetStringAsync(url);

        return json;
    }
}
