using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class NewsConfiguration : BaseConfiguration<News>
{
    public override void Configure(EntityTypeBuilder<News> builder)
    {
       base.Configure(builder);

       builder.ToTable("News");

       builder.Property(n => n.Title)
              .IsRequired()
              .HasMaxLength(100);

       builder.Property(n => n.Content)
              .IsRequired(false)
              .HasMaxLength(2000);

       builder.Property(n => n.SourceURL)
              .IsRequired(false)
              .HasMaxLength(500);

       builder.Property(n => n.PublishDate)
              .IsRequired(false);

       builder.HasOne<Topic>()
              .WithOne()
              .IsRequired()
              .HasForeignKey(n => n.TopicId)
              .OnDelete(DeleteBehavior.Cascade);

       builder.HasOne<BaseMedia>()
              .WithOne()
              .IsRequired(false)
              .HasForeignKey(n => n.MediaId)
              .OnDelete(DeleteBehavior.SetNull);
    }
}
