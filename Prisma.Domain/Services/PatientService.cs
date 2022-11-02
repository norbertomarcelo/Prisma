using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;
using Prisma.Data.Repositories;
using Prisma.Domain.Dtos.Patient.Request;
using Prisma.Domain.Exceptions;

namespace Prisma.Domain.Services
{
    public class PatientService
    {
        private readonly PatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public PatientService(PatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        public Patient Create(CreatePatientRequest request)
        {
            var patientAlreadyRegistred = _patientRepository
                .Select()
                .FirstOrDefault(prop => prop.Cpf == request.Cpf);

            if (patientAlreadyRegistred is not null)
                throw new EntityAlreadyRegisteredException("Patient already registred.");

            var patient = _mapper.Map<Patient>(request);
            patient.RegistrationDate = DateTime.Now;

            var result = _patientRepository.Insert(patient);

            if (result.State != EntityState.Unchanged)
                throw new Exception("Something went wrong. The patient provided could not be registered.");

            return result.Entity;
        }

        public GetPatientResponse? Get(int id)
        {
            var patient = _patientRepository.Select(id);

            if (patient is null)
                throw new EntityNotFoundException($"Patient Id = {id} not found.");

            var getPatient = _mapper.Map<GetPatientResponse>(patient);

            return getPatient;
        }

        public IList<GetPatientResponse> List()
        {
            var patientList = _patientRepository.Select();

            var getPatientList = new List<GetPatientResponse>();

            foreach (var patient in patientList)
            {
                getPatientList.Add(_mapper.Map<GetPatientResponse>(patient));
            }

            return getPatientList;
        }

        public void Remove(int id)
        {
            var patient = _patientRepository.Select(id);

            if (patient is null)
                throw new EntityNotFoundException($"Patient Id = {id} not found.");

            _patientRepository.Delete(patient);
        }

        public void Update(int id, UpdatePatientRequest request)
        {
            int test = 1;
        }
    }
}
