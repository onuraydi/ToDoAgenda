using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Business.ValidationRules.FluentValidation
{
    public class ImportanceLevelValidator:AbstractValidator<ImportanceLevel>
    {
        public ImportanceLevelValidator() 
        {
            RuleFor(x => x.ImportanceLevelId).NotNull().WithMessage("Önem derecesi kısmının ID değeri null olamaz");
            RuleFor(x => x.ImportanceLevelDegree).InclusiveBetween(1, 5).WithMessage("Önem derecesi 1-5 arası olabilir.");
            RuleFor(x => x.ImportanceLevelDegree).NotNull().NotEmpty().WithMessage("Önem derecesi Kısmı mutlaka olmalı!");
        }
    }
}
