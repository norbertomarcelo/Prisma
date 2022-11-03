namespace Prisma.Domain.Dtos.Prescriber.Request
{
    public record struct CreatePrescriberRequest
    (
        string Name,
        string Cpf,
        string Coffito
    );
}
