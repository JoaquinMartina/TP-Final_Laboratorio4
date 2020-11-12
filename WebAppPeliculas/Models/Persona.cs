using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPeliculas.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        public string Biografia { get; set; }

        [Display(Name = "Foto Persona")]
        public string FotoCarnet { get; set; }

    }
}
