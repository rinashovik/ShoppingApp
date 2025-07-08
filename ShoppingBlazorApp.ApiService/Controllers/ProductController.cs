using Microsoft.AspNetCore.Mvc;
using ShoppingBL.Services;
using ShoppingModels.Entities;
using ShoppingModels.Models;

namespace ShoppingBlazorApp.ApiService.Controllers

{
    [Route("api/Controller")]
    [ApiController]

    public class ProductController(IProductService productService) : ControllerBase
    {
        public List<ProductModel> Data { get; private set; }

        //public IActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        public async Task<ActionResult<BaseResponseModel>> GetProducts() {

            var products = await productService.GetProducts();

           // return Ok(Sucess * true);
                
          //
             return Ok (new BaseResponseModel { Success = true, Data = products });
            
        }
    } 
}
