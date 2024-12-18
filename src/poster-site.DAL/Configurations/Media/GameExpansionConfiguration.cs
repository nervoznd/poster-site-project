using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class GameExpansionConfiguration : BaseMediaConfiguration<GameExpansion>
{
    public void Configure(EntityTypeBuilder<GameExpansion> builder)
    {
       builder.ToTable("GameExpansions");

       builder.HasBaseType<BaseMedia>();

       builder.HasOne<Game>()
              .WithMany()
              .IsRequired()
              .HasForeignKey(n => n.GameId)
              .OnDelete(DeleteBehavior.SetNull);

       builder.Property(n => n.Type)
              .IsRequired()
              .HasMaxLength(255);
    }
}
