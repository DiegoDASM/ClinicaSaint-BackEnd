using AutoMapper;
using ClinicaSaint.API.Controllers.Catalogos;
using ClinicaSaint.Domain.Dto.Catalogos;
using ClinicaSaint.Domain.Dto.Reserva;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entReserva = ClinicaSaint.Domain.Entities;

namespace ClinicaSaint.Infrestructura.Repositorios.Catalogos
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;

        public PacienteRepository(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PacienteDto[]> GetDataAll()
        {
            try
            {
                var data = await _context.Paciente
                    .Where(e => e.Activo)
                    .ToListAsync();
                var dta = _mapper.Map<PacienteDto[]>(data);
                return dta;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener los pacientes", ex);
            }
        }
        public async Task<PacienteDto> Save(PacienteDto.Actualizar dataSave)
        {
            int IdPaciente = 0;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<entReserva.Catalogos.Paciente>(dataSave);
                    data.FechaRegistro = DateTime.Now;
                    data.IpRegistro = ""; // Consider getting the actual IP if needed
                    data.UsuarioRegistro = ""; // Consider getting the actual user if needed

                    _context.Paciente.Add(data);
                    await _context.SaveChangesAsync();

                    IdPaciente = data.IdPaciente; // Assuming Id is auto-incremented
                    transaction.Commit();

                    var result = _mapper.Map<PacienteDto>(data);
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex; // Re-throw the exception for caller handling
                }
            }
        }
        public async Task<PacienteDto> Update(PacienteDto.Actualizar dataUpdate)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Buscar la entidad existente
                    var existingData = await _context.Paciente
                        .FirstOrDefaultAsync(r => r.IdPaciente == dataUpdate.IdPaciente);
                    if (existingData == null)
                    {
                        throw new KeyNotFoundException("La reserva de consulta externa no existe.");
                    }

                    // Mapear solo los campos actualizados desde dataUpdate a existingData
                    _mapper.Map(dataUpdate, existingData);

                    // Marcar la entidad como modificada y guardar cambios
                    _context.Paciente.Update(existingData);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    // Retornar la entidad actualizada mapeada al DTO
                    var result = _mapper.Map<PacienteDto>(existingData);
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw; // Re-throw para preservar la pila de excepciones
                }
            }
        }
        public async Task DeleteById(int idPaciente)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var data = await _context.Paciente
                        .FirstOrDefaultAsync(r => r.IdPaciente == idPaciente);
                    if (data == null)
                    {
                        throw new Exception("La reserva de consulta externa no existe.");
                    }

                    // Marcar como eliminado lógicamente
                    data.Activo = false; // Asegúrate de que esta propiedad exista en el modelo
                    data.UsuarioModificacion = "";
                    data.FechaModificacion = DateTime.Now;
                    data.IpModificacion = ""; // Opcional, para registrar cuándo se eliminó

                    await _context.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex; // Re-throw the exception for caller handling
                }
            }
        }
    }
}
