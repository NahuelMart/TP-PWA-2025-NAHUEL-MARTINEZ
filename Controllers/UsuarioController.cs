using Microsoft.AspNetCore.Mvc;

namespace PizzaExpress.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Selected"] = "Usuario"; // Activa el ítem "Usuario" en la navbar
            return View();
        }
    }
}
