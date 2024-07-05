using LearnWebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnWebAPI.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public int ProductCount { get; set; }
       // public List<Review> Reviews { get; set; } = new();
    }
}
