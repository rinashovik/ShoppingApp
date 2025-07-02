using ShoppingBL.Repositories;
using ShoppingModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Task<List<ProductModel>> IProductService.GetProducts()
        //{
        //    throw new NotImplementedException();
        //}

        //Task<int> IProductService.GetProductS()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> GetProductS()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
