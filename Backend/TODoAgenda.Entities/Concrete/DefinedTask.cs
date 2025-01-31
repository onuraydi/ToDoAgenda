using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class DefinedTask:IEntity
    {
        // bu kısım muhtemelen kalkacak
        public int DefinedTaskId { get; set; }
        public string DefinedTaskName { get; set; }

    }
}
