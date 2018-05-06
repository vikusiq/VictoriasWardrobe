using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VictoriasWardrobe.Data.Entities;
using FluentValidator;
using FluentValidation;

namespace VictoriasWardrobe.FluentValidator
{
    public class TestValidator : AbstractValidator<Persons>
    {
        public TestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is Mandatory");
        }
    }
}