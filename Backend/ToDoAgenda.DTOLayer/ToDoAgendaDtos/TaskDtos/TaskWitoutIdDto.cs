using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Dtos;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos
{
    public class TaskWitoutIdDto:IDto
    {
        public string taskName { get; set; }
        public string taskDescription { get; set; }
    }
}
