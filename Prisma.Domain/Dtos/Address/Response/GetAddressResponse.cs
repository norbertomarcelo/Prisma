namespace Prisma.Domain.Dtos.Address.Response
{
    public record struct GetAddressResponse
    (
        string PublicArea,
        string Name,
        string Number,
        string District
    );
}
