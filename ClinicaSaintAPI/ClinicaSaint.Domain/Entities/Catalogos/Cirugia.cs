using ClinicaSaint.Domain.Entities.Reserva;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Entities.Catalogos
{
    [Table(nameof(Cirugia), Schema = "CAT")]
    public class Cirugia : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCirugia { get; set; }

        [Required, StringLength(20)]
        public string Codigo { get; set; }

        [Required, StringLength(200)]
        public string Nombre { get; set; }

        // Relación con la reserva
        [Required]
        [ForeignKey("IdReservaQuirofano")]
        public virtual ReservaQuirofano? Reserva { get; set; }
    }
}
