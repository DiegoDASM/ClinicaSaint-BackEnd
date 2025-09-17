using ClinicaSaint.Domain.Entities.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Entities.Reserva
{
    [Table(nameof(ReservaQuirofano), Schema = "RES")]
    public class ReservaQuirofano : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReservaQuirofano { get; set; }

        [Required, StringLength(20)]
        public string NumeroReserva { get; set; }

        [Required]
        public DateTime FechaAgendamiento { get; set; }

        [Required]
        public DateTime FechaCirugia { get; set; }

        public DateTime? InicioCirugia { get; set; }
        public DateTime? FinCirugia { get; set; }

        public int DuracionEstimadaHoras { get; set; }

        // Relaciones
        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public virtual Paciente? Paciente { get; set; }

        [Required]
        [ForeignKey("Medico")]
        public int IdMedico { get; set; }
        public virtual Medico? Medico { get; set; }

        public string Anestesiólogo { get; set; }

        //public int? AnestesiologoId { get; set; }
        //public Anestesiologo Anestesiologo { get; set; }

        [Required]
        [ForeignKey("Quirofano")]
        public int IdQuirofano { get; set; }
        public virtual Quirofano? Quirofano { get; set; }
    }
}
