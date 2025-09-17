using ClinicaSaint.Domain.Common;
using ClinicaSaint.Domain.Dto.Reserva;
using ClinicaSaint.Domain.Entities.Reserva;
using ClinicaSaint.Domain.Interfaces.Reserva;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaSaint.API.Controllers.Reserva
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaConsultaController : Controller
    {
        private readonly IReservaConsultaRepository _reservaConsultaRepository;
        public ReservaConsultaController(IReservaConsultaRepository reservaConsultaRepository)
        {
            _reservaConsultaRepository = reservaConsultaRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var data = await _reservaConsultaRepository.GetDataAll();
                return Ok(new JsonResponse<ReservaConsultaExterna[]>(data));
            }
            catch (Exception ex)
            {

                return BadRequest(new JsonResponse<ReservaConsultaExterna[]>(null, ex.Message, ResponseStatus.error));
            }
        }

        [HttpPost]
        public async Task<ActionResult> Save([FromBody] ReservaConsultaExternaDto.Actualizar dataSave)
        {
            try
            {
                // Lógica para guardar la reserva de consulta externa
                var data = await _reservaConsultaRepository.Save(dataSave);
                return Ok(new JsonResponse<ReservaConsultaExternaDto>(data));
            }
            catch (Exception ex)
            {
                return BadRequest(new JsonResponse<ReservaConsultaExternaDto>(null, ex.Message, ResponseStatus.error));
            }

        }
    }
}
