using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class PathologyMapping : IEntityTypeConfiguration<Pathology>
    {
        public void Configure(EntityTypeBuilder<Pathology> builder)
        {
            builder
                .ToTable("Pathology");
            builder
                .HasKey(prop => prop.Id);
            builder
                .Property(prop => prop.Name)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Pain)
                .HasConversion<string?>()
                .HasColumnName("Pain")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Location)
                .HasConversion<string?>()
                .HasColumnName("Location")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Description)
                .HasConversion<string?>()
                .HasColumnName("Description")
                .HasColumnType("NVARCHAR(1000)");
        }
    }
}
