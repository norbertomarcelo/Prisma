using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Domain.Dtos.Prescriber.Request
{
    public class CreatePrescriberRequest
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Coffito { get; set; }
    }
}
