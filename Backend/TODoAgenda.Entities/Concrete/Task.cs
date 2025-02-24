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
        public int taskId { get; set; }
        public string taskName { get; set; }
        public string taskDescription { get; set; }
    }
}
