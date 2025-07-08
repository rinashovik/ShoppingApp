using Microsoft.EntityFrameworkCore;
using Shoppingdatabase.data;
using ShoppingModels.Entities;

namespace ShoppingBL.Repositories
{

    public interface IProductRepository
    {

        Task<List<ProductModel>> GetProducts();
         
    }
    public class ProductRepository(AppDbContext dbContext): IProductRepository
    {


        public Task<List<ProductModel>> GetProducts()
        {
            return dbContext.Products.ToListAsync();
        }
    }
}
