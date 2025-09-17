using ClinicaSaint.Domain.Entities.Catalogos;
using ClinicaSaint.Domain.Entities.Reserva;
using Microsoft.EntityFrameworkCore;

namespace ClinicaSaint.Infrestructura
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> op) : base(op) 
        {}

        #region DbSets

        #region Catalogos
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Quirofano> Quirofano { get; set; }
        public DbSet<Cirugia> Cirugia { get; set; }

        #endregion

        #region Reserva

        public DbSet<ReservaConsultaExterna> ReservaConsultaExternas { get; set; }
        public DbSet<ReservaQuirofano> ReservaQuirofano { get; set; }

        #endregion

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
        }
    }
}
