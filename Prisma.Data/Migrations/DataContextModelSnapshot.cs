﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prisma.Data.Contexts;

#nullable disable

namespace Prisma.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Prisma.Data.Entities.Address", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("District");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("Number");

                    b.Property<string>("PublicArea")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("PublicArea");

                    b.HasKey("Id");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Assessment", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("AssessmentDate")
                        .HasColumnType("DATE")
                        .HasColumnName("AssessmentDate");

                    b.Property<string>("BloodPressure")
                        .HasColumnType("NVARCHAR(20)")
                        .HasColumnName("BloodPressure");

                    b.Property<byte?>("Eva")
                        .HasColumnType("TINYINT")
                        .HasColumnName("Eva");

                    b.Property<string>("Glasgow")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("NVARCHAR(20)")
                        .HasColumnName("Goniometry");

                    b.Property<string>("Goniometry")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("NVARCHAR(20)")
                        .HasColumnName("Goniometry");

                    b.Property<byte?>("HeartRate")
                        .HasColumnType("TINYINT")
                        .HasColumnName("HeartRate");

                    b.Property<DateTime?>("NextAssessment")
                        .HasColumnType("SMALLDATETIME")
                        .HasColumnName("NextAssessment");

                    b.Property<bool?>("Palpitation")
                        .HasColumnType("BIT")
                        .HasColumnName("Palpitation");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<byte?>("SpO2")
                        .HasColumnType("TINYINT")
                        .HasColumnName("SpO2");

                    b.Property<float?>("Temperature")
                        .HasColumnType("REAL")
                        .HasColumnName("Temperature");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Assessment", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Conduct", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(1000)")
                        .HasColumnName("Description");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Header");

                    b.HasKey("Id");

                    b.ToTable("Conduct", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Evolution", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(1000)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("EvolutionDate")
                        .HasColumnType("DATE")
                        .HasColumnName("EvolutionDate");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Header");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("PrescriberId");

                    b.ToTable("Evolution", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Interview", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<byte>("Age")
                        .HasColumnType("TINYINT")
                        .HasColumnName("Age");

                    b.Property<bool?>("Alcoholic")
                        .HasColumnType("BIT")
                        .HasColumnName("Alcoholic");

                    b.Property<string>("Complaint")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Complaint");

                    b.Property<bool?>("Diabetic")
                        .HasColumnType("BIT")
                        .HasColumnName("Diabetic");

                    b.Property<string>("FamilyBackground")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("FamilyBackground");

                    b.Property<string>("Goals")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Goals");

                    b.Property<float>("Height")
                        .HasColumnType("REAL")
                        .HasColumnName("Height");

                    b.Property<string>("Hpa")
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("Hpa");

                    b.Property<string>("Hpp")
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("Hpp");

                    b.Property<bool?>("Hypertensive")
                        .HasColumnType("BIT")
                        .HasColumnName("Hypertensive");

                    b.Property<DateTime>("InterviewDate")
                        .HasColumnType("DATE")
                        .HasColumnName("InterviewDate");

                    b.Property<string>("LifeHabits")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("LifeHabits");

                    b.Property<string>("Medication")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Medication");

                    b.Property<string>("Pains")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Pains");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PhysicalActivity")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("PhysicalActivity");

                    b.Property<bool?>("Smoker")
                        .HasColumnType("BIT")
                        .HasColumnName("Smoker");

                    b.Property<string>("Surgeries")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Surgeries");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL")
                        .HasColumnName("Weight");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Interview", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Pathology", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(1000)")
                        .HasColumnName("Description");

                    b.Property<string>("Location")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Pain")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Pain");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Pathology", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Patient", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATE")
                        .HasColumnName("BirthDate");

                    b.Property<string>("CivilStatus")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("CivilStatus");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Cpf");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("DATE")
                        .HasColumnName("DeletionDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Occupation")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Occupation");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Phone");

                    b.Property<int>("PrescriberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("DATE")
                        .HasColumnName("RegistrationDate");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("PrescriberId");

                    b.ToTable("Patient", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Prescriber", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Coffito")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Coffito");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Cpf");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("DATE")
                        .HasColumnName("DeletionDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("DATE")
                        .HasColumnName("AssessmentDate");

                    b.HasKey("Id");

                    b.ToTable("Prescriber", (string)null);
                });

            modelBuilder.Entity("Prisma.Data.Entities.Assessment", b =>
                {
                    b.HasOne("Prisma.Data.Entities.Patient", null)
                        .WithMany("Assessments")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Prescriber", "Prescriber")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Prescriber");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Conduct", b =>
                {
                    b.HasOne("Prisma.Data.Entities.Evolution", "Evolution")
                        .WithMany("Conducts")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Evolution");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Evolution", b =>
                {
                    b.HasOne("Prisma.Data.Entities.Patient", null)
                        .WithMany("Evolutions")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Prescriber", "Prescriber")
                        .WithMany()
                        .HasForeignKey("PrescriberId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Prescriber");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Interview", b =>
                {
                    b.HasOne("Prisma.Data.Entities.Patient", null)
                        .WithMany("Interviews")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Prescriber", "Prescriber")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Prescriber");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Pathology", b =>
                {
                    b.HasOne("Prisma.Data.Entities.Patient", null)
                        .WithMany("Pathologies")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Patient", b =>
                {
                    b.HasOne("Prisma.Data.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Prescriber", null)
                        .WithMany("Patients")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Prisma.Data.Entities.Prescriber", "Prescriber")
                        .WithMany()
                        .HasForeignKey("PrescriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Prescriber");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Evolution", b =>
                {
                    b.Navigation("Conducts");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Patient", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("Evolutions");

                    b.Navigation("Interviews");

                    b.Navigation("Pathologies");
                });

            modelBuilder.Entity("Prisma.Data.Entities.Prescriber", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
