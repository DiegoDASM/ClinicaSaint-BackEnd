using AutoMapper;
using ClinicaSaint.Domain.Dto.Catalogos;
using ClinicaSaint.Domain.Interfaces.Catalogos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entReserva = ClinicaSaint.Domain.Entities;

namespace ClinicaSaint.Infrestructura.Repositorios.Catalogos
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;

        public MedicoRepository(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<MedicoDto[]> GetDataAll()
        {
            try
            {
                var data = await _context.Medico
                    .Where(e => e.Activo)
                    .ToListAsync();
                var dta = _mapper.Map<MedicoDto[]>(data);
                return dta;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener los Medicos", ex);
            }
        }
        public async Task<MedicoDto> Save(MedicoDto.Actualizar dataSave)
        {
            int IdMedico = 0;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<entReserva.Catalogos.Medico>(dataSave);
                    data.FechaRegistro = DateTime.Now;
                    data.IpRegistro = ""; // Consider getting the actual IP if needed
                    data.UsuarioRegistro = ""; // Consider getting the actual user if needed

                    _context.Medico.Add(data);
                    await _context.SaveChangesAsync();

                    IdMedico = data.IdMedico; // Assuming Id is auto-incremented
                    transaction.Commit();

                    var result = _mapper.Map<MedicoDto>(data);
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex; // Re-throw the exception for caller handling
                }
            }
        }
        public async Task<MedicoDto> Update(MedicoDto.Actualizar dataUpdate)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Buscar la entidad existente
                    var existingData = await _context.Medico
                        .FirstOrDefaultAsync(r => r.IdMedico == dataUpdate.IdMedico);
                    if (existingData == null)
                    {
                        throw new KeyNotFoundException("EL Medico no existe.");
                    }

                    // Mapear solo los campos actualizados desde dataUpdate a existingData
                    _mapper.Map(dataUpdate, existingData);

                    // Marcar la entidad como modificada y guardar cambios
                    _context.Medico.Update(existingData);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    // Retornar la entidad actualizada mapeada al DTO
                    var result = _mapper.Map<MedicoDto>(existingData);
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw; // Re-throw para preservar la pila de excepciones
                }
            }
        }
        public async Task DeleteById(int idMedico)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var data = await _context.Medico
                        .FirstOrDefaultAsync(r => r.IdMedico == idMedico);
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
