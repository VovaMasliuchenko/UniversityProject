using EvenToTheMoon_EF_.BLL.DTO.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.BLL.Validation
{
    public class ReviewValidator : AbstractValidator<ReviewRequest>
    {
       public ReviewValidator()
        {
            RuleFor(r => r.Review)
                .NotEmpty().WithMessage("Review Cannot be empty!")
                .Length(3, 100).WithMessage("Length must be 3-100 symbols");
        }

    }
}
