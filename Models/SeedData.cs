using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System;

namespace AspDotNetCoreMvcDocker.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider serviceProvider) => EnsurePopulated(
            serviceProvider.GetRequiredService<BookDbContext>());
        public static void EnsurePopulated(BookDbContext context)
        {
            System.Console.WriteLine("Applying Migrations...");
            context.Database.Migrate();
            if (!context.Books.Any())
            {
                System.Console.WriteLine("Creating Seed Data...");
                context.Books.AddRange(
                new Book("c# 7", ".net", 275),
                new Book("c# 6", ".net", 275),
                new Book("java web", "java", 48.95m),
                new Book("java io", "java", 19.50m),
                new Book("mysql", "db", 34.95m),
                new Book("sqlserver", "db", 79500),
                new Book("angular 2", "web", 16),
                new Book("vue", "web", 29.95m)
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Seed Data Not Required...");
            }
        }
    }
}