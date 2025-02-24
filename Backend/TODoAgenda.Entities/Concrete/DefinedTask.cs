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
        public int taskId { get; set; }
        public Task task { get; set; }
        public int resultId { get; set; }
        public Result result { get; set; }
        public int timerId { get; set; }
        public Timer timer { get; set; }
        public int importanceLevelId { get; set; }
        public ImportanceLevel importanceLevel { get; set; }

    }
}
