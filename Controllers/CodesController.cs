using Microsoft.AspNet.Mvc;
using VisualStudioCode.WebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace VisualStudioCode.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CodesController : Controller
    {
        private readonly SalesDbContext _dbContext;
        public CodesController(SalesDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
 
        // GET api/codes
        [HttpGet]
        public IEnumerable<Code> GetAllCodes()
        {
            System.Console.WriteLine("...GET api/codes called");
            return _dbContext.Codes;
        }

        // GET api/codes/5
        [HttpGet("{id:int}")]
        public IActionResult GetCode(int id)
        {
            System.Console.WriteLine("...GET api/codes/5 called");

            var code = _dbContext.Codes.FirstOrDefault(c => c.Id == id);
            if (code == null)
            {
                return new HttpNotFoundResult();
            } 
            return new ObjectResult(code);
        }
    }
}