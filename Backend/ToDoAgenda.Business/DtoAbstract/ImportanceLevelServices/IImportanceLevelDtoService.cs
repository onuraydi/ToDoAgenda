using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos;

namespace ToDoAgenda.Business.DtoAbstract.ImportanceLevelServices
{
    public interface IImportanceLevelDtoService
    {
        Task<List<ImportanceLevelDto>> GetAll();
        Task<ImportanceLevelDto> GetById();
        Task<ImportanceLevelDto> Add(ImportanceLevelWithoutIdDto importanceLevelWithoutIdDto);
        Task<ImportanceLevelDto> Update(ImportanceLevelDto importanceLevelDto);
        Task Delete(ImportanceLevelDto importanceLevelDto);
    }
}
