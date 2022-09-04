using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prisma.Data.Migrations
{
    public partial class CreateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicArea = table.Column<string>(type: "NVARCHAR", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR", nullable: false),
                    Number = table.Column<int>(type: "INT", nullable: false),
                    District = table.Column<string>(type: "NVARCHAR", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prescriber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR", nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR", nullable: false),
                    AssessmentDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    DeletionDate = table.Column<DateTime>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    Occupation = table.Column<string>(type: "NVARCHAR", nullable: true),
                    CivilStatus = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Phone = table.Column<string>(type: "NVARCHAR", nullable: true),
                    PrescriberId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    PrescriberId1 = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR", nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR", nullable: false),
                    DeletionDate = table.Column<DateTime>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Prescriber_PrescriberId",
                        column: x => x.PrescriberId,
                        principalTable: "Prescriber",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Prescriber_PrescriberId1",
                        column: x => x.PrescriberId1,
                        principalTable: "Prescriber",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodPressure = table.Column<string>(type: "NVARCHAR", nullable: true),
                    SpO2 = table.Column<byte>(type: "TINYINT", nullable: true),
                    HeartRate = table.Column<byte>(type: "TINYINT", nullable: true),
                    Temperature = table.Column<float>(type: "REAL", nullable: true),
                    Goniometry = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Eva = table.Column<byte>(type: "TINYINT", nullable: true),
                    Palpitation = table.Column<bool>(type: "BIT", nullable: true),
                    AssessmentDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    NextAssessment = table.Column<DateTime>(type: "SMALLDATETIME", nullable: true),
                    PrescriberId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    PatientId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessment_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_Patient_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_Prescriber_PrescriberId",
                        column: x => x.PrescriberId,
                        principalTable: "Prescriber",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Evolution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "NVARCHAR", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR", nullable: false),
                    EvolutionDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    PrescriberId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    PatientId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evolution_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evolution_Patient_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evolution_Prescriber_PrescriberId",
                        column: x => x.PrescriberId,
                        principalTable: "Prescriber",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Interview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<byte>(type: "TINYINT", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    Height = table.Column<float>(type: "REAL", nullable: false),
                    Complaint = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Goals = table.Column<string>(type: "NVARCHAR", nullable: true),
                    LifeHabits = table.Column<string>(type: "NVARCHAR", nullable: true),
                    FamilyBackground = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Smoker = table.Column<bool>(type: "BIT", nullable: true),
                    Alcoholic = table.Column<bool>(type: "BIT", nullable: true),
                    Diabetic = table.Column<bool>(type: "BIT", nullable: true),
                    Hypertensive = table.Column<bool>(type: "BIT", nullable: true),
                    Hpa = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Hpp = table.Column<string>(type: "NVARCHAR", nullable: true),
                    PhysicalActivity = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Medication = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Pains = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Surgeries = table.Column<string>(type: "NVARCHAR", nullable: true),
                    InterviewDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    PrescriberId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    PatientId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interview_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interview_Patient_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interview_Prescriber_PrescriberId",
                        column: x => x.PrescriberId,
                        principalTable: "Prescriber",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pathology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR", nullable: false),
                    Pain = table.Column<string>(type: "NVARCHAR(64)", nullable: true),
                    Location = table.Column<string>(type: "NVARCHAR", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pathology", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pathology_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Conduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "NVARCHAR", nullable: false),
                    EvolutionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conduct_Evolution_EvolutionId",
                        column: x => x.EvolutionId,
                        principalTable: "Evolution",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_PatientId",
                table: "Assessment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_PatientId1",
                table: "Assessment",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_PrescriberId",
                table: "Assessment",
                column: "PrescriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Conduct_EvolutionId",
                table: "Conduct",
                column: "EvolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Evolution_PatientId",
                table: "Evolution",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Evolution_PatientId1",
                table: "Evolution",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Evolution_PrescriberId",
                table: "Evolution",
                column: "PrescriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_PatientId",
                table: "Interview",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_PatientId1",
                table: "Interview",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_PrescriberId",
                table: "Interview",
                column: "PrescriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Pathology_PatientId",
                table: "Pathology",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AddressId",
                table: "Patient",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PrescriberId",
                table: "Patient",
                column: "PrescriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PrescriberId1",
                table: "Patient",
                column: "PrescriberId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessment");

            migrationBuilder.DropTable(
                name: "Conduct");

            migrationBuilder.DropTable(
                name: "Interview");

            migrationBuilder.DropTable(
                name: "Pathology");

            migrationBuilder.DropTable(
                name: "Evolution");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Prescriber");
        }
    }
}
