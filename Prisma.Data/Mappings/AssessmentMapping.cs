using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class AssessmentMapping : IEntityTypeConfiguration<Assessment>
    {
        public void Configure(EntityTypeBuilder<Assessment> builder)
        {
            builder
                .ToTable("Assessment");
            builder
                .HasKey(prop => prop.Id);
            builder
                .Property(prop => prop.BloodPressure)
                .HasConversion<string?>()
                .HasColumnName("BloodPressure")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.SpO2)
                .HasConversion<byte?>()
                .HasColumnName("SpO2")
                .HasColumnType("TINYINT");
            builder
                .Property(prop => prop.HeartRate)
                .HasConversion<byte?>()
                .HasColumnName("HeartRate")
                .HasColumnType("TINYINT");
            builder
                .Property(prop => prop.Temperature)
                .HasConversion<float?>()
                .HasColumnName("Temperature")
                .HasColumnType("REAL");
            builder
                .Property(prop => prop.Goniometry)
                .HasConversion<string?>()
                .HasColumnName("Goniometry")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.Eva)
                .HasConversion<byte?>()
                .HasColumnName("Eva")
                .HasColumnType("TINYINT");
            builder
                .Property(prop => prop.Glasgow)
                .HasConversion<string?>()
                .HasColumnName("Goniometry")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.Palpitation)
                .HasConversion<bool?>()
                .HasColumnName("Palpitation")
                .HasColumnType("BIT");
            builder
                .Property(prop => prop.AssessmentDate)
                .HasConversion<DateTime>()
                .IsRequired()
                .HasColumnName("AssessmentDate")
                .HasColumnType("DATE");
            builder
                .Property(prop => prop.NextAssessment)
                .HasConversion<DateTime?>()
                .HasColumnName("NextAssessment")
                .HasColumnType("SMALLDATETIME");
            builder
                .HasOne(prop => prop.Prescriber)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(prop => prop.Patient)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
