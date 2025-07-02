using Microsoft.EntityFrameworkCore;
using Shoppingdatabase.data;
using ShoppingModels.Entities;

namespace ShoppingBL.Repositories
{

    public interface IProductRepository
    {

        Task<List<ProductModel>> GetProducts();
    }
    internal class ProductRepository(AppDbContext dtContext): IProductRepository
    {


        public Task<List<ProductModel>> GetProducts()
        {
            return DbContext.Products.ToListAsync();
        }
    }
}
