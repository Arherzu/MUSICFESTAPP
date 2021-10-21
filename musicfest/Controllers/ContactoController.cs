using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var listContactos=_context.Contactos.OrderBy(s => s.ID).ToList();
            return View("List",listContactos);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public  IActionResult Create(Contacto objContacto){

            if (ModelState.IsValid)
            {
                 objContacto.Mensaje = "Solicitud Registrada";

                _context.Add(objContacto);
                _context.SaveChanges();

                 return View(objContacto);   
            }
            return View();
        }

        // GET: http://localhost:5000/Contacto/Edit/6 MUESTRA Contacto
        

        //POST: http://localhost:5000/Contacto/Edit/ graba contacto
    
        

        // GET: http://localhost:5000/Contacto/Delete/6 MUESTRA Contacto
        
    }
}