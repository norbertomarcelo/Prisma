using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Pathology : Entity
    {
        public string Name { get; set; }
        public int? Pain { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
    }
}
