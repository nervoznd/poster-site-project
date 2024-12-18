using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public class TopicSubscriptionsConfiguration : BaseConfiguration<TopicSubscriptions>
{
    public void Configure(EntityTypeBuilder<TopicSubscriptions> builder)
    {
        base.Configure(builder);

        builder.ToTable("TopicSubscriptions");

        builder.HasOne<User>()
               .WithMany(u => u.TopicSubscriptions)
               .HasForeignKey(ur => ur.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Topic>()
               .WithMany(r => r.TopicSubscriptions)
               .HasForeignKey(ur => ur.TopicId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
