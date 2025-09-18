using AutoMapper;
using ClinicaSaint.Domain.Dto.Catalogos;
using ClinicaSaint.Domain.Dto.Reserva;
using ClinicaSaint.Domain.Entities.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSModel = ClinicaSaint.Domain.Entities;

namespace ClinicaSaint.Domain.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Mapeo de Catalogos
            
            CreateMap<CSModel.Catalogos.Paciente, PacienteDto>();
            CreateMap<PacienteDto, CSModel.Catalogos.Paciente>();

            CreateMap<CSModel.Catalogos.Paciente, PacienteDto.Actualizar>();
            CreateMap<PacienteDto.Actualizar, CSModel.Catalogos.Paciente>();

            CreateMap<PacienteDto.Actualizar, PacienteDto>();
            CreateMap<PacienteDto, PacienteDto.Actualizar>();

            //--------------------------------------------------

            CreateMap<CSModel.Catalogos.Medico, MedicoDto>();
            CreateMap<MedicoDto, CSModel.Catalogos.Medico>();

            CreateMap<CSModel.Catalogos.Medico, MedicoDto.Actualizar>();
            CreateMap<MedicoDto.Actualizar, CSModel.Catalogos.Medico>();

            CreateMap<MedicoDto.Actualizar, MedicoDto>();
            CreateMap<MedicoDto, MedicoDto.Actualizar>();

            #endregion

            #region Mapeo de Reservas

            CreateMap<CSModel.Reserva.ReservaConsultaExterna, ReservaConsultaExternaDto>();
            CreateMap<ReservaConsultaExternaDto, CSModel.Reserva.ReservaConsultaExterna>();

            CreateMap<CSModel.Reserva.ReservaConsultaExterna, ReservaConsultaExternaDto.Actualizar>();
            CreateMap<ReservaConsultaExternaDto.Actualizar, CSModel.Reserva.ReservaConsultaExterna>();

            CreateMap<ReservaConsultaExternaDto.Actualizar, ReservaConsultaExternaDto>();
            CreateMap<ReservaConsultaExternaDto, ReservaConsultaExternaDto.Actualizar>();

            #endregion
        }
    }
}
