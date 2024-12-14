using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Business.Abstract.TimerServices;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.Business.Concrete.Managers.TimerManagers
{
    public class TimerManager : ITimerService
    {
        private ITimerDal _timerDal;
        private IMapper _mapper;

        public TimerManager(ITimerDal timerDal, IMapper mapper)
        {
            _timerDal = timerDal;
            _mapper = mapper;
        }

        public async Task<Timer> Add(Timer timer)
        {
            return await _timerDal.Add(timer);
        }

        public async Task Delete(Timer timer)
        {
            await _timerDal.Delete(timer);
        }

        public async Task<List<Timer>> GetAll()
        {
            var values = await _timerDal.GetAll();
            return _mapper.Map<List<Timer>>(values);
        }

        public async Task<Timer> GetById(int id)
        {
            return await _timerDal.Get(x => x.TimerId == id);
        }

        public async Task<Timer> Update(Timer timer)
        {
            return await _timerDal.Update(timer);
        }
    }
}
