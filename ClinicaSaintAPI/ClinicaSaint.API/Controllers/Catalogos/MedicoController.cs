using ClinicaSaint.Domain.Common;
using ClinicaSaint.Domain.Dto.Catalogos;
using ClinicaSaint.Domain.Interfaces.Catalogos;
using ClinicaSaint.Infrestructura;
using ClinicaSaint.Infrestructura.Repositorios.Catalogos;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaSaint.API.Controllers.Catalogos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoController : Controller
    {
        private readonly IMedicoRepository _medicoRepository;
        public MedicoController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var data = await _medicoRepository.GetDataAll();
                return Ok(new JsonResponse<MedicoDto[]>(data));
            }
            catch (Exception ex)
            {

                return BadRequest(new JsonResponse<MedicoDto[]>(null, ex.Message, ResponseStatus.error));
            }

        }
        [HttpPost("Save/")]
        public async Task<ActionResult> Save([FromBody] MedicoDto.Actualizar dataSave)
        {
            try
            {
                var data = await _medicoRepository.Save(dataSave);
                return Ok(new JsonResponse<MedicoDto>(data));
            }
            catch (Exception ex)
            {

                return BadRequest(new JsonResponse<MedicoDto>(null, ex.Message, ResponseStatus.error));
            }
        }
        [HttpPut("Update/")]
        public async Task<ActionResult> Update([FromBody] MedicoDto.Actualizar dataUpdate)
        {
            try
            {
                // Lógica para actualizar la reserva de consulta externa
                var data = await _medicoRepository.Update(dataUpdate);
                return Ok(new JsonResponse<MedicoDto>(data));
            }
            catch (Exception ex)
            {
                return BadRequest(new JsonResponse<MedicoDto>(null, ex.Message, ResponseStatus.error));
            }
        }
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _medicoRepository.DeleteById(id);

                return Ok(new JsonResponse<bool>(true));
            }
            catch (Exception ex)
            {
                return BadRequest(new JsonResponse<string>(null, ex.Message, ResponseStatus.error));
            }
        }
    }
}
