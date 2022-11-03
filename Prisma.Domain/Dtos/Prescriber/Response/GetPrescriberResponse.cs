namespace Prisma.Domain.Dtos.Prescriber.Response
{
    public record struct GetPrescriberResponse
    (
        string Name,
        string Cpf,
        string Coffito
    );
}
