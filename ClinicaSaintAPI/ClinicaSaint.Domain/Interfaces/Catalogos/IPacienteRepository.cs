using ClinicaSaint.Domain.Dto.Catalogos;
using ClinicaSaint.Domain.Dto.Reserva;

namespace ClinicaSaint.API.Controllers.Catalogos
{
    public interface IPacienteRepository
    {
        public Task<PacienteDto[]> GetDataAll();
        public Task<PacienteDto> Save(PacienteDto.Actualizar dataSave);
        public Task<PacienteDto> Update(PacienteDto.Actualizar dataUpdate);
        public Task DeleteById(int id);
    }
}