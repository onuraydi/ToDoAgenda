using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TODoAgenda.Entities.Concrete;
using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.Business.Abstract.DefinedTaskServices
{
    public interface IDefinedTaskService
    {
        Task<List<DefinedTask>> GetAll();
        Task<DefinedTask> GetById(int id);
        Task<DefinedTask> Add(DefinedTask definedTask);
        Task<DefinedTask> Update(DefinedTask definedTask);
        Task Delete(DefinedTask definedTask);
    }
}
