using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeliculas.Models;

namespace WebAppPeliculas.ViewModel
{
    public class PeliculaActorViewModel
    {
        public List<PeliculaActor> PeliculasActores { get; set; }
        public List<Persona> Actores { get; set; }
        public List<Pelicula> Peliculas { get; set; }
    }
}
