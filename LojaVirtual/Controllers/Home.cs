using System;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {
            try
            {
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];
            
                ContatoEmail.EnviarContatoPorEmail(contato);

                ViewData["MSG_S"] = "Mensagem de contato enviada com sucesso!";
            }
            catch (Exception e)
            {
                ViewData["MSG_E"] = "Ooops! Ocorreu um erro, tente novamente mais tarde!";
            }

            return View("Contato");
            //return new ContentResult() {Content = string.Format("dados recebidos com sucesso!<br/> Nome: {0} <br/> E-mail: {1} <br/> Texto: {2}", contato.Nome, contato.Email, contato.Texto), ContentType = "text/html"};
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}