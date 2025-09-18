using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Dto.Catalogos
{
    public partial class CirugiaDto
    {
        public int IdCirugia { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
