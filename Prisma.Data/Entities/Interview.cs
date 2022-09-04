using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Interview : Entity
    {
        public byte Age { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public string? Complaint { get; set; }
        public string? Goals { get; set; }
        public string? LifeHabits { get; set; }
        public string? FamilyBackground { get; set; }
        public bool? Smoker { get; set; }
        public bool? Alcoholic { get; set; }
        public bool? Diabetic { get; set; }
        public bool? Hypertensive { get; set; }
        public string? Hpa { get; set; }
        public string? Hpp { get; set; }
        public string? PhysicalActivity { get; set; }
        public string? Medication { get; set; }
        public string? Pains { get; set; }
        public string? Surgeries { get; set; }
        public DateTime InterviewDate { get; set; }
        public Prescriber Prescriber { get; set; }
        public Patient Patient { get; set; }
    }
}
