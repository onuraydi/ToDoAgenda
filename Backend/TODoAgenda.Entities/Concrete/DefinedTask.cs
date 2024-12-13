using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class DefinedTask:IEntity
    {
        public int DefinedTaskId { get; set; }  // belki kaldırılabilir
        // ilişkiler ayarlandıktan sonra dönülecek
    }
}
