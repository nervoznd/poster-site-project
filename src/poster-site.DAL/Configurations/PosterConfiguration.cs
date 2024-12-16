using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class PosterConfiguration : BaseConfiguration<Poster>
{
    public override void Configure(EntityTypeBuilder<Poster> builder)
    {
       base.Configure(builder);

       builder.ToTable("Posters");

       builder.Property(n => n.Title)
              .IsRequired()
              .HasMaxLength(100);

       builder.Property(n => n.Description)
              .IsRequired(false)
              .HasMaxLength(2000);

       builder.Property(n => n.ImagePath)
              .IsRequired(false)
              .HasMaxLength(255);

       builder.HasOne<BaseMedia>()
              .WithOne()
              .IsRequired(false)
              .HasForeignKey(n => n.MediaId)
              .OnDelete(DeleteBehavior.SetNull);
    }
}
