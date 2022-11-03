namespace Prisma.Domain.Dtos.Patient.Request
{
    public record struct UpdatePatientRequest
    (
        string? Name,
        string? Cpf,
        DateTime? BirthDate,
        string? Occupation,
        string? CivilStatus,
        string? Phone
    );
}
