using Prisma.Data.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Data.Entities
{
    public class Evolution : Entity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime EvolutionDate { get; set; }
        public ICollection<Conduct> Conducts { get; set; }
        public Prescriber Prescriber { get; set; }
        public Patient Patient { get; set; }
    }
}
