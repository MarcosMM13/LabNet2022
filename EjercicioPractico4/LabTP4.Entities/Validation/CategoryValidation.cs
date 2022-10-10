using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Entities.Validation
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("El nombre esta vacio");
            RuleFor(x => x.CategoryName).MaximumLength(15).WithMessage("Ha superado la cantidad de caracteres");
        }
    }
}
