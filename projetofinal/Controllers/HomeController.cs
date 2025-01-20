using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetofinal.Models;

namespace projetofinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View("SearchResults", new List<string>()); // Exibe resultados vazios
            }

            // Simulando resultados
            var results = new List<string> { "Resultado 1", "Resultado 2", "Resultado 3" };
            return View("SearchResults", results);
        }
    }
}