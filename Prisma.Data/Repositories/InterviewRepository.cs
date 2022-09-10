using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Shared;

namespace Prisma.Data.Repositories
{
    public class InterviewRepository : Repository<Interview>
    {
        public InterviewRepository(DataContext context) : base(context)
        {
        }
    }
}
