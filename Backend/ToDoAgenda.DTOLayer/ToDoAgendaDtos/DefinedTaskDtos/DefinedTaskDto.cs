using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.DefinedTaskDtos
{
    public class DefinedTaskDto:IDto
    {
        public int DefinedTaskId { get; set; }
        public int taskId { get; set; }
        public TODoAgenda.Entities.Concrete.Task task { get; set; }
        public int resultId { get; set; }
        public Result result { get; set; }
        public int timerId { get; set; }
        public TODoAgenda.Entities.Concrete.Timer timer { get; set; }
        public int importanceLevelId { get; set; }
        public ImportanceLevel importanceLevel { get; set; }
    }
}
