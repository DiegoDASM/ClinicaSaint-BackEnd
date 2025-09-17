using ClinicaSaint.Domain.Entities.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Dto.Reserva
{
    public class ReservaConsultaExternaDto
    {
        public int IdConsultaExterna { get; set; }
        public string NumeroConsulta { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        // Relaciones
        public int IdPaciente { get; set; }
        public virtual Paciente? Paciente { get; set; }

        public int IdMedico { get; set; }
        public virtual Medico? Medico { get; set; }

        public class Actualizar
        {
            public int IdConsultaExterna { get; set; }
            public string NumeroConsulta { get; set; }
            public DateTime Fecha { get; set; }
            public TimeSpan Hora { get; set; }

            // Relaciones
            public int IdPaciente { get; set; }
            public int IdMedico { get; set; }
        }
    }
}
