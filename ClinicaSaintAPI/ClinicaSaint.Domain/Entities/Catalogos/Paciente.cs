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
    [Table(nameof(Paciente), Schema = "CAT")]
    public class Paciente : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPaciente { get; set; }

        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public string Cedula { get; set; }

        [Required]
        public DateTime? FechaNacimiento { get; set; }

        [Required]
        public decimal Edad { get; set; }
        public GeneroEnum Genero { get; set; }

        [StringLength(30)]
        public string Telefono { get; set; }

        [StringLength(200)]
        public string Correo { get; set; }

        [StringLength(200)]
        public string? Direccion { get; set; }
    }
}
