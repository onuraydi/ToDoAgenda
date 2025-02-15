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
            RuleFor(x => x.importanceLevelId).NotNull().WithMessage("Önem derecesi kısmının ID değeri null olamaz");
            RuleFor(x => x.importanceLevelDegree).NotNull().NotEmpty().WithMessage("Önem derecesi Kısmı mutlaka olmalı!");
        }
    }
}
