using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Base;

namespace Prisma.Data.Repositories
{
    public class EvolutionRepository : Repository<Evolution>
    {
        public EvolutionRepository(DataContext context) : base(context)
        {
        }
    }
}
