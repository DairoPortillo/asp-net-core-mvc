using asp_net_core_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_mvc.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index(){
            var escuela = new Escuela();
            escuela.AñoFundación = 2005;
            escuela.EscuelaId = System.Guid.NewGuid().ToString();
            escuela.Nombre = "Dap School";

            return View(escuela);
        }
    }
}