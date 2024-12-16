using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserRoleConfiguration : BaseConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        base.Configure(builder);

        builder.ToTable("UserRoles");

        builder.HasMany(ur => ur.User)
               .WithMany(u => u.UserRoles)
               .HasForeignKey(ur => ur.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(ur => ur.Role)
               .WithMany(r => r.UserRoles)
               .HasForeignKey(ur => ur.RoleId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
