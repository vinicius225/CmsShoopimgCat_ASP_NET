using CmsShoopimgCat_ASP_NET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoopimgCat_ASP_NET.Infraestruture
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options)
        {         
        }
        public DbSet<Page> Pages { get; set; }
       
    }
}
