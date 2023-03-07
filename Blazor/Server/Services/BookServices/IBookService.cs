namespace Blazor.Server.Services.BookServices
{
    public interface IBookService
    {
        Task<ServiceResponse<List<Product>>> GetBooksAsync();
        Task<ServiceResponse<Product>> GetBooksAsync(int bookId);
        Task<ServiceResponse<List<Product>>> GetBooksByCategory(string categoryUrl);
    }
}
