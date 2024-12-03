using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class ImportanceLevel:IEntity
    {
        public int ImpotanceLevelId { get; set; }
        public int ImportanceLevelDegree { get; set; }  // 1, 2 ,3 ,4 ,5 defauylt değerleri olacak 
    }
}
