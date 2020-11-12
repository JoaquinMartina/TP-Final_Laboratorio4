using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeliculas.Models;

namespace WebAppPeliculas.ViewModel
{
    public class PeliculaViewModel
    {
        public List<Pelicula> Peliculas { get; set; }
        public Paginador Paginador { get; set; } = new Paginador();
    }
}
