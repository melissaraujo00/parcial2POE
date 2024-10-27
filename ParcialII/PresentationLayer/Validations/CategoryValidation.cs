using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(category => category.nameCategory)
                .NotEmpty().WithMessage("El nombre no puede estar vacío")
                .Length(1, 50).WithMessage("El nombre debe contener entre 10 y 50 caracteres.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre solo debe contener letras y espacios.");
        }
    }
}
