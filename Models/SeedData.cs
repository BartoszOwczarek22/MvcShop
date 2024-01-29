using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcShop.Data;
using System;
using System.Linq;

namespace MvcShop.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcShopContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcShopContext>>()))
        {
         // Look for any data.
            if (context.Product.Any() || context.Comment.Any() || context.Category.Any())
            {
                return;   // DB has been seeded
            }

            var category1 = new Category { Name = "Electronics" };
            var category2 = new Category { Name = "Clothing" };
            context.Category.AddRange(category1, category2);
            context.SaveChanges();

            var product1 = new Product
            {
                Title = "Smartphone",
                Description = "The latest smartphone with amazing features.",
                IsDeleted = false,
                CreationDate = DateTime.Now,
                ImageUrl = "https://example.com/smartphone.jpg",
                CategoryId = category1.Id
            };

            var product2 = new Product
            {
                Title = "Laptop",
                Description = "Powerful laptop for all your computing needs.",
                IsDeleted = false,
                CreationDate = DateTime.Now,
                ImageUrl = "https://example.com/laptop.jpg",
                CategoryId = category1.Id
            };

            context.Product.AddRange(product1, product2);
            context.SaveChanges();

            var comment1 = new Comment
            {
                ProductId = product1.Id,
                Description = "Great smartphone!",
                CreationDate = DateTime.Now,
                IsDeleted = false
            };

            var comment2 = new Comment
            {
                ProductId = product2.Id,
                Description = "Awesome laptop!",
                CreationDate = DateTime.Now,
                IsDeleted = false
            };

            context.Comment.AddRange(comment1, comment2);
            context.SaveChanges();
           
            
        }
    }
}