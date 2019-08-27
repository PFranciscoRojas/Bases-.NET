using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_.Net.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp_.Net.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2010;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Francis";
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Pasto";
            escuela.Dirección = "Obrero";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            ViewBag.CosaDinamica = "La monja";

            return View(escuela);
        }

      
    }
}