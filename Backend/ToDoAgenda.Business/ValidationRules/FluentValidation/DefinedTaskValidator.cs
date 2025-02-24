using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Business.ValidationRules.FluentValidation
{
    public class DefinedTaskValidator:AbstractValidator<DefinedTask>
    {
        public DefinedTaskValidator() 
        {
            RuleFor(dt => dt.DefinedTaskId).NotNull().WithMessage("Tanımlanan görevin mutlaka ID değeri olmalı!"); 


            // kullanılırsa diğer validationlar eklenebilir.
        }
    }
}
