using ClinicaSaint.Domain.Common;
using ClinicaSaint.Domain.Dto.Catalogos;
using ClinicaSaint.Domain.Dto.Reserva;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaSaint.API.Controllers.Catalogos
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : Controller
    {
        private readonly IPacienteRepository _pacienteRepository;
        public PacienteController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var data = await _pacienteRepository.GetDataAll();
                return Ok(new JsonResponse<PacienteDto[]>(data));
            }
            catch (Exception ex)
            {

                return BadRequest(new JsonResponse<PacienteDto[]>(null, ex.Message, ResponseStatus.error));
                
            }
        }
        [HttpPost("Save/")]
        public async Task<ActionResult> Save([FromBody] PacienteDto.Actualizar dataSave)
        {
            try
            {
                var data = await _pacienteRepository.Save(dataSave);
                return Ok(new JsonResponse<PacienteDto>(data));
            }
            catch (Exception ex)
            {

                return BadRequest(new JsonResponse<PacienteDto>(null, ex.Message, ResponseStatus.error));
            }
        }
        [HttpPut("Update/")]
        public async Task<ActionResult> Update([FromBody] PacienteDto.Actualizar dataUpdate)
        {
            try
            {
                // Lógica para actualizar la reserva de consulta externa
                var data = await _pacienteRepository.Update(dataUpdate);
                return Ok(new JsonResponse<PacienteDto>(data));
            }
            catch (Exception ex)
            {
                return BadRequest(new JsonResponse<PacienteDto>(null, ex.Message, ResponseStatus.error));
            }
        }
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _pacienteRepository.DeleteById(id);

                return Ok(new JsonResponse<bool>(true));
            }
            catch (Exception ex)
            {
                return BadRequest(new JsonResponse<string>(null, ex.Message, ResponseStatus.error));
            }
        }
    }
}
