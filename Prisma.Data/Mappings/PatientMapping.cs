using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class PatientMapping : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder
                .ToTable("Patient");
            builder
                .HasKey(prop => prop.Id);
            builder
                .Property(prop => prop.Name)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.Cpf)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Cpf")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.RegistrationDate)
                .HasConversion<DateTime>()
                .IsRequired()
                .HasColumnName("AssessmentDate")
                .HasColumnType("DATE");
            builder
                .Property(prop => prop.DeletionDate)
                .HasConversion<DateTime?>()
                .HasColumnName("DeletionDate")
                .HasColumnType("DATE");
            builder
                .Property(prop => prop.BirthDate)
                .HasConversion<DateTime>()
                .IsRequired()
                .HasColumnName("AssessmentDate")
                .HasColumnType("DATE");
            builder
                .Property(prop => prop.Occupation)
                .HasConversion<string?>()
                .HasColumnName("Occupation")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.CivilStatus)
                .HasConversion<string?>()
                .HasColumnName("CivilStatus")
                .HasColumnType("NVARCHAR");
            builder
                .Property(prop => prop.Phone)
                .HasConversion<string?>()
                .HasColumnName("Phone")
                .HasColumnType("NVARCHAR");
            builder
                .HasMany(prop => prop.Interviews)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(prop => prop.Assessments)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasMany(prop => prop.Pathologies);
            builder
                .HasMany(prop => prop.Evolutions)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(prop => prop.Prescriber)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(prop => prop.Address);
        }
    }
}
