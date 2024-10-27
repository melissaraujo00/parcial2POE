using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(product => product.nameProducto)
                .NotEmpty().WithMessage("El nombre no puede estar vacío")
                .Length(5, 50).WithMessage("El nombre debe contener entre 10 y 50 caracteres.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre solo debe contener letras y espacios.");


            RuleFor(product => product.stock)
                .NotEmpty().WithMessage("El stock no puede estar vacío")
                .GreaterThanOrEqualTo(0).WithMessage("El stock debe ser un número positivo.")
                .Must(stock => int.TryParse(stock.ToString(), out _)).WithMessage("El stock debe ser un número entero.");

            RuleFor(product => product.price)
                .NotEmpty().WithMessage("El precio no puede estar vacío")
                .GreaterThan(0).WithMessage("El precio debe ser mayor a 0.")
                .Must(price => decimal.TryParse(price.ToString(), out _)).WithMessage("El precio debe ser un número válido.");

            RuleFor(product => product.idCategory)
                .NotEmpty().WithMessage("La categoría no puede estar vacía")
                .GreaterThan(0).WithMessage("Debe seleccionar una categoría.");

        }
    }
}
