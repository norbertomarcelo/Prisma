using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Contexts;
using Prisma.Data.Repositories;
using Prisma.Data.Repositories.Shared;
using Prisma.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
