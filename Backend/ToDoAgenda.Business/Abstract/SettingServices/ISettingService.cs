using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete;
using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.Business.Abstract.SettingServices
{
    public interface ISettingService
    {
        Task<List<Setting>> GetAll();
        Task<Setting> GetById(int id);
        Task<Setting> Add(Setting setting);
        Task<Setting> Update(Setting setting);
        Task Delete(Setting setting);

    }
}
