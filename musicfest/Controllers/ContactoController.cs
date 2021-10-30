using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using musicfest.Models;
using musicfest.Data;

namespace musicfest.Controllers
{
    public class ContactoController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public ContactoController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //Descendiente Mayor a Menor
        //Ascendiente Menor a Mayor
        public IActionResult Index()
        {
                                               //Expresion   
            return View(_context.DataContactos.ToList());

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public  IActionResult Create(Contacto objContacto){

            if (ModelState.IsValid)
            {
                 objContacto.Correo = "Solicitud Registrada";

                _context.Add(objContacto);
                _context.SaveChanges();

                 return View(objContacto);   
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id == null){
                return NotFound();
            }
            var contacto = _context.DataContactos.Find(id);
            if(contacto == null){
                return NotFound();
            }
            return View(contacto);
        }

        //POST: http://localhost:5000/Contacto/Edit/ graba contacto
        [HttpPost]
        public IActionResult Edit(int id, Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                contacto.Correo = "Usuario Actualizado";
                _context.Update(contacto);
                _context.SaveChanges();
            }
            return View(contacto);
        }


        // GET: http://localhost:5000/Contacto/Delete/6 MUESTRA Contacto
        public IActionResult Delete(int? id)
        {
            var contacto = _context.DataContactos.Find(id);
            _context.DataContactos.Remove(contacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        // GET: http://localhost:5000/Contacto/Edit/6 MUESTRA Contacto
        

        //POST: http://localhost:5000/Contacto/Edit/ graba contacto
    
        

        // GET: http://localhost:5000/Contacto/Delete/6 MUESTRA Contacto
        
    }
}