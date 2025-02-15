using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Business.ValidationRules.FluentValidation
{
    public class ResultValidator:AbstractValidator<Result>
    {
        public ResultValidator() 
        {
            RuleFor(x => x.resultId).NotNull().WithMessage("Sonuçların ID değeri boş olamaz.");
            RuleFor(x => x.resultType).NotNull().NotEmpty().WithMessage("Sonuç tipi değeri boş olamaz.");
            // net sayısını otomatik hesaplayacak
        }
    }
}
