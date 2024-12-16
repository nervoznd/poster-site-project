using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserConfiguration : BaseConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("Users");

        builder.Property(u => u.UserName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.PasswordHash)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(u => u.TelegramUserName)
            .HasMaxLength(100);

         builder.HasOne<Token>()
               .WithOne()
               .HasForeignKey<User>(u => u.TokenId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}