using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.NAMESURNAME).NotEmpty().WithMessage("isim soyisim boş olamaz.");
            RuleFor(p => p.GENDER).NotEmpty();
            RuleFor(p => p.CITY).NotEmpty();
            RuleFor(p => p.TELNR).NotEmpty();
            RuleFor(p => p.TOWN).NotEmpty();
            RuleFor(p => p.BIRTHDATE).NotEmpty();
        }
    }
}
