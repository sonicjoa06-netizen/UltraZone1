using Microsoft.AspNetCore.Mvc;

namespace UltraZone1.Repositorio
{
    public class ProdutoRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
