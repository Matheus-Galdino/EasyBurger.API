using EasyBurger.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyBurger.API.Infra.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Email).UseCollation("ascii_general_ci");

            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
