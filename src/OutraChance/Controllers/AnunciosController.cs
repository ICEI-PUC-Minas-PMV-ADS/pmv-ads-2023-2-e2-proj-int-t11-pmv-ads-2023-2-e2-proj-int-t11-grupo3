﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OutraChance.Models;
using OutraChance.Services;
using X.PagedList;



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
        // Podem ser adicionados outras strings de filtro, como filtroCor por exemplo      
        public async Task<IActionResult> Index(string filtroEstado, string filtroCidade, string filtroCor, string filtroTamanho, string filtroDep, string filtroGenero, int? pagina, int tamanhoPagina = 8, string filtro = "true")
        {


            var anunciosQuery = _context.Anuncios.OrderByDescending(x => x.Id)
                .Include(a => a.Usuario)
                .Include(a => a.CaracteristicasAnuncios)
                .AsQueryable();

            var caracteristicasQuery = _context.CaracteristicaAnuncios.Include(ca =>ca.Anuncio).AsQueryable();
            var caractetisticasAnuncios = await caracteristicasQuery.ToListAsync();
          

            var idEspecificoCor = 1;
            var idEspecificoTamanho = 2;
            var idEspecificoDep = 3;
            var idEspecificoGenero = 4;

            bool filtroStatus;
            bool filtroBooleano = bool.TryParse(filtro, out filtroStatus);



            if (!string.IsNullOrEmpty(filtro))
            {

                anunciosQuery = anunciosQuery
                .Where(a => a.Titulo.Contains(filtro) ||
                a.Descricao.Contains(filtro) ||
                a.Estado.Contains(filtro) ||
                a.Cidade.Contains(filtro) ||
                a.Id.ToString().Contains(filtro) ||
                a.CaracteristicasAnuncios.Any(ca => ca.Valor.Contains(filtro)) ||
                a.Status == filtroStatus);
            }

            if (!string.IsNullOrEmpty(filtroEstado))
            {

                anunciosQuery = anunciosQuery
                .Where(a => a.Titulo.Contains(filtroEstado) ||
                a.Descricao.Contains(filtroEstado) ||
                a.Estado.Contains(filtroEstado) ||
                a.Cidade.Contains(filtroEstado) ||
                a.Id.ToString().Contains(filtroEstado));

            }

            if (!string.IsNullOrEmpty(filtroCidade))
            {

                anunciosQuery = anunciosQuery
                .Where(a => a.Titulo.Contains(filtroCidade) ||
                a.Descricao.Contains(filtroCidade) ||
                a.Estado.Contains(filtroCidade) ||
                a.Cidade.Contains(filtroCidade) ||
                a.Id.ToString().Contains(filtroCidade));

            }

            if (!string.IsNullOrEmpty(filtroCor))
            {
                anunciosQuery = anunciosQuery
                    .Where(a => a.CaracteristicasAnuncios.Any(ca => ca.Valor == filtroCor));
            }

            if (!string.IsNullOrEmpty(filtroTamanho))
            {
                anunciosQuery = anunciosQuery
                    .Where(a => a.CaracteristicasAnuncios.Any(ca => ca.Valor == filtroTamanho));
            }

            if (!string.IsNullOrEmpty(filtroDep))
            {
                anunciosQuery = anunciosQuery
                    .Where(a => a.CaracteristicasAnuncios.Any(ca => ca.Valor == filtroDep));
            }

            if (!string.IsNullOrEmpty(filtroGenero))
            {
                anunciosQuery = anunciosQuery
                    .Where(a => a.CaracteristicasAnuncios.Any(ca => ca.Valor == filtroGenero));
            }


            var anuncios = await anunciosQuery.ToListAsync();
            caractetisticasAnuncios = await caracteristicasQuery.ToListAsync();

            var cidadesDistintas = _context.Anuncios.Select(a => a.Cidade).Distinct().ToList();
            ViewBag.filtroCidade = new SelectList(cidadesDistintas);

            var estadosDistintos = _context.Anuncios.Select(a => a.Estado).Distinct().ToList();
            ViewBag.filtroEstado = new SelectList(estadosDistintos);

            var caracteristicaCor = _context.CaracteristicaAnuncios
            .Where (ca => ca.CaracteristicaId == idEspecificoCor)
            .Select(ca => ca.Valor).Distinct().ToList();
            ViewBag.filtroCor = new SelectList(caracteristicaCor);

            var caracteristicaTamanho = _context.CaracteristicaAnuncios
            .Where(ca => ca.CaracteristicaId == idEspecificoTamanho)
            .Select(ca => ca.Valor).Distinct().ToList();
            ViewBag.filtroTamanho = new SelectList(caracteristicaTamanho);

            var caracteristicaDep = _context.CaracteristicaAnuncios
            .Where(ca => ca.CaracteristicaId == idEspecificoDep)
            .Select(ca => ca.Valor).Distinct().ToList();
            ViewBag.filtroDep = new SelectList(caracteristicaDep);

            var caracteristicaGenero = _context.CaracteristicaAnuncios
            .Where(ca => ca.CaracteristicaId == idEspecificoGenero)
            .Select(ca => ca.Valor).Distinct().ToList();
            ViewBag.filtroGenero = new SelectList(caracteristicaGenero);

            //Paginação
            var numeroPagina = pagina ?? 1;
            var anunciosPaginados = await anunciosQuery.ToPagedListAsync(numeroPagina, tamanhoPagina);
            //Paginação

            return View(anunciosPaginados);

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
        public async Task<IActionResult> CreateAsync()
        {
            var caracteristicas = await _context.Caracteristicas
                .Include(a => a.caracteristicaValores)
                .Where(a => a.Nome == "Cor" || a.Nome == "Genero")
                .ToListAsync();

            var departamentos = await _context.Caracteristicas
                .Include(a => a.caracteristicaValores)
                .Where(a => a.Nome == "Departamento")
                .ToListAsync();

            var tamanhos = await _context.Caracteristicas
               .Include(a => a.caracteristicaValores)
               .Where(a => a.Nome == "Tamanho")
               .ToListAsync();



            ViewData["Id_Usuario"] = new SelectList(_context.Usuarios, "Id", "Cpf");
            ViewData["Caracteristicas"] = caracteristicas;
            ViewData["Departamentos"] = departamentos;
            ViewData["Tamanhos"] = tamanhos;

            return View();
        }

        // POST: Anuncios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,Titulo,Descricao,Preco,Cidade,Estado,Status,Id_Usuario,ImagemUpload,CaracteristicasAnuncios")] Anuncio anuncio,
            [Bind(Prefix = "Caracteristicas")] List<CaracteristicaAnuncio> Caracteristicas
        )
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

                anuncio.Preco = anuncio.Preco / 100;

                _context.Add(anuncio);
                await _context.SaveChangesAsync();

                foreach(var caracteristicaAnuncio in Caracteristicas)
                {
                    caracteristicaAnuncio.AnuncioId = anuncio.Id;
                    _context.CaracteristicaAnuncios.Add(caracteristicaAnuncio);
                }

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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descricao,Preco,Cidade,Estado,Status,ImagemUpload,Id_Usuario")] Anuncio anuncio)
        {
            if (id != anuncio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    anuncio.Preco = anuncio.Preco / 100;

                    var arquivo = anuncio.ImagemUpload;

                    if (arquivo != null && arquivo.Length > 0)
                    {
                        UploadAzure uploadAzure = new UploadAzure(_configuration);
                        anuncio.Imagem = await uploadAzure.SalvarArquivo(arquivo);
                    }
                    else
                    {
                        // Mantenha a imagem existente
                        var anuncioExistente = await _context.Anuncios.AsNoTracking().FirstOrDefaultAsync(a => a.Id == anuncio.Id);
                        if (anuncioExistente != null)
                        {
                            anuncio.Imagem = anuncioExistente.Imagem;
                        }
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
                return RedirectToAction("Details", "Usuarios", new { id = anuncio.Id_Usuario });
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
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Anuncios == null)
            {
                return Problem("Entity set 'AppDbContext.Anuncios'  is null.");
            }
            var claimUsuarioId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var anuncio = await _context.Anuncios.FindAsync(id);
            if (anuncio != null)
            {
                _context.Anuncios.Remove(anuncio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Usuarios", new { id = claimUsuarioId });
        }

        private bool AnuncioExists(int id)
        {
          return _context.Anuncios.Any(e => e.Id == id);
        }

        [HttpPost]
        public async Task<IActionResult> MarcarComoVendido(int id)
        {
            try
            {
                var anuncio = await _context.Anuncios.FirstOrDefaultAsync(a => a.Id == id);

                if (anuncio != null)
                {
                    anuncio.Status = false;
                    await _context.SaveChangesAsync();
                    return Json(new { success = true });
                }

                return Json(new { success = false, error = "Anúncio não encontrado." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }

        public async Task<IActionResult> MarcarComoAtivo(int id)
        {
            try
            {
                var anuncio = await _context.Anuncios.FirstOrDefaultAsync(a => a.Id == id);

                if (anuncio != null)
                {
                    anuncio.Status = true;
                    await _context.SaveChangesAsync();
                    return Json(new { success = true });
                }

                return Json(new { success = false, error = "Anúncio não encontrado." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }
    }
}
