using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> Index()
        {
            var livros = await _context.Livros.ToListAsync();  // Obtém a lista de livros
            return View(livros);  // Envia os livros para a View
        }

    }
}
