using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeliculas.Models;

namespace WebAppPeliculas.ViewModel
{
    public class PersonaViewModel
    {
        public List<Persona> Personas { get; set; }
        public Paginador Paginador { get; set; } = new Paginador();
    }
}
