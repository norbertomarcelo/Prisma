using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Address : Entity
    {
        public string PublicArea { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
    }
}
