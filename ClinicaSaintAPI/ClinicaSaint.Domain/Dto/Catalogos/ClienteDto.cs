using ClinicaSaint.Domain.Enum.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Dto.Catalogos
{
    public partial class ClienteDto
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public int Cedula { get; set; }
        public string? Correo { get; set; }
        public int Telefono { get; set; }
        public string? Direccion { get; set; }
        public string Especialidad { get; set; }
        public TipoClienteEnum Tipo { get; set; }
    }
}
