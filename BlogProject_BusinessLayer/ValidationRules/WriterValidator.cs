using BlogProject_EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Ad'ı alanı boş geçilemez");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadı alanı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.WriterUserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapınız");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girişi yapınız");
            RuleFor(x => x.WriterUserName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girişi yapınız");
            RuleFor(x => x.WriterUserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
        }
    }
}
