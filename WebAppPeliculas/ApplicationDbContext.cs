using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeliculas.Models;

namespace WebAppPeliculas
{
    //Clase que se encargara delm mapping de modelos a la BDD
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        //Para poder definir tablas con PK compartidas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PeliculaActor>().HasKey(x => new { x.PersonaId, x.PeliculaId });
            modelBuilder.Entity<PeliculaGenero>().HasKey(x => new { x.PeliculaId, x.GeneroId });
        }

        //Tablas en plural - Modelos en singular
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<PeliculaActor> PeliculasActores { get; set; }
        public DbSet<PeliculaGenero> PeliculasGeneros { get; set; }
    }
}
