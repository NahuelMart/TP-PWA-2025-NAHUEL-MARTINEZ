using Microsoft.AspNetCore.Mvc;

namespace PizzaExpress.Controllers
{
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Selected"] = "Pedidos"; // Activa el ítem "Otros pedidos" en la navbar
            return View();
        }
    }
}