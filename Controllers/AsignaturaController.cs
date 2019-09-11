using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_.Net.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp_.Net.Controllers
{
    public class AsignaturaController : Controller
    {

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }

        // GET: Asignatura
        public ActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault());
        }


        public ActionResult MultiAsignatura()
        {
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignaturas", _context.Asignaturas);
        }

        // GET: Asignatura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Asignatura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asignatura/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Asignatura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Asignatura/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Asignatura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Asignatura/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}