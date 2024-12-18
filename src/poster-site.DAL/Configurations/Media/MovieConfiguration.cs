using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class MovieConfiguration : BaseMediaConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
       builder.ToTable("Movies");

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
    }
}
