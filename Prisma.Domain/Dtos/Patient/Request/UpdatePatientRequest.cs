using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Dtos.Patient.Request
{
    public class UpdatePatientRequest
    {
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Occupation { get; set; }
        public string? CivilStatus { get; set; }
        public string? Phone { get; set; }
    }
}
