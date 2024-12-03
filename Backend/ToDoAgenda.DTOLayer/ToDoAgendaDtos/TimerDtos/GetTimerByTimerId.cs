using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.TimerDtos
{
    public class GetTimerByTimerId
    {
        public int TimerId { get; set; }
        public TimeSpan targetTime { get; set; }
        public TimeSpan CompleteTime { get; set; }
    }
}
