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
        public virtual ICollection<Conduct> Conducts { get; set; }
        public virtual Prescriber Prescriber { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
