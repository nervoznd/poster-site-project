using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MovieConfiguration : BaseConfiguration<Movie>
{
    public override void Configure(EntityTypeBuilder<Movie> builder)
    {
       base.Configure(builder);

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
