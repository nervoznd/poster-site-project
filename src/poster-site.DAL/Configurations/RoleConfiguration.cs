using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class RoleConfiguration : BaseConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        base.Configure(builder);

        builder.ToTable("Roles");

        builder.Property(r => r.RoleName)
            .IsRequired()
            .HasMaxLength(100);
    }
}