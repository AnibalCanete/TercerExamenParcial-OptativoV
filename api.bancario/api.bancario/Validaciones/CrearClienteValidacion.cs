using FluentValidation;

namespace api.bancario.Validaciones
{
    public class CrearClienteValidacion : AbstractValidator<CrearClienteRequest>
    {
        public CrearClienteValidacion()
        {
            RuleFor(Cliente => Cliente.AnoNacimiento)
                .GreaterThan(1900)
                .WithMessage("El año de nacimiento minimo es 1900");
        }
    }
}
