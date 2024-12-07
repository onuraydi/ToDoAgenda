using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos
{
    public class AddTaskDto:IDto
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
    }
}
