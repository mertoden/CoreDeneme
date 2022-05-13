using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
   public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Author name and surname cannot be blank. ");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adress cannot be blank.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password cannort be blank.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please enter at least 2 characters");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Please enter a maximum of 50 characters.");
            
        }
    }
}
