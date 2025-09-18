using ClinicaSaint.Domain.Enum.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Dto.Catalogos
{
    public partial class PacienteDto
    {
        public int IdPaciente { get; set; }
        public string NombreCompleto { get; set; }
        public int Cedula { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public GeneroEnum Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string? Direccion { get; set; }

        public class Actualizar
        {
            public int IdPaciente { get; set; }
            public string NombreCompleto { get; set; }
            public int Cedula { get; set; }
            public DateTime? FechaNacimiento { get; set; }
            public int Edad { get; set; }
            public GeneroEnum Genero { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string? Direccion { get; set; }
        }
    }
}
