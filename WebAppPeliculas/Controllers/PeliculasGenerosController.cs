using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppPeliculas;
using WebAppPeliculas.Models;

namespace WebAppPeliculas.Controllers
{
    public class PeliculasGenerosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeliculasGenerosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PeliculaGeneroes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PeliculasGeneros.Include(p => p.Genero).Include(p => p.Pelicula);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PeliculaGeneroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaGenero = await _context.PeliculasGeneros
                .Include(p => p.Genero)
                .Include(p => p.Pelicula)
                .FirstOrDefaultAsync(m => m.PeliculaId == id);
            if (peliculaGenero == null)
            {
                return NotFound();
            }

            return View(peliculaGenero);
        }

        // GET: PeliculaGeneroes/Create
        public IActionResult Create()
        {
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo");
            return View();
        }

        // POST: PeliculaGeneroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PeliculaId,GeneroId")] PeliculaGenero peliculaGenero)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(peliculaGenero);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Generos");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "La película ya contiene el género elegido!");
                }

            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", peliculaGenero.GeneroId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaGenero.PeliculaId);
            return View(peliculaGenero);
        }

        // GET: PeliculaGeneroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaGenero = await _context.PeliculasGeneros.FindAsync(id);
            if (peliculaGenero == null)
            {
                return NotFound();
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", peliculaGenero.GeneroId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Resumen", peliculaGenero.PeliculaId);
            return View(peliculaGenero);
        }

        // POST: PeliculaGeneroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PeliculaId,GeneroId")] PeliculaGenero peliculaGenero)
        {
            if (id != peliculaGenero.PeliculaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(peliculaGenero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculaGeneroExists(peliculaGenero.PeliculaId))
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
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion", peliculaGenero.GeneroId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Resumen", peliculaGenero.PeliculaId);
            return View(peliculaGenero);
        }

        // GET: PeliculaGeneroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaGenero = await _context.PeliculasGeneros
                .Include(p => p.Genero)
                .Include(p => p.Pelicula)
                .FirstOrDefaultAsync(m => m.PeliculaId == id);
            if (peliculaGenero == null)
            {
                return NotFound();
            }

            return View(peliculaGenero);
        }

        // POST: PeliculaGeneroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var peliculaGenero = await _context.PeliculasGeneros.FindAsync(id);
            _context.PeliculasGeneros.Remove(peliculaGenero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculaGeneroExists(int id)
        {
            return _context.PeliculasGeneros.Any(e => e.PeliculaId == id);
        }
    }
}
