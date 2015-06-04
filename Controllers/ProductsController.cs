using Microsoft.AspNet.Mvc;
using VisualStudioCode.WebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace VisualStudioCode.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly SalesDbContext _dbContext;
        public ProductsController(SalesDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
 
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        // GET api/products
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            System.Console.WriteLine("...GET api/products called");
            return _dbContext.Products;

            //return products;
        }

        // GET api/products/5
        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id)
        {
            System.Console.WriteLine("...GET api/products/5 called");

            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return new HttpNotFoundResult();
            } 
            return new ObjectResult(product);
                       
            //  var product = products.FirstOrDefault((p) => p.Id == id);
            //  if (product == null)
            //  {
            //      return HttpNotFound();
            //  }
            //  return new ObjectResult(product);
        }
    }
}