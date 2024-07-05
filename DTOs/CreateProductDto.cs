using System.ComponentModel.DataAnnotations.Schema;

namespace LearnWebAPI.DTOs
{
    public class CreateProductDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public int ProductCount { get; set; }
    }
}
