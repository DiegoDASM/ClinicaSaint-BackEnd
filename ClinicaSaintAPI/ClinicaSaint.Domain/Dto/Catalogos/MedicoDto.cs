using ClinicaSaint.Domain.Enum.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Dto.Catalogos
{
    public partial class MedicoDto
    {
        public int IdMedico { get; set; }
        public string NombreCompleto { get; set; }
        public int Identificacion { get; set; }
        public GeneroEnum Genero { get; set; }
        public string Correo { get; set; }
        public string? Telefono { get; set; }
        public string Especialidad { get; set; }
        public class Actualizar
        {
            public int IdMedico { get; set; }
            public string NombreCompleto { get; set; }
            public int Identificacion { get; set; }
            public GeneroEnum Genero { get; set; }
            public string Correo { get; set; }
            public string? Telefono { get; set; }
            public string Especialidad { get; set; }
        }
    }
}
