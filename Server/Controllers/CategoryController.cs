using APIAssignment.Server.Data;
using APIAssignment.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAssignment.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        DataDbContext _db;
        public CategoryController(DataDbContext db)
        {
            _db = db;
        }

        // GET: api/<CategorytController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [Route("/Category")]
        public IEnumerable<Category> GetCategory()
        {
            return _db.categories.ToList();

            //return new string[] { "Student1", "Student2" , type };
        }
    }
}
