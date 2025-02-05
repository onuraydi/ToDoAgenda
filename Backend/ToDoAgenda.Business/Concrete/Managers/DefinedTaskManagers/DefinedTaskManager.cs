using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoAgenda.Business.Abstract.DefinedTaskServices;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using TODoAgenda.Entities.Concrete;
using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.Business.Concrete.Managers.DefinedTaskManagers
{
    public class DefinedTaskManager : IDefinedTaskService
    {
        private IDefinedTaskDal _definedTaskDal;
        private IMapper _mapper;

        public DefinedTaskManager(IDefinedTaskDal definedTaskDal, IMapper mapper)
        {
            _definedTaskDal = definedTaskDal;
            _mapper = mapper;
        }
        public async Task<DefinedTask> Add(DefinedTask definedTask)
        {
            return await _definedTaskDal.Add(definedTask);
        }

        public async Task Delete(DefinedTask definedTask)
        {
            await _definedTaskDal.Delete(definedTask);
        }

        public async Task<List<DefinedTask>> GetAll()
        {
            var values = await _definedTaskDal.GetAll();
            return _mapper.Map<List<DefinedTask>>(values);
        }

        public async Task<DefinedTask> GetById(int id)
        {
            return await _definedTaskDal.Get(x => x.DefinedTaskId == id);
        }

        public async Task<DefinedTask> Update(DefinedTask definedTask)
        {
            return await _definedTaskDal.Update(definedTask);
        }
    }
}
