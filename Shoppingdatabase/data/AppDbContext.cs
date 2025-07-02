using Microsoft.EntityFrameworkCore;
using ShoppingModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingdatabase.data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
            Database.EnsureCreated();    // create database that doesn't exsist    
        
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
