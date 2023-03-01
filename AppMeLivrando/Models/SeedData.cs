using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeLivrando.Data;
using System;
using System.Linq;

namespace AppMeLivrando.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MeLivrandoContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MeLivrandoContext>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    
                }
            );
            context.SaveChanges();
        }
    }
}