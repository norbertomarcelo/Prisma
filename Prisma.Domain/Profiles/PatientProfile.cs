using AutoMapper;
using Prisma.Data.Entities;
using Prisma.Domain.Dtos.Patient.Request;

namespace Prisma.Domain.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<CreatePatientRequest, Patient>();
            CreateMap<Patient, CreatePatientRequest>();
        }
    }
}
