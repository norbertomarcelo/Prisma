namespace Prisma.Domain.Dto.Address.Request
{
    public class CreateAddressRequest
    {
        public string PublicArea { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
    }
}
