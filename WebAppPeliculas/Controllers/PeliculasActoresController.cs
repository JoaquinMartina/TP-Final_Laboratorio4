using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppPeliculas;
using WebAppPeliculas.Models;
using WebAppPeliculas.ViewModel;

namespace WebAppPeliculas.Controllers
{
    public class PeliculasActoresController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _env;

        public PeliculasActoresController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: PeliculasActores
        public async Task<IActionResult> Index(int pagina=1)
        {
            var applicationDbContext = _context.PeliculasActores
                            .Include(p => p.Actor)
                            .Include(p => p.Pelicula);

            //Paginado
            int RegistrosPorPagina = 20;

            var registrosMostrar = applicationDbContext
                        .Skip((pagina - 1) * RegistrosPorPagina)
                        .Take(RegistrosPorPagina);

            //Crear modelo para la vista
            PeliculaActorViewModel peliculaActorViewModel = new PeliculaActorViewModel()
            {
                PeliculasActores = await registrosMostrar.ToListAsync(),
            };

            return View(peliculaActorViewModel);
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

            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Nombre");
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Apellido");
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "FotoCarnet");

            return View(peliculaActor);
        }

        // GET: PeliculasActores/Create
        public IActionResult Create()
        {
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Apellido");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo");
            return View();
        }

        // POST: PeliculasActores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PeliculaId,PersonaId,PapelActor")] PeliculaActor peliculaActor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(peliculaActor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "La película ya contiene el actor elegido!");
                }
            }
            ViewData["PersonaId"] = new SelectList(_context.Personas, "Id", "Apellido", peliculaActor.PersonaId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", peliculaActor.PeliculaId);
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
