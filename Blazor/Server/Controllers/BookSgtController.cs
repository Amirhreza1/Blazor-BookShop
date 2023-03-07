using Blazor.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookSgtController : ControllerBase
    {
        private readonly IReposetory<BookSegesstion> reposetory;
        public BookSgtController(IReposetory<BookSegesstion> repo)
        {
            reposetory = repo;
        }
        [HttpGet("GetAllSgt")]
        public async Task<ActionResult<ServiceResponse<IEnumerable<BookSegesstion>>>> GetAllSuguestion()
        {
            var result = await reposetory.GetAllAsync();
            ServiceResponse<IEnumerable<BookSegesstion>> res = new()
            {
                Data = result
            };

            return Ok(res);
        }
    }
}
