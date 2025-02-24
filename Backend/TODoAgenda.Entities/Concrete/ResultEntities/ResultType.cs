using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete.ResultEntities.ResultTypes;

namespace TODoAgenda.Entities.Concrete.ResultEntities
{
    public class ResultType
    {
        public int resultTypeId { get; set; }
        [ForeignKey("netId")]
        public Net net { get; set; }
        [ForeignKey("examTrialId")]
        public ExamTrial examTrial { get; set; }
        [ForeignKey("testQuestionId")]
        public TestQuestion testQuestion { get; set; }
        [ForeignKey("themeId")]
        public Theme theme { get; set; }
        [ForeignKey("otherTypeId")]
        public OtherType otherType { get; set; }
        public IEnumerable<Result> results { get; set; }
    }
}
