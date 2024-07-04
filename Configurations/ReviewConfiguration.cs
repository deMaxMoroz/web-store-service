using Microsoft.EntityFrameworkCore;
using LearnWebAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnWebAPI.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.AppUser).WithMany(u => u.Reviews);

            builder.HasOne(r => r.Product).WithMany(p => p.Reviews);
        }
    }
}
