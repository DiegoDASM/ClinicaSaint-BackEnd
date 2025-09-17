using AutoMapper;
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
