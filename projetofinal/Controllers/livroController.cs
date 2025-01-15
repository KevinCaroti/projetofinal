using Microsoft.AspNetCore.Mvc;
using projetofinal.Data;
using projetofinal.Models;
using System.Linq;
namespace projetofinal.Controllers
{
    public class livroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public livroController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var livros = _context.Livros.ToList(); // Obtem dados da tabela Livros
            return View();
        }
    }
}
