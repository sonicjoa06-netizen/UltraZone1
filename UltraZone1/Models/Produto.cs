using Microsoft.AspNetCore.Mvc;

namespace UltraZone1.Models
{
    public class Produto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
