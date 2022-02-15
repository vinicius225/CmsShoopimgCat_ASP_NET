using CmsShoopimgCat_ASP_NET.Infraestruture;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoopimgCat_ASP_NET.Models
{
    public class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider) { 
            using (var context = new 
                Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }
                context.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug = "home",
                        Content = "Home Page",
                        Sorting = 0
                    }
                    ,
                    new Page
                    {
                        Title = "About us",
                        Slug = "about-us",
                        Content = "about us page",
                        Sorting = 100
                    },
                      new Page
                      {
                          Title = "Services",
                          Slug = "services",
                          Content = "services",
                          Sorting = 100
                      },
                        new Page
                        {
                            Title = "Contsct",
                            Slug = "contact",
                            Content = "concact page",
                            Sorting = 100
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
