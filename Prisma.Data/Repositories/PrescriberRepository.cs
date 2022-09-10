using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Shared;

namespace Prisma.Data.Repositories
{
    public class PrescriberRepository : Repository<Prescriber>
    {
        public PrescriberRepository(DataContext context) : base(context)
        {
        }
    }
}
