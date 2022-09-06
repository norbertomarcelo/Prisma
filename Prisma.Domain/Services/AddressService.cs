using AutoMapper;
using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories;
using Prisma.Domain.Dto.Address.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Services
{
    public class AddressService
    {
        private readonly AddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public AddressService(AddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public void Create(CreateAddressRequest request)
        {
            //var addressAlreadyRegistered = _addressRepository
            //    .Select(prop => 
            //            prop.District == request.District &&
            //            prop.Name == request.Name &&
            //            prop.Number == request.Number);

            //if (addressAlreadyRegistered is not null)
            //    throw new Exception("Address already registered.");

            var address = _mapper.Map<Address>(request);

            _addressRepository.Insert(address);
        }
    }
}
