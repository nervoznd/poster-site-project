using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class TokenConfiguration : BaseConfiguration<Token>
{
    public void Configure(EntityTypeBuilder<Token> builder)
    {
       base.Configure(builder);

       builder.ToTable("Tokens");

       builder.Property(n => n.AccessToken)
              .IsRequired()
              .HasMaxLength(255);

       builder.Property(n => n.RefreshToken)
              .IsRequired()
              .HasMaxLength(255);

        builder.Property(n => n.ExpirationDate)
               .IsRequired()
               .HasColumnType("datetime2");
    }
}
