using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos
{
    public class TaskDto:IDto
    {
        public int taskId { get; set; }
        public string taskName { get; set; }
        public string taskDescription { get; set; }
    }
}
