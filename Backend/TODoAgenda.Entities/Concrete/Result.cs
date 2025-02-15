using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAgenda.Core.Entities;
using TODoAgenda.Entities.Concrete.ResultEntities;

namespace TODoAgenda.Entities.Concrete
{
    public class Result:IEntity
    {
        public int resultId { get; set; }
        public ResultType resultType { get; set; }  

    }
}
