using System.Collections.Generic;

namespace Blazor.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;
        private readonly PublicClient publicClient;
        public CategoryService(HttpClient http, PublicClient pClient)
        {
            _http = http;
            publicClient = pClient;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var response = await publicClient.Client.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (response != null && response.Data != null)
            {
                return new ServiceResponse<List<Category>>()
                {
                    Data = response.Data,
                    Success = true
                };
            }
            else
            {
                return new ServiceResponse<List<Category>>()
                {
                    Success = false,
                    Data = new()
                };
            }
        }
    }
}
