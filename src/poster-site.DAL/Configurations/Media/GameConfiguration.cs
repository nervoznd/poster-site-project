using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class GameConfiguration : BaseMediaConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
       builder.ToTable("Games");

       builder.HasBaseType<BaseMedia>();

       builder.Property(n => n.OfficialWebsiteURL)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.SteamPageURL)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.Developers)
              .IsRequired(false)
              .HasMaxLength(255);

        builder.Property(n => n.Publishers)
              .IsRequired(false)
              .HasMaxLength(255);

        builder.Property(n => n.Platforms)
              .IsRequired(false)
              .HasMaxLength(255);
    }
}
