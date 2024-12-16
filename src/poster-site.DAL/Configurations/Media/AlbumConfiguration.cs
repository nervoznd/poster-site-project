using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AlbumConfiguration : BaseConfiguration<Album>
{
    public override void Configure(EntityTypeBuilder<Album> builder)
    {
        base.Configure(builder);

        builder.ToTable("Albums");

        builder.HasBaseType<BaseMedia>();

        builder.Property(n => n.Artists)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(n => n.SpotifyURL)
               .IsRequired(false)
               .HasMaxLength(255);
    }
}
