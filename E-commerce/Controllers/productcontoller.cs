using E_commerce.Models;
using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace E_commerce.Controllers
{
 
    [Route("api/pro")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDb _data;

        public ProductController(ProductDb data)
        {
            _data = data;
            if (!_data.Product.Any())
            {
                _data.Product.AddRange(
                    new Commodities { Id = 1, Name = "Laptop", Price = 200000 },
                    new Commodities { Id = 2, Name = "Mobile", Price = 20000 },
                    new Commodities { Id = 3, Name = "Samsung z FLIP 5", Price = 200000 }
                );
            }
            _data.SaveChanges();
        }
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<Commodities>> GetProducts()
        {
            return Ok(_data.Product.ToList());
        }
        [HttpPost]
        [Authorize("AdminOnly")]
        public ActionResult<string> AddProduct( [FromBody] Commodities product)
        {
            
            _data.Product.Add(product);
            _data.SaveChanges();
            GetProducts();
            return Ok("Product added Succesfully");
        }


    }
}