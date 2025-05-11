using Microsoft.AspNetCore.Mvc;

namespace PizzaExpress.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Selected"] = "Pizza"; // Marca activo el ítem de navbar
            return View();
        }
    }
}
