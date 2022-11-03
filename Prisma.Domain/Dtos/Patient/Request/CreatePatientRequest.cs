using Prisma.Domain.Dtos.Address.Request;

namespace Prisma.Domain.Dtos.Patient.Request
{
    public record struct CreatePatientRequest
    (
        string Name,
        string Cpf,
        DateTime BirthDate,
        string? Occupation,
        string? CivilStatus,
        string Phone,
        int PrescriberId,
        CreateAddressRequest Address
    );
}
