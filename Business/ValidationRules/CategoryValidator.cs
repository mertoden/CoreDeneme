using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name cannot be empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category description cannot be empty");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Please enter a maximum of 50 characters.");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Please enter a minimum of 2 characters.");
        }
    }
}
