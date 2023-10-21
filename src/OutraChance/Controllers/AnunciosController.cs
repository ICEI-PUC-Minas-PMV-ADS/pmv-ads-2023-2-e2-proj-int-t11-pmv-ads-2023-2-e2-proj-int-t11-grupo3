using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OutraChance.Models;
using OutraChance.Services;

namespace OutraChance.Controllers
{
    public class AnunciosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AnunciosController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: Anuncios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Anuncios.Include(a => a.Usuario);
            return View(await appDbContext.ToListAsync());
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
                .Include(a => a.CaracteristicasAnuncios)
                    .ThenInclude(ca => ca.Caracteristica)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (anuncio == null)
            {
                return NotFound();
            }

            return View(anuncio);
        }

        // GET: Anuncios/Create
        public IActionResult Create()
        {
            ViewData["Id_Usuario"] = new SelectList(_context.Usuarios, "Id", "Cpf");
            return View();
        }

        // POST: Anuncios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Descricao,Preco,Cidade,Estado,Status,Id_Usuario,ImagemUpload")] Anuncio anuncio)
        {

            var claimUsuarioId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            anuncio.Id_Usuario = Convert.ToInt32(claimUsuarioId);

            if (ModelState.IsValid)
            {
                var arquivo = anuncio.ImagemUpload;

                if (arquivo != null && arquivo.Length > 0)
                {
                    UploadAzure uploadAzure = new UploadAzure(_configuration);
                    anuncio.Imagem = await uploadAzure.SalvarArquivo(arquivo);
                }

                _context.Add(anuncio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Usuario"] = new SelectList(_context.Usuarios, "Id", "Cpf", anuncio.Id_Usuario);
            return View(anuncio);
        }

        // GET: Anuncios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Anuncios == null)
            {
                return NotFound();
            }

            var anuncio = await _context.Anuncios.FindAsync(id);
            if (anuncio == null)
            {
                return NotFound();
            }
            ViewData["Id_Usuario"] = new SelectList(_context.Usuarios, "Id", "Cpf", anuncio.Id_Usuario);
            return View(anuncio);
        }

        // POST: Anuncios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descricao,Preco,Cidade,Estado,Status,Imagem,Id_Usuario")] Anuncio anuncio)
        {
            if (id != anuncio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var arquivo = anuncio.ImagemUpload;

                    if (arquivo != null && arquivo.Length > 0)
                    {
                        UploadAzure uploadAzure = new UploadAzure(_configuration);
                        anuncio.Imagem = await uploadAzure.SalvarArquivo(arquivo);
                    }

                    _context.Update(anuncio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnuncioExists(anuncio.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Usuario"] = new SelectList(_context.Usuarios, "Id", "Cpf", anuncio.Id_Usuario);
            return View(anuncio);
        }

        // GET: Anuncios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Anuncios == null)
            {
                return NotFound();
            }

            var anuncio = await _context.Anuncios
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (anuncio == null)
            {
                return NotFound();
            }

            return View(anuncio);
        }

        // POST: Anuncios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Anuncios == null)
            {
                return Problem("Entity set 'AppDbContext.Anuncios'  is null.");
            }
            var anuncio = await _context.Anuncios.FindAsync(id);
            if (anuncio != null)
            {
                _context.Anuncios.Remove(anuncio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnuncioExists(int id)
        {
          return _context.Anuncios.Any(e => e.Id == id);
        }
    }
}
