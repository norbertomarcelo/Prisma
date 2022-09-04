using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Prescriber : Person
    {
        public string Coffito { get; set; }
        public ICollection<Patient>? Patients { get; set; }
    }
}
