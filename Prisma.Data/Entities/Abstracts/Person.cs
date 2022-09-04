namespace Prisma.Data.Entities.Abstracts
{
    public abstract class Person : Entity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}
