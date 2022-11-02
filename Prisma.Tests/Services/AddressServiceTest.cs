using AutoMapper;
using Prisma.Data.Contexts;
using Prisma.Data.Repositories;
using Prisma.Domain.Dtos.Address.Request;
using Prisma.Domain.Dtos.Address.Response;
using Prisma.Domain.Exceptions;
using Prisma.Domain.Profiles;
using Prisma.Domain.Services;
using Prisma.Tests.Contexts;

namespace Prisma.Tests.Services
{
    public class AddressServiceTest
    {
        private readonly DataContext _context;
        private readonly AddressRepository _repository;
        private readonly AddressService _service;
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

            _service = new AddressService(_repository, _mapper);
        }

        [Theory]
        [InlineData("Rua", "Licínio Pereira Cortês", "Ipiranga", "302 A")]
        [InlineData("Avenida", "7 de Setembro", "São Paulo", "N° 4034 Sala 5509")]
        [InlineData("Condomínio", "Kit-Net", "Glicério", "Sem número")]
        public void ShouldBeRegistrateANewAddress(string publicArea, string name, string district, string number)
        {
            var request = new CreateAddressRequest
            {
                PublicArea = publicArea,
                Name = name,
                District = district,
                Number = number
            };

            _service.Create(request);

            Assert.Single(_context.Addresses);
        }

        [Theory]
        [InlineData("Rua", "Licínio Pereira Cortês", "Ipiranga", "302 A")]
        [InlineData("Avenida", "7 de Setembro", "São Paulo", "N° 4034 Sala 5509")]
        [InlineData("Condomínio", "Kit-Net", "Glicério", "Sem número")]
        public void ShouldBeThrowsAnExceptionOnTryAddAddress(string publicArea, string name, string district, string number)
        {
            var request = new CreateAddressRequest
            {
                PublicArea = publicArea,
                Name = name,
                District = district,
                Number = number
            };

            _service.Create(request);

            Assert.Throws<EntityAlreadyRegisteredException>(() => _service.Create(request));
        }

        [Fact]
        public void ShouldBeGetAddressById()
        {
            var request1 = new CreateAddressRequest
            {
                PublicArea = "Rua",
                Name = "Licínio Pereira Cortês",
                District = "Ipiranga",
                Number = "120 A"
            };

            var request2 = new CreateAddressRequest
            {
                PublicArea = "Avenida",
                Name = "Altivo Cintra",
                District = "Santa Cândida",
                Number = "302 B"
            };

            _service.Create(request1);
            _service.Create(request2);

            var response1 = _service.Get(1);
            var response2 = _service.Get(2);

            Assert.NotNull(response1);
            Assert.Equal(request1.PublicArea, response1.PublicArea);
            Assert.Equal(request1.Name, response1.Name);
            Assert.Equal(request1.District, response1.District);
            Assert.Equal(request1.Number, response1.Number);

            Assert.NotNull(response2);
            Assert.Equal(request2.PublicArea, response2.PublicArea);
            Assert.Equal(request2.Name, response2.Name);
            Assert.Equal(request2.District, response2.District);
            Assert.Equal(request2.Number, response2.Number);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(9)]
        [InlineData(55)]
        public void ShouldBeThrowsAnExceptionOnTryGetAddress(int id)
        {
            Assert.Throws<EntityNotFoundException>(() => _service.Get(id));
        }

        [Fact]
        public void ShouldBeReturnAListOfAllAddressRegistered()
        {
            var request1 = new CreateAddressRequest
            {
                PublicArea = "Rua",
                Name = "Licínio Pereira Cortês",
                District = "Ipiranga",
                Number = "120 A"
            };

            var request2 = new CreateAddressRequest
            {
                PublicArea = "Avenida",
                Name = "Altivo Cintra",
                District = "Santa Cândida",
                Number = "302 B"
            };

            _service.Create(request1);
            _service.Create(request2);

            var response = _service.List();

            Assert.IsType<List<GetAddressResponse>>(response);
            Assert.False(response.Count() != 2);
        }

        [Fact]
        public void ShouldBeReturnAnEmptyListOfAddress()
        {
            var request1 = new CreateAddressRequest
            {
                PublicArea = "Rua",
                Name = "Licínio Pereira Cortês",
                District = "Ipiranga",
                Number = "120 A"
            };

            var request2 = new CreateAddressRequest
            {
                PublicArea = "Avenida",
                Name = "Altivo Cintra",
                District = "Santa Cândida",
                Number = "302 B"
            };

            _service.Create(request1);
            _service.Create(request2);

            var response = _service.List()
                .Where(prop => prop.Name == "Belo Horizonte")
                .ToList();

            Assert.IsType<List<GetAddressResponse>>(response);
            Assert.False(response.Count() != 0);
        }

        [Fact]
        public void ShouldBeRemoveAddress()
        {
            var request = new CreateAddressRequest
            {
                PublicArea = "Rua",
                Name = "Licínio Pereira Cortês",
                District = "Ipiranga",
                Number = "120 A"
            };

            _service.Create(request);
            Assert.Single(_context.Addresses);

            _service.Remove(1);
            Assert.Empty(_context.Addresses);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(12)]
        [InlineData(98)]
        public void ShouldBeThrowsAnExceptionOnTryRemoveAddress(int id)
        {
            Assert.Throws<EntityNotFoundException>(() => _service.Remove(id));
        }

        [Fact]
        public void ShouldBeUpdateAddress()
        {
            var createRequest = new CreateAddressRequest
            {
                PublicArea = "Rua",
                Name = "Licínio Pereira Cortês",
                District = "Ipiranga",
                Number = "120 A"
            };

            _service.Create(createRequest);

            var updateRequest = new UpdateAddressRequest
            {
                Name = "Altivo Cintra",
                District = "Santa Cândida",
                Number = "302 B"
            };

            _service.Update(1, updateRequest);

            var response = _service.Get(1);

            Assert.NotNull(response);
            Assert.Equal(createRequest.PublicArea, response.PublicArea);
            Assert.Equal(updateRequest.Name, response.Name);
            Assert.Equal(updateRequest.District, response.District);
            Assert.Equal(updateRequest.Number, response.Number);
        }

        [Fact]
        public void ShouldBeThrowsAnExceptionOnTryUpdateAddress()
        {
            var updateRequest = new UpdateAddressRequest
            {
                Name = "Altivo Cintra",
                District = "Santa Cândida",
                Number = "302 B"
            };

            Assert.Throws<EntityNotFoundException>(() => _service.Update(1, updateRequest));
        }
    }
}
