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

        public IActionResult contatoAcao()
        {
            string nome = HttpContext.Request.Form["nome"];
            string email = HttpContext.Request.Form["email"];
            string texto = HttpContext.Request.Form["texto"];
            return new ContentResult() {Content = string.Format("dados recebidos com sucesso!<br/> Nome: (0) <br/> E-mail: (1) <br/> Texto: (2)", nome, email, texto)};
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