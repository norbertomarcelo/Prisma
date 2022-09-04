using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Patient : Person
    {
        public DateTime BirthDate { get; set; }
        public string? Occupation { get; set; }
        public string? CivilStatus { get; set; }
        public string? Phone { get; set; }
        public ICollection<Interview>? Interviews { get; set; }
        public ICollection<Assessment>? Assessments { get; set; }
        public ICollection<Pathology>? Pathologies { get; set; }
        public ICollection<Evolution>? Evolutions { get; set; }
        public Prescriber Prescriber { get; set; }
        public Address Address { get; set; }
    }
}
