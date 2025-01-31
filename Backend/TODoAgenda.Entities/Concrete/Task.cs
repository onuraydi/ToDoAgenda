using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class Task:IEntity
    {
        // hedef görevler
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int TimerId { get; set; }
        public Timer Timer { get; set; }   // Göreve ait süre
        public int ImportanceLevelId { get; set; }
        public ImportanceLevel ImportanceLevel { get; set; }
        public int ResultId { get; set; }
        public Result Result { get; set; }

    }
}
