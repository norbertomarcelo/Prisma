namespace Prisma.Domain.Dtos.Address.Request
{
    public record struct CreateAddressRequest
    (
        string PublicArea,
        string Name,
        string Number,
        string District
    );
}
