using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Conduct : Entity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public virtual Evolution Evolution { get; set; }
    }
}
