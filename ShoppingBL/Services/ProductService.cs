using ShoppingBL.Repositories;
using ShoppingModels.Entities;

namespace ShoppingBL.Services
{
    public interface IProductService { 
    
    Task<List <ProductModel>> GetProducts();
        //Task<int> GetProductS();
    }





    public class ProductService(IProductRepository productRepository): IProductService
    {
        public Task<List<ProductModel>> GetProducts()
        {
            // throw new NotImplementedException();

            return productRepository.GetProducts();
        }

      
    }
}
