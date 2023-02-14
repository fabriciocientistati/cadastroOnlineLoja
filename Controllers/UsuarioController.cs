using Microsoft.AspNetCore.Mvc;

namespace CadastroPrimoMoveis.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
