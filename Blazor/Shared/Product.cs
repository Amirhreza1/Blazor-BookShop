using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int Price { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
