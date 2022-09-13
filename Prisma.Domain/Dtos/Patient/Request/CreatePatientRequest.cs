using Prisma.Domain.Dtos.Address.Request;

namespace Prisma.Domain.Dtos.Patient.Request
{
    public class CreatePatientRequest
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Occupation { get; set; }
        public string? CivilStatus { get; set; }
        public string Phone { get; set; }
        public int PrescriberId { get; set; }
        public CreateAddressRequest Address { get; set; }
    }
}
