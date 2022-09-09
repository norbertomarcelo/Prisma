namespace Prisma.Domain.Dtos.Address.Request
{
    public class UpdateAddressRequest
    {
        public string? PublicArea { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public string? District { get; set; }
    }
}
