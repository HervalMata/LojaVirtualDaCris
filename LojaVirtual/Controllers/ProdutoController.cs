using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
            Produto produto = GetProduto();
            return View(produto);
            //return new ContentResult() { Content = "<h1>Produto -> Visualizar<h1>", ContentType = "text/html" };
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Laço",
                Descricao = "Laço Maravilhoso",
                Valor = 2000.00M
            };
        }
    }
}