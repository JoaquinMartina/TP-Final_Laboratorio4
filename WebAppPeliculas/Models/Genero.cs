using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPeliculas.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Género")]
        public string Descripcion { get; set; }

        public List<PeliculaGenero> PeliculasGeneros { get; set; }
    }
}
