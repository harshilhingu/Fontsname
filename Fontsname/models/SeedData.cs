using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Fontsname.Data;
using System;
using System.Linq;

namespace Fontsname.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FontsnameDifffontsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FontsnameDifffontsContext>>()))
            {
            
                if (context.Difffonts.Any())
                {
                    return; 
                }

                context.Difffonts.AddRange(
                    new Difffonts
                    {
                        
                        Title = "ALGERIAN",
                        weight = "solid black",
                        cornerrounding = "subtle",
                        Price = 39,
                        ReleaseDate = DateTime.Parse("1998-2-12")
                    },

                    new Difffonts
                    {
                        Title = "Calibri",
                        weight = "bold",
                        cornerrounding = "subtle",
                        Price = 30,
                        ReleaseDate = DateTime.Parse("2007-1-21")
                    },

                    new Difffonts
                    {
                        Title = "Garamond",
                        weight = "regular and semi bold",
                        cornerrounding = "clear stroke",
                        Price = 35,
                        ReleaseDate = DateTime.Parse("1996-2-23")
                    },

                    new Difffonts
                    {
                        Title = "Cambria",
                        weight = "bold-italic",
                        cornerrounding = "soft flowing cruve",
                        Price = 49,
                        ReleaseDate = DateTime.Parse("2007-11-10")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}