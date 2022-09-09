using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .ToTable("Address");
            builder
                .HasKey(prop => prop.Id);
            builder
                .Property(prop => prop.PublicArea)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("PublicArea")
                .HasColumnType("NVARCHAR(10)");
            builder
                .Property(prop => prop.Name)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Number)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Number")
                .HasColumnType("NVARCHAR(10)");
            builder
                .Property(prop => prop.District)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("District")
                .HasColumnType("NVARCHAR(100)");
        }
    }
}
