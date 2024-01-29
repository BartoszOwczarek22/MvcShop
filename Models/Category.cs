using System.ComponentModel.DataAnnotations;

namespace MvcShop.Models;

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsDeleted { get; set; }

    // Navigation property for products
    public List<Product>? Products { get; set; }
}