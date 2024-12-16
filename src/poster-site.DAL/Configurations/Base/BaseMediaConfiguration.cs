using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BaseMediaConfiguration<T> : BaseConfiguration<BaseMedia>
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
       builder.ToTable("BaseMedia");

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
