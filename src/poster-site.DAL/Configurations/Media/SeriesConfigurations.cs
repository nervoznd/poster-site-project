using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class SeriesConfiguration : MovieConfiguration
{
    public void Configure(EntityTypeBuilder<Series> builder)
    {
       builder.ToTable("Series");

       builder.HasBaseType<BaseMedia>();

       builder.Property(n => n.NumberOfEpisodes)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.EpisodeDuration)
              .IsRequired(false)
              .HasMaxLength(255);
    }
}
