using System.Reflection.Metadata.Ecma335;

namespace Blazor.Server.Services.BookServices
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;
        public BookService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetBooksAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }
        public async Task<ServiceResponse<Product>> GetBooksAsync(int bookId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(bookId);
            if(product == null)
            {
                response.Success = false;
                response.Message = "This book doese not existe"; 
            }else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetBooksByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync()
            };
            return response;
        }   
    }
}
