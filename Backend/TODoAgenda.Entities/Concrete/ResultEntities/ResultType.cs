using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete.ResultEntities.ResultTypes;

namespace TODoAgenda.Entities.Concrete.ResultEntities
{
    [Keyless]
    public class ResultType
    {
        public Net net { get; set; }
        public ExamTrial examTrial { get; set; }
        public TestQuestion testQuestion { get; set; }
        public Theme theme { get; set; }
        public OtherType otherType { get; set; }
    }
}
