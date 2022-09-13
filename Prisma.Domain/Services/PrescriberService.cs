using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;
using Prisma.Data.Repositories;
using Prisma.Domain.Dtos.Prescriber.Request;
using Prisma.Domain.Dtos.Prescriber.Response;
using Prisma.Domain.Exceptions;

namespace Prisma.Domain.Services
{
    public class PrescriberService
    {
        private readonly PrescriberRepository _prescriberRepository;
        private readonly IMapper _mapper;

        public PrescriberService(PrescriberRepository prescriberRepository, IMapper mapper)
        {
            _prescriberRepository = prescriberRepository;
            _mapper = mapper;
        }

        public Prescriber Create(CreatePrescriberRequest request)
        {
            var prescriberAlreadyRegistred = _prescriberRepository
                .Select()
                .FirstOrDefault(prop => prop.Cpf == request.Cpf || prop.Coffito == request.Coffito);

            if (prescriberAlreadyRegistred is not null)
                throw new EntityAlreadyRegisteredException("Prescriber already registred.");

            var prescriber = _mapper.Map<Prescriber>(request);
            prescriber.RegistrationDate = DateTime.Now;

            var result = _prescriberRepository.Insert(prescriber);

            if (result.State != EntityState.Unchanged)
                throw new Exception("Something went wrong. The prescriber provided could not be registered.");

            return result.Entity;
        }

        public GetPrescriberResponse? Get(int id)
        {
            var prescriber = _prescriberRepository.Select(id);

            if (prescriber is null)
                throw new EntityNotFoundException($"Prescriber Id = {id} not found.");

            var getPrescriber = _mapper.Map<GetPrescriberResponse>(prescriber);

            return getPrescriber;
        }

        public IList<GetPrescriberResponse> List()
        {
            var prescriberList = _prescriberRepository.Select();

            var getPrescriberList = new List<GetPrescriberResponse>();

            foreach (var prescriber in prescriberList)
            {
                getPrescriberList.Add(_mapper.Map<GetPrescriberResponse>(prescriber));
            }

            return getPrescriberList;
        }

        public void Remove(int id)
        {
            var prescriber = _prescriberRepository.Select(id);

            if (prescriber is null)
                throw new EntityNotFoundException($"Prescriber Id = {id} not found.");

            _prescriberRepository.Delete(prescriber);
        }

        public void Update(int id, UpdatePrescriberRequest request)
        {
            var prescriber = _prescriberRepository.Select(id);

            if (prescriber is null)
                throw new EntityNotFoundException($"Prescriber Id = {id} not found.");

            if (prescriber.Cpf != request.Cpf && request.Cpf is not null)
                prescriber.Cpf = request.Cpf;
            if (prescriber.Name != request.Name && request.Name is not null)
                prescriber.Name = request.Name;
            if (prescriber.Coffito != request.Coffito && request.Coffito is not null)
                prescriber.Coffito = request.Coffito;

            _prescriberRepository.Update(prescriber);
        }
    }
}
