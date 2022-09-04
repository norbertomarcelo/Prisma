using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Base;

namespace Prisma.Data.Repositories
{
    public class PathologyRepository : Repository<Pathology>
    {
        public PathologyRepository(DataContext context) : base(context)
        {
        }
    }
}
