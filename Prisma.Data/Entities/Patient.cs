using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Patient : Person
    {
        public DateTime BirthDate { get; set; }
        public string? Occupation { get; set; }
        public string? CivilStatus { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<Interview>? Interviews { get; set; }
        public virtual ICollection<Assessment>? Assessments { get; set; }
        public virtual ICollection<Pathology>? Pathologies { get; set; }
        public virtual ICollection<Evolution>? Evolutions { get; set; }
        public virtual Prescriber Prescriber { get; set; }
        public virtual Address Address { get; set; }
    }
}
