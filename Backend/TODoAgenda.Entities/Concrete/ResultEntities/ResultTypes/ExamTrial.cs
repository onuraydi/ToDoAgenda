using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAgenda.Entities.Concrete.ResultEntities.ResultTypes
{
    public class ExamTrial
    {
        public int examTrialId { get; set; }
        public Net net { get; set; }
    }
}
