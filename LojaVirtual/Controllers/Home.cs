using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class Home : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}