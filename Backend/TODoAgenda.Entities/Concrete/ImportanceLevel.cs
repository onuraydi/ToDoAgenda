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
        public int ImportanceLevelId { get; set; }
        public int ImportanceLevelDegree { get; set; }  // 1, 2 ,3 ,4 ,5 default değerleri olacak fluent api ile contexte eklenebilir (veri tabanı seviyesinde bir değer olması için)
        //public Task Task { get; set; }
    }
}
