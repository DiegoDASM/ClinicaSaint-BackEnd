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
    [Table(nameof(Cliente), Schema = "CAT")]
    public class Cliente : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        [Required]
        [StringLength(150)]
        public string Nombres { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required]
        [StringLength(200)]
        public string? Correo { get; set; }
        [Required]
        public int Telefono { get; set; }

        [StringLength(200)]
        public string? Direccion { get; set; }
        [Required]
        public string Especialidad { get; set; }
        public TipoClienteEnum Tipo { get; set; }
    }
}
