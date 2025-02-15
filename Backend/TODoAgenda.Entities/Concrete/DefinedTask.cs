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
        public int DefinedTaskId { get; set; }
        public Task task { get; set; }
        public Result result { get; set; }
        public Timer timer { get; set; }
        public ImportanceLevel importanceLevel { get; set; }

    }
}
