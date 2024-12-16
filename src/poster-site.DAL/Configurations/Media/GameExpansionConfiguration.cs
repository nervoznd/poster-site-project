using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class GameExpansionConfiguration : BaseConfiguration<GameExpansion>
{
    public override void Configure(EntityTypeBuilder<GameExpansion> builder)
    {
       base.Configure(builder);

       builder.ToTable("GameExpansions");

       builder.HasBaseType<BaseMedia>();

       builder.HasOne<Game>()
              .WithOne()
              .IsRequired()
              .HasForeignKey(n => n.GameId)
              .OnDelete(DeleteBehavior.SetNull);

       builder.Property(n => n.Type)
              .IsRequired()
              .HasMaxLength(255);
    }
}
