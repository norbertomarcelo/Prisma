using AutoMapper;
using Prisma.Data.Entities;
using Prisma.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Services
{
    public class AssessmentService
    {
        private readonly AssessmentRepository _assessmentRepository;
        private readonly IMapper _mapper;

        public AssessmentService(AssessmentRepository assessmentRepository, IMapper mapper)
        {
            _assessmentRepository = assessmentRepository;
            _mapper = mapper;
        }

        public Assessment Create()
        {
            throw new NotImplementedException();
        }
    }
}
