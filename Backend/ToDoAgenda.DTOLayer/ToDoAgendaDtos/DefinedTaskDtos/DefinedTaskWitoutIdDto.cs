using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.DefinedTaskDtos
{
    public class DefinedTaskWitoutIdDto:IDto
    {
        public int taskId { get; set; }
        public int resultId { get; set; }
        public int timerId { get; set; }
        public int importanceLevelId { get; set; }
    }
}
