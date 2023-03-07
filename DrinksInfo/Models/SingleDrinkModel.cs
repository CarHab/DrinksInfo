namespace DrinksInfo.Models;
internal class SingleDrinkModel
{
    public string DrinkName { get; set; }
    public string IsAlcholic { get; set; }
    public string GlassType { get; set; }
    public string Instructions { get; set; }
    public List<string> Ingredients { get; set; }
}
