using AutoMapper;
using Prisma.Data.Entities;
using Prisma.Domain.Dtos.Prescriber.Request;
using Prisma.Domain.Dtos.Prescriber.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Profiles
{
    public class PrescriberProfile : Profile
    {
        public PrescriberProfile()
        {
            CreateMap<CreatePrescriberRequest, Prescriber>();
            CreateMap<Prescriber, GetPrescriberResponse>();
        }
    }
}
