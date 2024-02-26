using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using notebook.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace notebook.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new notebookContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<notebookContext>>()))
        {
            context.Note.AddRange(
                new Note
                {
                    Name = "default",
                    Content = "all",
                }
            );
        }
    }
}