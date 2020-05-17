using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class Home : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult contato()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }

        public IActionResult cadastroCliente()
        {
            return View();
        }

        public IActionResult carrinhoCompras()
        {
            return View();
        }
    }
}