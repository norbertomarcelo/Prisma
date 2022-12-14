using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class EvolutionMapping : IEntityTypeConfiguration<Evolution>
    {
        public void Configure(EntityTypeBuilder<Evolution> builder)
        {
            builder
                .ToTable("Evolution");
            builder
                .HasKey(prop => prop.Id);
            builder
                .Property(prop => prop.Header)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Header")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Description)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("NVARCHAR(1000)");
            builder
                .Property(prop => prop.EvolutionDate)
                .HasConversion<DateTime>()
                .IsRequired()
                .HasColumnName("EvolutionDate")
                .HasColumnType("DATE");
            builder
                .HasOne(prop => prop.Prescriber)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(prop => prop.Patient)
                .WithMany()
                .HasForeignKey(prop => prop.Id)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(prop => prop.Conducts)
                .WithOne(e => e.Evolution)
                .HasForeignKey(prop => prop.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
