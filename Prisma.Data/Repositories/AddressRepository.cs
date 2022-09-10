using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Shared;

namespace Prisma.Data.Repositories
{
    public class AddressRepository : Repository<Address>
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }
    }
}
