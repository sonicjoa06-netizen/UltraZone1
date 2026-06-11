using Microsoft.AspNetCore.Mvc;

namespace UltraZone1.Repositorio
{
    public class IProdutoRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
