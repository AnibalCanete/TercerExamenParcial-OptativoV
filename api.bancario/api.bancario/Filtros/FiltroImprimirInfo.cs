using Microsoft.AspNetCore.Mvc.Filters;

namespace api.bancario.Filtros
{
    public class FiltroImprimirInfo : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Otro filtro se ha ejecutado 3");
        }

        public void OnActionExecuting(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }
    }
}
