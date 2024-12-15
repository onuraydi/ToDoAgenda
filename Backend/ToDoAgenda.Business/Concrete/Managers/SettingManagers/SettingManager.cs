using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.Abstract.SettingServices;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using TODoAgenda.Entities.Concrete;
using Task = System.Threading.Tasks.Task;


namespace ToDoAgenda.Business.Concrete.Managers.SettingManagers
{
    public class SettingManager : ISettingService
    {
        private ISettingDal _SettingDal;
        private IMapper _mapper;

        public SettingManager(ISettingDal settingDal, IMapper mapper)
        {
            _SettingDal = settingDal;
            _mapper = mapper;
        }

        public async Task<Setting> Add(Setting setting)
        {
            return await _SettingDal.Add(setting);
        }

        public async Task Delete(Setting setting)
        {
            await _SettingDal.Delete(setting);
        }

        public async Task<List<Setting>> GetAll()
        {
            var values = await _SettingDal.GetAll();
            return _mapper.Map<List<Setting>>(values);
        }

        public async Task<Setting> GetById(int id)
        {
            return await _SettingDal.Get(x => x.SettingId == id);
        }

        public async Task<Setting> Update(Setting setting)
        {
            return await _SettingDal.Update(setting);
        }
    }
}
