using Blazor.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IBookService _bookservice;
        public ProductController(IBookService bookService)
        {
            _bookservice = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetBook()
        {
            var result = await _bookservice.GetBooksAsync();
            return Ok(result);
        }


        [HttpGet("{bookId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetBook(int bookId)
        {
            var result = await _bookservice.GetBooksAsync(bookId);
            return Ok(result);
        }
        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetBooksByCategory(string categoryUrl)
        {
            var result = await _bookservice.GetBooksByCategory(categoryUrl);
            return Ok(result);
        }
    }
}
