using Prisma.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Dtos.Assessment.Request
{
    public class CreateAssessmentRequest
    {
        public string? BloodPressure { get; set; }
        public byte? SpO2 { get; set; }
        public byte? HeartRate { get; set; }
        public float? Temperature { get; set; }
        public string? Goniometry { get; set; }
        public byte? Eva { get; set; }
        public string? Glasgow { get; set; }
        public bool? Palpitation { get; set; }
        public DateTime? NextAssessment { get; set; }
        //public virtual Prescriber Prescriber { get; set; }
        //public virtual Patient Patient { get; set; }
    }
}
