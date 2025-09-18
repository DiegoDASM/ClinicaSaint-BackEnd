using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Dto.Catalogos
{
    public partial class QuirofanoDto
    {
        public int IdQuirofano { get; set; }
        public string Nombre { get; set; }
        public string? HorarioDisponible { get; set; }
    }
}
