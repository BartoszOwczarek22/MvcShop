using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcShop.Models;

public class ProductCategoryModel
{
    public List<Product>? Products { get; set; }
    public SelectList? Categories { get; set; }
    public string? ProductCategory { get; set; }
    public string? SearchString { get; set; }
}