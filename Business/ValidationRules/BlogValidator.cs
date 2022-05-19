using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
   public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog title cannot be empty");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content cannot be empty");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog image cannot be empty");
            RuleFor(x => x.BlogTitle).MaximumLength(5).WithMessage("Please enter a maximum of 4 characters.");
        }
    }
}
