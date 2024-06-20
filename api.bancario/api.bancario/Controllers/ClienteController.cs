using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Logica;

namespace api.bancario.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService clienteService;

        public ClienteController(IConfiguration configuration)
        {
            clienteService = new ClienteService(configuration.GetConnectionString("postgres"));
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPut]
        public ActionResult Actualizar([FromBody] ActualizarPersonaRequest request)
        {
            if(request.AnoNaciemiento < 1900)
            {
                throw new Exception("El Año de Nacimiento debe ser mayor a 1900");
            }

            if(request.Nombre.Lenght > 3)
            {
                throw new Exception("El nombre debe tener al menos 3 caracteres");
            }

            if(request.apellido.Lenght > 3)
            {
                throw new Exception("El apellido debe tener al menos 3 caracteres como minimo");
            }

            var resultado = ClienteService2.Actualizar(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public ActionResult Eliminar([FromRoute] int id)
        {
            var resultado = ClienteService2.Eliminar(id);
            return Ok(resultado);
        }
    }
}
