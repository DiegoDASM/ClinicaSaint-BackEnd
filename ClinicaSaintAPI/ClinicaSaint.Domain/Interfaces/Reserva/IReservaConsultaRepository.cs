using ClinicaSaint.Domain.Dto.Reserva;
using ClinicaSaint.Domain.Entities.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Interfaces.Reserva
{
    public interface IReservaConsultaRepository
    {
       public Task<ReservaConsultaExternaDto[]> GetDataAll();
       public Task<ReservaConsultaExternaDto> Save(ReservaConsultaExternaDto.Actualizar dataSave);
       public Task<ReservaConsultaExternaDto> Update(ReservaConsultaExternaDto.Actualizar dataUpdate);
       public Task DeleteById(int idReservaConsultaExterna);
    }
}
