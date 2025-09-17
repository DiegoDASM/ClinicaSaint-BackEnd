using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Entities.Catalogos
{
    [Table(nameof(Quirofano), Schema = "CAT")]
    public class Quirofano : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdQuirofano { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string HorarioDisponible { get; set; }
    }
}
