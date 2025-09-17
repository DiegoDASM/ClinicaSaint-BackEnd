using AutoMapper;
using ClinicaSaint.Domain.Dto.Reserva;
using ClinicaSaint.Domain.Entities.Reserva;
using ClinicaSaint.Domain.Interfaces.Reserva;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using entReserva = ClinicaSaint.Domain.Entities;

namespace ClinicaSaint.Infrestructura.Repositorios.Reserva
{
    public class ReservaConsultaRepository : IReservaConsultaRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        public ReservaConsultaRepository(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ReservaConsultaExterna[]> GetDataAll()
        {
            try
            {
                var data = await _context.ReservaConsultaExternas
                     .Include(rc => rc.Paciente)
                     .Include(rc => rc.Medico)
                     .ToListAsync();
                return data.ToArray();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener las Reservas", ex);
            }
        }

        public async Task<ReservaConsultaExternaDto> Save(ReservaConsultaExternaDto.Actualizar dataSave)
        {
            int idReservaConsulta = 0;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<entReserva.Reserva.ReservaConsultaExterna>(dataSave);
                    data.FechaRegistro = DateTime.Now;
                    data.IpRegistro = ""; // Consider getting the actual IP if needed
                    data.UsuarioRegistro = ""; // Consider getting the actual user if needed

                    _context.ReservaConsultaExternas.Add(data);
                    await _context.SaveChangesAsync();

                    idReservaConsulta = data.IdReservaConsultaExterna; // Assuming Id is auto-incremented
                    transaction.Commit();

                    var result = _mapper.Map<ReservaConsultaExternaDto>(data);
                    return result;
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
