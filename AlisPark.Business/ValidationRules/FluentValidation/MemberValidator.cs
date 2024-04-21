using AlisPark.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        //fluent validation
        public MemberValidator()
        {
            RuleFor(p => p.MemberName).NotEmpty().WithMessage("Üye  ismi boş olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.Balance).NotEmpty();
            RuleFor(p => p.MemberPhone).NotEmpty();
            RuleFor(p => p.MemberSurname).NotEmpty();
            RuleFor(p => p.Balance).GreaterThanOrEqualTo(100);
        }
    }
}
