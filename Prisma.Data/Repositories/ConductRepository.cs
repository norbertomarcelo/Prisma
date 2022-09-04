using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Base;

namespace Prisma.Data.Repositories
{
    public class ConductRepository : Repository<Conduct>
    {
        public ConductRepository(DataContext context) : base(context)
        {
        }
    }
}
