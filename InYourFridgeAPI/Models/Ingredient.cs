namespace InYourFridgeAPI.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime PurchaseDate { get; set; }
    public double ExpirationLength { get; set; }
}