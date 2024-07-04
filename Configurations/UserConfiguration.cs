using Microsoft.EntityFrameworkCore;
using LearnWebAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnWebAPI.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasMany(u => u.Reviews).WithOne(r => r.AppUser).HasForeignKey(r => r.UserId);

        }
    }
}
