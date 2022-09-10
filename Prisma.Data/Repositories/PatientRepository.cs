using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories.Shared;

namespace Prisma.Data.Repositories
{
    public class PatientRepository : Repository<Patient>
    {
        public PatientRepository(DataContext context) : base(context)
        {
        }
    }
}
