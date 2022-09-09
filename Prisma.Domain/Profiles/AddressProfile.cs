using AutoMapper;
using Prisma.Data.Entities;
using Prisma.Domain.Dtos.Address.Request;
using Prisma.Domain.Dtos.Address.Response;

namespace Prisma.Domain.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<CreateAddressRequest, Address>();
            CreateMap<Address, GetAddressResponse>();
            CreateMap<UpdateAddressRequest, Address>();
        }
    }
}
