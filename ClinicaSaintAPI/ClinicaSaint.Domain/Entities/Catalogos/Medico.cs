using ClinicaSaint.Domain.Enum.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Entities.Catalogos
{
    [Table(nameof(Medico), Schema = "CAT")]
    public class Medico : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedico { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreCompleto { get; set; }

        [Required]
        [StringLength(20)]
        public int Identificacion { get; set; }
        public GeneroEnum Genero { get; set; }

        [Required]
        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string Especialidad { get; set; }
    }
}
