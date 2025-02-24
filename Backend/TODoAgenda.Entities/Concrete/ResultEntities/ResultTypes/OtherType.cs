using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAgenda.Entities.Concrete.ResultEntities.ResultTypes
{
    public class OtherType
    {
        public int otherTypeId { get; set; }
        public string description { get; set; }
    }
}
