using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class TopicConfiguration : BaseConfiguration<Topic>
{
    public override void Configure(EntityTypeBuilder<Topic> builder)
    {
        base.Configure(builder);

        builder.ToTable("Topics");

        builder.Property(n => n.TopicName)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(n => n.Description)
               .IsRequired(false)
               .HasMaxLength(2000);
    }
}
