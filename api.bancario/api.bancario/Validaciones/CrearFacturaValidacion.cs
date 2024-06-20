namespace api.bancario.Validaciones
{
    public class CrearFacturaValidacion : AbstractValidator<CrearFacturaRequest>
    {
        public CrearFacturaValidacion()
        {
            RuleFor(Factura => Factura.total_letras)
                .MinimumLenght(6)
                .WithMessage("El minimo de caracteres es de 6");
        }
    }
}
