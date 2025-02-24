using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.DtoAbstract.TaskServices;
using ToDoAgenda.DataAccess.Abstract.ForDto;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos;

namespace ToDoAgenda.Business.DtoConcrete.Managers.TaskManagers
{
    public class TaskDtoManager : ITaskDtoService
    {
        private readonly ITaskDtoDal _taskDtoDal;
        private readonly IMapper _mapper;

        public TaskDtoManager(ITaskDtoDal taskDtoDal, IMapper mapper)
        {
            _taskDtoDal = taskDtoDal;
            _mapper = mapper;
        }

        public async Task<TaskDto> Add(TaskDto taskDto)
        {
            return await _taskDtoDal.Add(taskDto);
        }

        public async Task Delete(TaskDto taskDto)
        {
            await _taskDtoDal.Delete(taskDto);
        }

        public async Task<List<TaskDto>> GetAll()
        {
            var values = await _taskDtoDal.GetAll();
            return _mapper.Map<List<TaskDto>>(values);
        }

        public async Task<TaskDto> GetById(int id)
        {
            return await _taskDtoDal.Get(x => x.taskId == id);
        }

        public async Task<TaskDto> Update(TaskDto taskDto)
        {
            return await _taskDtoDal.Update(taskDto);
        }
    }
}
