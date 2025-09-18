using ClinicaSaint.Domain.Dto.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSaint.Domain.Interfaces.Catalogos
{
    public interface IMedicoRepository
    {
        public Task<MedicoDto[]> GetDataAll();
        public Task<MedicoDto> Save(MedicoDto.Actualizar dataSave);
        public Task<MedicoDto> Update(MedicoDto.Actualizar dataUpdate);
        public Task DeleteById(int id);
    }
}
