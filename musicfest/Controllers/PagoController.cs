using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using musicfest.Data;
using musicfest.Models;
using Microsoft.AspNetCore.Identity;

namespace musicfest.Controllers
{
   public class PagoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public PagoController(ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Create(Decimal monto)
        {
            Pago pago = new Pago();
            pago.UserID = _userManager.GetUserName(User);
            pago.MontoTotal = monto;
            return View(pago);
        }

        [HttpPost]
        public IActionResult Pagar(Pago pago)
        {
            pago.FechaPago = DateTime.Now;
            _context.Add(pago);

            var itemsProforma = from o in _context.DataProforma select o;
            itemsProforma = itemsProforma.
                Include(p => p.Producto).
                Where(s => s.UserID.Equals(pago.UserID) && s.Estado.Equals("PENDIENTE"));

            Pedido pedido = new Pedido();
            pedido.UserID = pago.UserID;
            pedido.Total = pago.MontoTotal;
            pedido.pago = pago;
            pedido.Estado = "PENDIENTE";
            _context.Add(pedido);


            List<Detallepedido> itemsPedido = new List<Detallepedido>();
            foreach(var item in itemsProforma.ToList()){
                Detallepedido detallePedido = new Detallepedido();
                detallePedido.pedido=pedido;
                detallePedido.Precio = item.Precio;
                detallePedido.Producto = item.Producto;
                detallePedido.Cantidad = item.Cantidad;
                itemsPedido.Add(detallePedido);
            }

            _context.AddRange(itemsPedido);

            foreach (Proforma p in itemsProforma.ToList())
            {
                p.Estado="PROCESADO";
            }
            _context.UpdateRange(itemsProforma);

            _context.SaveChanges();

            ViewData["Message"] = "El pago se ha registrado";
            return View("Create");
        }

    }
}