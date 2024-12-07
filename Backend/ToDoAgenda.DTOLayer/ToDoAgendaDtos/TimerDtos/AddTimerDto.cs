using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.TimerDtos
{
    public class AddTimerDto:IDto
    {
        // acaba tek bir timer olsa?
        public TimeSpan targetTime { get; set; }
        public TimeSpan CompleteTime { get; set; }
    }
}
