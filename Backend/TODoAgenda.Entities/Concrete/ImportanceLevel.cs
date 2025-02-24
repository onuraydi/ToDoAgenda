using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;

namespace TODoAgenda.Entities.Concrete
{
    public class ImportanceLevel:IEntity
    {
        public int importanceLevelId { get; set; }
        public ImportanceDegree importanceLevelDegree { get; set; }
    }
}

// burası context sınıfına farklı bir şekilde eklenebilir.
public enum ImportanceDegree
{
    one, two, three, four, five
}
