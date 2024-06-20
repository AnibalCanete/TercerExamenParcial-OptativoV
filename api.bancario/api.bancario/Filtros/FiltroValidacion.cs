using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace api.bancario.Filtros
{
    public class FiltroValidacion : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("He pasado por aqui 1");

            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("He pasado por aqui 2");
        }
    }
}
