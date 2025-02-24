using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;


namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.DefinedTaskDtos
{
    public class DefinedTaskDto:IDto
    {
        public int DefinedTaskId { get; set; }
        public int taskId { get; set; }       
        public int resultId { get; set; }        
        public int timerId { get; set; }       
        public int importanceLevelId { get; set; }
    }
}
