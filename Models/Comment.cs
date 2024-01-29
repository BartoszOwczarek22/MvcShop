using System.ComponentModel.DataAnnotations;

namespace MvcShop.Models;

public class Comment
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsDeleted { get; set; }

    // Navigation property for the associated product
    public Product? Product { get; set; }
}