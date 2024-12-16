using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GameConfiguration : BaseConfiguration<Game>
{
    public override void Configure(EntityTypeBuilder<Game> builder)
    {
       base.Configure(builder);

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
