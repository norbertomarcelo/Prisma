namespace Prisma.Domain.Dtos.Address.Request
{
    public record struct UpdateAddressRequest
    (
        string? PublicArea,
        string? Name,
        string? Number,
        string? District
    );
}
