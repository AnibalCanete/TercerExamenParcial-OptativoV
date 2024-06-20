using FluentValidation;
using Repository.Entidades;

namespace api.bancario.Validaciones
{
    public class ActualizarClienteValidacion : AbstractValidator<ActualizarClienteValidacion>
    {
        public ActualizarClienteValidacion()
        {
            RuleFor(Cliente => Cliente.AnoNacimiento)
                .GreaterThan(1900)
                .WithMessage("El año de Nacimiento debe ser mayor a 1900.");

            RuleFor(Cliente => Cliente.nombre)
                .MinimumLenght(3)
                .WithMessage("La cantidad minima de caracteres es de 3");

            RuleFor(Cliente => Cliente.apellido)
                .MaximumLenght(10)
                .WithMessage("La cantidad maxima de caracteres es 10");
        }
    }
}
