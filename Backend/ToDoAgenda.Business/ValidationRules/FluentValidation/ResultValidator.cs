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
            RuleFor(x => x.ResultId).NotNull().WithMessage("Sonuçların ID değeri boş olamaz.");
            RuleFor(x => x.ResultType).NotNull().NotEmpty().WithMessage("Sonuç tipi değeri boş olamaz.");
            RuleFor(x => x.ResultType).Length(3, 30).WithMessage("Sonuç tipi minimum 3, maksimum 30 karakter olabilir.");
            RuleFor(x => x.TrueCount).NotNull().NotEmpty().WithMessage("Doğru sayısı boş bırakılamaz.");
            RuleFor(x => x.TrueCount).GreaterThanOrEqualTo(0).WithMessage("Doğru sayısı 0'a eşit ya da büyük olmalı.");
            RuleFor(x => x.FalseCount).NotNull().NotEmpty().WithMessage("Yanlış sayısı boş bırakılamaz");
            RuleFor(x => x.FalseCount).GreaterThanOrEqualTo(0).WithMessage("YAnlış sayısı 0'a eşit ya da büyük olmalı.");
            // net sayısını otomatik hesaplayacak
        }
    }
}
