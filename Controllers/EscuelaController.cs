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
           
            ViewBag.CosaDinamica = "La monja";
            var escuela = _context.Escuelas.FirstOrDefault();

            return View(escuela);
        }

        private EscuelaContext _context;

        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }

      
    }
}