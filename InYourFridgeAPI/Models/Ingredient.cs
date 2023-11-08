using System.ComponentModel.DataAnnotations;

namespace InYourFridgeAPI.Models;

public class Ingredient
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public DateTime PurchaseDate { get; set; } = DateTime.Now;
    public double ExpirationLength { get; set; } = (60 * 60 * 24 * 7);
}