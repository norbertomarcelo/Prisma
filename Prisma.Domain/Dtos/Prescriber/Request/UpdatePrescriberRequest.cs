namespace Prisma.Domain.Dtos.Prescriber.Request
{
    public record struct UpdatePrescriberRequest
    (
        string? Name,
        string? Cpf,
        string? Coffito
    );
}
