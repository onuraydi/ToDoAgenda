using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.Abstract.TaskServices;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using Task = TODoAgenda.Entities.Concrete.Task;

namespace ToDoAgenda.Business.Concrete.Managers.TaskManagers
{
    public class TaskManager : ITaskService
    {
        private ITaskDal _taskDal;
        private IMapper _mapper;

        public TaskManager(ITaskDal taskDal, IMapper mapper)
        {
            _taskDal = taskDal;
            _mapper = mapper;
        }

        public async Task<Task> Add(Task task)
        {
            TimeSpan.TryParse(task.Timer.targetTime.ToString(), out TimeSpan resultTargetTime);
            TimeSpan.TryParse(task.Timer.CompleteTime.ToString(), out TimeSpan resultCompleteTime);
            return await _taskDal.Add(task);
        }

        public async System.Threading.Tasks.Task Delete(Task task)
        {
            await _taskDal.Delete(task);
        }

        public async Task<List<Task>> GetAll()
        {
            var values = await _taskDal.GetAllWithAllDetail();   // bu metot ilişkilerin düzgün gelmesi için DataAccess katmanında yazıldı acaba kod bütünlüğünü tehlikeye atıyor mu ve daha iyi bir yolla yapmak istediğimi yapabilir miyim?
            return _mapper.Map<List<Task>>(values);
        }

        public async Task<Task> GetById(int id)
        {
            return await _taskDal.Get(x => x.TaskId == id);
        }

        public async Task<Task> GetByName(string name)
        {
            return await _taskDal.Get(x => x.TaskName == name);
        }

        public async Task<Task> Update(Task task)
        {
            return await _taskDal.Update(task);
        }
    }
}
