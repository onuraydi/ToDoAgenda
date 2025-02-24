using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.DefinedTaskDtos;

namespace ToDoAgenda.Business.DtoAbstract.DefinedTaskServices
{
    public interface IDefinedTaskDtoService
    {
        Task<List<DefinedTaskDto>> GetAll();
        Task<DefinedTaskDto> GetById();
        Task<DefinedTaskDto> Add(DefinedTaskWitoutIdDto definedTaskWitoutIdDto);
        Task<DefinedTaskDto> Update(DefinedTaskDto definedTaskDto);
        Task Delete(DefinedTaskDto definedTaskDto);
    }
}
