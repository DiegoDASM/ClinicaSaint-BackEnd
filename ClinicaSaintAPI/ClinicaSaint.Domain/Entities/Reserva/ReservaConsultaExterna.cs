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
    [Table(nameof(ReservaConsultaExterna), Schema = "RES")]
    public class ReservaConsultaExterna : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReservaConsultaExterna { get; set; }

        [Required]
        public string NumeroConsulta { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public TimeSpan Hora { get; set; }

        // Relaciones
       
        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public virtual Paciente? Paciente { get; set; }

        [Required]
        [ForeignKey("Medico")]
        public int IdMedico { get; set; }
        public virtual Medico? Medico { get; set; }

    }
}
