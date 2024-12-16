using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TopicSubscriptionsConfiguration : BaseConfiguration<TopicSubscriptions>
{
    public void Configure(EntityTypeBuilder<TopicSubscriptions> builder)
    {
        base.Configure(builder);

        builder.ToTable("TopicSubscriptions");

        builder.HasMany(ts => ts.User)
               .WithMany(u => u.TopicSubscriptions)
               .HasForeignKey(ur => ur.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(ur => ur.Topic)
               .WithMany(r => r.TopicSubscriptions)
               .HasForeignKey(ur => ur.TopicId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
