using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class SongConfiguration : BaseMediaConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
       builder.ToTable("Songs");

       builder.HasBaseType<BaseMedia>();

       builder.Property(n => n.Artists)
              .IsRequired()
              .HasMaxLength(255);

       builder.HasOne<Album>()
              .WithMany()
              .IsRequired(false)
              .HasForeignKey(n => n.AlbumId)
              .OnDelete(DeleteBehavior.SetNull);

       builder.Property(n => n.SpotifyURL)
              .IsRequired(false)
              .HasMaxLength(255);
    }
}
