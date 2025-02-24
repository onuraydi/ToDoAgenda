using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class Timer:IEntity
    {
        public int timerId { get; set; }
        public TimeSpan targetTime { get; set; }
        public TimeSpan completeTime { get; set; }
        public TimeSpan totalBreakTime { get; set; } = TimeSpan.Zero;    // default olarak sıfır değerini atadık
    }
}
