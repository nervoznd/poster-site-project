using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class SeriesConfiguration : BaseConfiguration<Series>
{
    public override void Configure(EntityTypeBuilder<Series> builder)
    {
       base.Configure(builder);

       builder.ToTable("Series");

       builder.HasBaseType<BaseMedia>();

       builder.Property(n => n.Country)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.Directors)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.Writers)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.Budget)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.AgeRating)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.NumberOfEpisodes)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.Property(n => n.EpisodeDuration)
              .IsRequired(false)
              .HasMaxLength(255);
    }
}
