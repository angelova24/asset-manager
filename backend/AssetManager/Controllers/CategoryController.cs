using AssetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssetManager.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAllCategories()
        {
            var categories = new List<Category>
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Label = "Hardware"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Label = "Software"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Label = "Other"
                }
            };
            return Ok(categories);
        }
    }
}
