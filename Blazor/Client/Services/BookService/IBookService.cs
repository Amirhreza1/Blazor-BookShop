using Blazor.Shared;

namespace Blazor.Client.Services.BookService
{
    public interface IBookService
    {
        event Action BooksChanges;
        List<Product> Products { get; set; }
        Task GetBooks(string? categoryUrl = null);
        Task<ServiceResponse<Product>> Getbook(int bookId);
    }
}
