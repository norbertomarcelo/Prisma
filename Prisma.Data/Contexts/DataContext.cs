using Microsoft.EntityFrameworkCore;
using Prisma.Data.Entities;
using Prisma.Data.Mappings;

namespace Prisma.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Conduct> Conducts { get; set; }
        public DbSet<Evolution> Evolutions { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Pathology> Pathologies { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescriber> Prescriber { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>(new AddressMapping().Configure);
            modelBuilder.Entity<Assessment>(new AssessmentMapping().Configure);
            modelBuilder.Entity<Conduct>(new ConductMapping().Configure);
            modelBuilder.Entity<Evolution>(new EvolutionMapping().Configure);
            modelBuilder.Entity<Interview>(new InterviewMapping().Configure);
            modelBuilder.Entity<Pathology>(new PathologyMapping().Configure);
            modelBuilder.Entity<Patient>(new PatientMapping().Configure);
            modelBuilder.Entity<Prescriber>(new PrescriberMapping().Configure);
        }
    }
}
