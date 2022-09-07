using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Assessment : Entity
    {
        public string? BloodPressure { get; set; }
        public byte? SpO2 { get; set; }
        public byte? HeartRate { get; set; }
        public float? Temperature { get; set; }
        public string? Goniometry { get; set; }
        public byte? Eva { get; set; }
        public string? Glasgow { get; set; }
        public bool? Palpitation { get; set; }
        public DateTime AssessmentDate { get; set; }
        public DateTime? NextAssessment { get; set; }
        public virtual Prescriber Prescriber { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
