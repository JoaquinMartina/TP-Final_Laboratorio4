using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPeliculas.Models
{
    public class PeliculaGenero
    {
        [Display(Name = "Película")]
        public int PeliculaId { get; set; }

        [Display(Name = "Película")]
        public Pelicula Pelicula { get; set; }

        [Display(Name = "Género")]
        public int GeneroId { get; set; }

        [Display(Name = "Género")]
        public Genero Genero { get; set; }
    }
}
