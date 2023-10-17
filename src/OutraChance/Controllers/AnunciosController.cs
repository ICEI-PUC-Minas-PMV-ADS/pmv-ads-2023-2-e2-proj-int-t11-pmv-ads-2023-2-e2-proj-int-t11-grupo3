using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OutraChance.Models;

namespace OutraChance.Controllers
{
    public class AnunciosController : Controller
    {
        private readonly AppDbContext _context;

        public AnunciosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Anuncios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Anuncios == null)
            {
                return NotFound();
            }

            var anuncio = await _context.Anuncios
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (anuncio == null || anuncio.Status != "Ativo")
            {
                return NotFound();
            }

            return View(anuncio);
        }

        private bool AnuncioExists(int id)
        {
          return _context.Anuncios.Any(e => e.Id == id);
        }
    }
}
