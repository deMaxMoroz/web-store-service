using System.ComponentModel.DataAnnotations.Schema;

namespace LearnWebAPI.Models
{
    public class Product
    {
        public int Id { get;  set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "Decimal(12,2)")]
        public double Price { get; set; }
        public int ProductCount { get; set; }
        public List<Review> Reviews { get; set; } = new();

    }
}
