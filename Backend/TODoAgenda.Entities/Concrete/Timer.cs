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
        public int TimerId { get; set; }
        public TimeSpan targetTime { get; set; }
        public TimeSpan CompleteTime { get; set; }
        //public Task Task { get; set; }
    }
}
