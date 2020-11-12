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
    public class PeliculasActoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeliculasActoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PeliculasActores
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PeliculasActores.Include(p => p.Actor).Include(p => p.Pelicula);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PeliculasActores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaActor = await _context.PeliculasActores
                .Include(p => p.Actor)
                .Include(p => p.Pelicula)
                .FirstOrDefaultAsync(m => m.PersonaId == id);
            if (peliculaActor == null)
            {
                return NotFound();
            }

            return View(peliculaActor);
        }

        // GET: PeliculasActores/Create
        public IActionResult Create()
        {
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Apellido");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Resumen");
            return View();
        }

        // POST: PeliculasActores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PeliculaId,PersonaId")] PeliculaActor peliculaActor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(peliculaActor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Apellido", peliculaActor.PersonaId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Resumen", peliculaActor.PeliculaId);
            return View(peliculaActor);
        }

        // GET: PeliculasActores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaActor = await _context.PeliculasActores.FindAsync(id);
            if (peliculaActor == null)
            {
                return NotFound();
            }
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Apellido", peliculaActor.PersonaId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Resumen", peliculaActor.PeliculaId);
            return View(peliculaActor);
        }

        // POST: PeliculasActores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PeliculaId,PersonaId")] PeliculaActor peliculaActor)
        {
            if (id != peliculaActor.PersonaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(peliculaActor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculaActorExists(peliculaActor.PersonaId))
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
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Apellido", peliculaActor.PersonaId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Resumen", peliculaActor.PeliculaId);
            return View(peliculaActor);
        }

        // GET: PeliculasActores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculaActor = await _context.PeliculasActores
                .Include(p => p.Actor)
                .Include(p => p.Pelicula)
                .FirstOrDefaultAsync(m => m.PersonaId == id);
            if (peliculaActor == null)
            {
                return NotFound();
            }

            return View(peliculaActor);
        }

        // POST: PeliculasActores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var peliculaActor = await _context.PeliculasActores.FindAsync(id);
            _context.PeliculasActores.Remove(peliculaActor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculaActorExists(int id)
        {
            return _context.PeliculasActores.Any(e => e.PersonaId == id);
        }
    }
}
