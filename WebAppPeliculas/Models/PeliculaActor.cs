using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPeliculas.Models
{
    public class PeliculaActor
    {
        [Display(Name = "Pelicula")]
        public int PeliculaId { get; set; }

        [Display(Name = "Película")]
        public Pelicula Pelicula { get; set; }

        [Display(Name = "Actor")]
        public int PersonaId { get; set; }

        [Display(Name = "Actor")]
        public Persona Actor { get; set; }

        [Display(Name = "Papel")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PapelActor { get; set; }
    }
}
