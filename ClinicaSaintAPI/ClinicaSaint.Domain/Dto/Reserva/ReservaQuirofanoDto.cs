using ClinicaSaint.Domain.Entities.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Dto.Reserva
{
    public partial class ReservaQuirofanoDto
    {
        public int IdReservaQuirofano { get; set; }
        public string NumeroReserva { get; set; }
        public DateTime FechaAgendamiento { get; set; }
        public DateTime FechaCirugia { get; set; }
        public DateTime? InicioCirugia { get; set; }
        public DateTime? FinCirugia { get; set; }
        public int DuracionEstimadaHoras { get; set; }

        // Relaciones
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int MedicoId { get; set; }
        public Medico Medico { get; set; }

        public string Anestesiologo { get; set; }

        public int QuirofanoId { get; set; }
        public Quirofano Quirofano { get; set; }
    }
}
