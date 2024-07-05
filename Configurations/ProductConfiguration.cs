using Microsoft.EntityFrameworkCore;
using LearnWebAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnWebAPI.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasMany(p => p.Reviews).WithOne(r => r.Product).HasForeignKey(r=>r.ProductId);
            
        }
    }
}
