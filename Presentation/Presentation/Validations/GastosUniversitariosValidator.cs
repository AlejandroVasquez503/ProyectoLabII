using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class GastosUniversitariosValidator : AbstractValidator<GastosUniversitarios>
    {
        public GastosUniversitariosValidator()
        {
            RuleFor(gasto => gasto.Fecha)
            .NotEmpty().WithMessage("La fecha es requerida");

            RuleFor(gasto => gasto.Monto)
                .NotEmpty().WithMessage("El monto es requerido")
                .GreaterThan(0).WithMessage("El monto debe ser mayor a 0");

            RuleFor(gasto => gasto.Descripcion)
                .NotEmpty().WithMessage("La descripción es requerida")
                .MaximumLength(255).WithMessage("La descripción no puede exceder 255 caracteres");
        }
    }
}
