using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(usuario => usuario.NombreUsuario)
           .NotEmpty().WithMessage("El nombre de usuario es requerido")
           .MinimumLength(3).WithMessage("El nombre de usuario debe tener al menos 3 caracteres");

            RuleFor(usuario => usuario.Apellido)
                .NotEmpty().WithMessage("El apellido es requerido")
                .MinimumLength(3).WithMessage("El apellido debe tener al menos 3 caracteres");

            RuleFor(usuario => usuario.Carnet)
                .NotEmpty().WithMessage("El carnet es requerido")
                .Matches(@"^[0-9]+$").WithMessage("El carnet solo debe contener números");

            RuleFor(usuario => usuario.Contraseña)
                .NotEmpty().WithMessage("La contraseña es requerida")
                .MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres");
        }
    }
}
