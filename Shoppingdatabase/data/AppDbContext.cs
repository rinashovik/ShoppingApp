using Microsoft.EntityFrameworkCore;
using ShoppingModels.Entities;

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
