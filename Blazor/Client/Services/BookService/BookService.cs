using System.Net.Http.Json;

namespace Blazor.Client.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly HttpClient _http;
        private readonly PublicClient _public;
        public BookService(HttpClient http, PublicClient publicClient)
        {
            _public = publicClient;
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public event Action BooksChanges;

        public async Task GetBooks(string? categoryUrl = null)
        {
            var result = categoryUrl == null?
                await _public.Client.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product"):
            await _public.Client.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;
            BooksChanges.Invoke();
            
        }

        public async Task<ServiceResponse<Product>> Getbook(int bookId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{bookId}");
            return result;
        }


    }
}
