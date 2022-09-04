using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class ConductMapping : IEntityTypeConfiguration<Conduct>
    {
        public void Configure(EntityTypeBuilder<Conduct> builder)
        {
            builder
                .ToTable("Conduct");
            builder
                .HasKey(prop => prop.Id);
            builder
                .Property(prop => prop.Header)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Header")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.Description)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Header")
                .HasColumnType("NVARCHAR");
            builder
                .HasOne(prop => prop.Evolution)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
