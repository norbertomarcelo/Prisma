using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Shared;

namespace Prisma.Data.Repositories
{
    public class AssessmentRepository : Repository<Assessment>
    {
        public AssessmentRepository(DataContext context) : base(context)
        {
        }
    }
}
