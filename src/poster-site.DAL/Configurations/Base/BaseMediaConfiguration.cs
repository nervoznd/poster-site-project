using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class BaseMediaConfiguration<T> : BaseConfiguration<BaseMedia>
{
    public override void Configure(EntityTypeBuilder<BaseMedia> builder)
    {
       builder.ToTable("BaseMedias");

       builder.HasKey(b => b.Id);

       builder.Property(b => b.Name)
              .IsRequired()
              .HasMaxLength(200);

       builder.Property(b => b.Description)
              .IsRequired(false)
              .HasMaxLength(1000);

       builder.Property(b => b.ImagePath)
              .IsRequired(false)
              .HasMaxLength(500);

       builder.Property(b => b.ReleaseDate)
              .IsRequired(false);

       builder.Property(b => b.IsDateAccurate)
              .IsRequired(false);

       builder.Property(b => b.IsReleased)
              .IsRequired();

       builder.Property(b => b.Genres)
              .IsRequired(false)
              .HasMaxLength(255);
    }
}
