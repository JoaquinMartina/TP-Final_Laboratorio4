using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPeliculas.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Fecha de estreno")]
        public DateTime FechaEstreno { get; set; }

        [Display(Name = "Cartel de Película")]
        public string FotoCartel { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Video Trailer")]
        public string Trailer { get; set; }

        [Display(Name = "Resumen")]
        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        public string Resumen { get; set; }

        [Display(Name = "Género")]
        [Required(ErrorMessage = "Debe seleccionar al menos un género")]
        public int? GeneroId { get; set; }
        public Genero Genero { get; set; }

        [Display(Name = "En cartelera")]
        public bool Cartelera { get; set; }

        public List<PeliculaActor> PeliculasActores { get; set; }
    }
}
