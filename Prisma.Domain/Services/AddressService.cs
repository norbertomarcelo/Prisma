using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;
using Prisma.Data.Repositories;
using Prisma.Domain.Dtos.Address.Request;
using Prisma.Domain.Dtos.Address.Response;
using Prisma.Domain.Exceptions;

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

        public Address Create(CreateAddressRequest request)
        {
            var addressAlreadyRegistered = _addressRepository
                .Select()
                .FirstOrDefault(prop =>
                    prop.District == request.District &&
                    prop.Name == request.Name &&
                    prop.Number == request.Number);

            if (addressAlreadyRegistered is not null)
                throw new EntityAlreadyRegisteredException("Address already registred.");

            var address = _mapper.Map<Address>(request);

            var result = _addressRepository.Insert(address);

            if(result.State != EntityState.Unchanged)
                throw new Exception("Something went wrong. The address provided could not be registered.");

            return result.Entity;
        }

        public GetAddressResponse? Get(int id)
        {
            var address = _addressRepository.Select(id);

            if(address is null)
                throw new EntityNotFoundException($"Address Id = {id} not found.");

            var getAddress = _mapper.Map<GetAddressResponse>(address);

            return getAddress;
        }

        public List<GetAddressResponse> List()
        {
            var addressList = _addressRepository.Select();

            var getAddressList = new List<GetAddressResponse>();

            foreach (var address in addressList)
            {
                getAddressList.Add(_mapper.Map<GetAddressResponse>(address));
            }

            return getAddressList;
        }

        public void Remove(int id)
        {
            var address = _addressRepository.Select(id);

            if (address is null)
                throw new EntityNotFoundException($"Address Id = {id} not found.");

            _addressRepository.Delete(address);
        }

        public void Update(int id, UpdateAddressRequest request)
        {
            var address = _addressRepository.Select(id);

            if (address is null)
                throw new EntityNotFoundException($"Address Id = {id} not found.");

            if (address.PublicArea != request.PublicArea && request.PublicArea is not null) 
                address.PublicArea = request.PublicArea;
            if (address.Name != request.Name && request.Name is not null) 
                address.Name = request.Name;
            if (address.Number != request.Number && request.Number is not null) 
                address.Number = request.Number;
            if (address.District != request.District && request.District is not null) 
                address.District = request.District;

            _addressRepository.Update(address);
        }
    }
}
