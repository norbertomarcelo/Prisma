﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;

namespace Prisma.Data.Mappings
{
    public class PrescriberMapping : IEntityTypeConfiguration<Prescriber>
    {
        public void Configure(EntityTypeBuilder<Prescriber> builder)
        {
            builder
                .ToTable("Prescriber");
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
                .Property(prop => prop.Coffito)
                .HasConversion<string>()
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR");
            builder
                .HasMany(prop => prop.Patients)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
