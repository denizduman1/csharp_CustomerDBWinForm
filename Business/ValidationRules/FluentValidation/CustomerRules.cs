using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerRules : AbstractValidator<Customer>
    {
        public CustomerRules()
        {
            RuleFor(p => p.NAMESURNAME).NotEmpty();
            RuleFor(p => p.GENDER).NotEmpty();
            RuleFor(p => p.TELNR).NotEmpty();
            RuleFor(p => p.TOWN).NotEmpty();
            RuleFor(p => p.BIRTHDATE).NotEmpty();
            RuleFor(p => p.CITY).NotEmpty();

            RuleFor(p => p.NAMESURNAME).Must(startsWithD).WithMessage("İsim d ile başlamalı");
        }

        private bool startsWithD(string arg)
        {
            return arg.StartsWith("D");
        }
    }
}
