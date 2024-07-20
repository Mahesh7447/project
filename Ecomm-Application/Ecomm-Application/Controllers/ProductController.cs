using Ecomm_Application.Helpers;
using Ecomm_Application.Models;
using Ecomm_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ecomm_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet("allproducts")]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(productService.GetProducts());
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var product = productService.GetProduct(id);
            if (product != null)
            {
                return Ok(product);
            }
            else
                return NotFound();
        }
        [HttpPost("save")]
        public ActionResult<ProductDTO> SaveProduct(ProductDTO product)
        {
            var product1 =new ProductDTO();
            if (ModelState.IsValid)
            {
                product1 = productService.SaveProduct(product);
                return Ok(product1);
            }
            else
                return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public ActionResult<bool> DeleteProduct(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            return productService.DeleteProduct(id);
        }
    }
}
