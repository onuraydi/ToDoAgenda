using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAgenda.Entities.Concrete
{
    public class Timer
    {
        public int TimerId { get; set; }
        public TimeSpan targetTime { get; set; }
        public TimeSpan CompleteTime { get; set; }
    }
}
