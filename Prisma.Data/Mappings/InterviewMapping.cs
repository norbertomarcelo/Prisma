using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class InterviewMapping : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder
                .ToTable("Interview");
            builder
                .HasKey(prop => prop.Id);
            builder
                .Property(prop => prop.Age)
                .HasConversion<byte>()
                .IsRequired()
                .HasColumnName("Age")
                .HasColumnType("TINYINT");
            builder
                .Property(prop => prop.Weight)
                .HasConversion<float>()
                .IsRequired()
                .HasColumnName("Weight")
                .HasColumnType("REAL");
            builder
                .Property(prop => prop.Height)
                .HasConversion<float>()
                .IsRequired()
                .HasColumnName("Height")
                .HasColumnType("REAL");
            builder
                .Property(prop => prop.Complaint)
                .HasConversion<string?>()
                .HasColumnName("Complaint")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Goals)
                .HasConversion<string?>()
                .HasColumnName("Goals")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.LifeHabits)
                .HasConversion<string?>()
                .HasColumnName("LifeHabits")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.FamilyBackground)
                .HasConversion<string?>()
                .HasColumnName("FamilyBackground")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Smoker)
                .HasConversion<bool?>()
                .HasColumnName("Smoker")
                .HasColumnType("BIT");
            builder
                .Property(prop => prop.Alcoholic)
                .HasConversion<bool?>()
                .HasColumnName("Alcoholic")
                .HasColumnType("BIT");
            builder
                .Property(prop => prop.Diabetic)
                .HasConversion<bool?>()
                .HasColumnName("Diabetic")
                .HasColumnType("BIT");
            builder
                .Property(prop => prop.Hypertensive)
                .HasConversion<bool?>()
                .HasColumnName("Hypertensive")
                .HasColumnType("BIT");
            builder
                .Property(prop => prop.Hpa)
                .HasConversion<string?>()
                .HasColumnName("Hpa")
                .HasColumnType("NVARCHAR(10)");
            builder
                .Property(prop => prop.Hpp)
                .HasConversion<string?>()
                .HasColumnName("Hpp")
                .HasColumnType("NVARCHAR(10)");
            builder
                .Property(prop => prop.PhysicalActivity)
                .HasConversion<string?>()
                .HasColumnName("PhysicalActivity")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Medication)
                .HasConversion<string?>()
                .HasColumnName("Medication")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Pains)
                .HasConversion<string?>()
                .HasColumnName("Pains")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.Surgeries)
                .HasConversion<string?>()
                .HasColumnName("Surgeries")
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(prop => prop.InterviewDate)
                .HasConversion<DateTime>()
                .IsRequired()
                .HasColumnName("InterviewDate")
                .HasColumnType("DATE");
            builder
                .HasOne(prop => prop.Prescriber)
                .WithMany()
                .HasForeignKey(prop => prop.Id)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(prop => prop.Patient)
                .WithMany()
                .HasForeignKey(prop => prop.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
