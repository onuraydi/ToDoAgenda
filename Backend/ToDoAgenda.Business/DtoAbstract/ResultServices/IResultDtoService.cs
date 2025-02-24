using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.ImportanceLevelDtos;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.ResultDtos;

namespace ToDoAgenda.Business.DtoAbstract.ResultServices
{
    public interface IResultDtoService
    {
        Task<List<ResultDto>> GetAll();
        Task<ResultDto> GetById(int id);
        Task<ResultDto> Add(ResultDto resultDto);
        Task<ResultDto> Update(ResultDto resultDto);
        Task Delete(ResultDto resultDto);
    }
}
