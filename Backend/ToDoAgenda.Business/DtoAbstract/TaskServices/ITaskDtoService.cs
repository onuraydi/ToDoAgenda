using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos;

namespace ToDoAgenda.Business.DtoAbstract.TaskServices
{
    public interface ITaskDtoService
    {
        Task<List<TaskDto>> GetAll();
        Task<TaskDto> GetById();
        Task<TaskDto> Add(TaskWitoutIdDto taskWitoutIdDto);
        Task<TaskDto> Update(TaskDto taskDto);
        Task Delete(TaskDto taskDto);
    }
}
