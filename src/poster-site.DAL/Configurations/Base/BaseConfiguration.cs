using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poster_site.DAL.Models;

namespace poster_site.DAL.Configurations;

public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.CreatedAt)
               .IsRequired()
               .HasDefaultValueSql("NOW()");

        builder.Property(e => e.UpdatedAt)
               .IsRequired()
               .HasDefaultValueSql("NOW()");
    }
}
