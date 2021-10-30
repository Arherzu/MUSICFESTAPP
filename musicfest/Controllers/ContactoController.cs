using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using musicfest.Models;
using musicfest.Data;


namespace musicfest.Controllers
{
    public class ContactoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.DataContactos.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto se ha registrado correctamente";
            //return RedirectToAction(nameof(Index));
            return View();
        }

        
        public IActionResult Editar(int id)
        {
            Contacto objContacto = _context.DataContactos.Find(id);
            if(objContacto == null){
                return NotFound();
            }
            return View(objContacto);
        }

        [HttpPost]
        public IActionResult Editar(int id,[Bind("Id,Nombre,Ape_paterno,Ape_materno,Correo,Celular,Direccion,Distrito,Nacionalidad,Mensaje")] Contacto objContacto)
        {
             _context.Update(objContacto);
             _context.SaveChanges();
              ViewData["Message"] = "El contacto se ha actualizado con éxito";
             return View(objContacto);
        }

        public IActionResult Delete(int id)
        {
            Contacto objContacto = _context.DataContactos.Find(id);
            _context.DataContactos.Remove(objContacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}