using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.Business.Abstract.TimerServices
{
    public interface ITimerService
    {
        Task<List<Timer>> GetAll();
        Task<Timer> GetById(int id);
        /*Task<Timer> GetTimerByTask(int id);*/   // göreve göre zaman getirme belki eklenebilir ayrıca bu tip işlemler için farklı yöntemler araştırabilirisin
        Task<Timer> Add(Timer timer);
        Task<Timer> Update(Timer timer);
        Task Delete(Timer timer);
    }
}
