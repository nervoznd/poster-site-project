using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
