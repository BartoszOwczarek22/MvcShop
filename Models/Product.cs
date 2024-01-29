using System.ComponentModel.DataAnnotations;

namespace MvcShop.Models;

public class Product
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreationDate { get; set; }
    public string? ImageUrl { get; set; }

    // Navigation property for comments
    public List<Comment>? Comments { get; set; }

    // Foreign key for Category
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}