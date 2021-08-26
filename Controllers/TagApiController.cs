using System.Linq;
using CollectionHub.Data;
using Microsoft.AspNetCore.Mvc;

namespace CollectionHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagApiController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public TagApiController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Produces("application/json")]
        [HttpGet("autocomplete")]
        public IActionResult Search()
        {
            try
            {
                var term = HttpContext.Request.Query["term"].ToString();
                var tags = _dbContext.Tags
                    .Where(t => t.Name.Contains(term))
                    .Select(t => t.Name).ToList();
                return Ok(tags);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}