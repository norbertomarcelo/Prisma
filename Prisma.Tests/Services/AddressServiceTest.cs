using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Contexts;
using Prisma.Data.Entities;
using Prisma.Data.Repositories;
using Prisma.Domain.Dtos.Address.Request;
using Prisma.Domain.Profiles;
using Prisma.Domain.Services;
using Prisma.Tests.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Tests.Services
{
    public class AddressServiceTest
    {
        private readonly DataContext _context;
        private readonly AddressRepository _repository;
        private readonly AddressService _addressService;
        private readonly IMapper _mapper;
        public AddressServiceTest()
        {
            _context = ContextGenerator.GenerateContextInMemory();
            _repository = new AddressRepository(_context);
            _mapper = null;

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AddressProfile());
            });
            _mapper = mappingConfig.CreateMapper();

            _addressService = new AddressService(_repository, _mapper);
        }

        [Theory]
        [InlineData("Rua", "Licínio Pereira Cortês", "Ipiranga", "302 A")]
        [InlineData("Avenida", "7 de Setembro", "São Paulo", "N° 4034 Sala 5509")]
        [InlineData("Condomínio", "Kit-Net", "Glicério", "Sem número")]
        public void ShouldBeRegistrateANewAddress(string publicArea, string name, string district, string number)
        {
            var address = new CreateAddressRequest
            {
                PublicArea = publicArea,
                Name = name,
                District = district,
                Number = number
            };

            _addressService.Create(address);

            Assert.Single(_context.Addresses);
        }
    }
}
