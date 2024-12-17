using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class AlbumConfiguration : BaseMediaConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
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
