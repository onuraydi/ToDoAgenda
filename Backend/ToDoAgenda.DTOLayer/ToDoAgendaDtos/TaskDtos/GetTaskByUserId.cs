using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAgenda.DTOLayer.ToDoAgendaDtos.TaskDtos
{
    // kullanıcının görevlerini getirme
    public class GetTaskByUserId
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        // userid
    }
}
