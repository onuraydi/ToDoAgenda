using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.DataAccess.DtoRepositories;
using ToDoAgenda.DTOLayer.ToDoAgendaDtos.TimerDtos;

namespace ToDoAgenda.DataAccess.Abstract.ForDto
{
    public interface ITimerDtoDal:IDtoRepository<TimerDto>
    {
    }
}
