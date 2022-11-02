using Prisma.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Dtos.Prescriber.Response
{
    public class GetPrescriberResponse
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Coffito { get; set; }
        //public virtual ICollection<Patient>? Patients { get; set; }
    }
}
