using Microsoft.EntityFrameworkCore;
using Prisma.Data.Contexts;

namespace Prisma.Tests.Contexts
{
    public static class ContextGenerator
    {
        public static DataContext GenerateContextInMemory()
        {
            var optionBuilder = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());

            return new DataContext(optionBuilder.Options);
        }
    }
}
