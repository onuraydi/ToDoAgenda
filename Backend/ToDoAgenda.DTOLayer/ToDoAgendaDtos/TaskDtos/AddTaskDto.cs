using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos
{
    public class AddTaskDto
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
    }
}
