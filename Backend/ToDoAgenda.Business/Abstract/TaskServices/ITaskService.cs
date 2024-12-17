using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = TODoAgenda.Entities.Concrete.Task;

namespace ToDoAgenda.Business.Abstract.TaskServices
{
    public interface ITaskService
    {
        Task<List<Task>> GetAll();
        Task<Task> GetById(int id);
        //Task<Task> GetByName(string name);
        Task<Task> Add(Task task);
        Task<Task> Update(Task task);
        System.Threading.Tasks.Task Delete(Task task);
    }
}
