using Prisma.Data.Entities.Abstracts;

namespace Prisma.Data.Entities
{
    public class Address : Entity
    {
        public string PublicArea { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string District { get; set; }

        public override bool Equals(object o)
        {
            if (o is Address)
            {
                Address a = (Address)o;
                if (this.Id == a.Id && 
                    this.PublicArea == a.PublicArea &&
                    this.Name == a.Name &&
                    this.Number == a.Number &&
                    this.District == a.District
                )
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
