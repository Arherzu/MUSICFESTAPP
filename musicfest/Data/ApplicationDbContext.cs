using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using musicfest.Models;

namespace musicfest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<musicfest.Models.Contacto> DataContactos { get; set; }
        public DbSet<musicfest.Models.Producto> DataProductos { get; set; }
        public DbSet<musicfest.Models.Proforma> DataProforma { get; set; }
        public DbSet<musicfest.Models.Pago> DataPago { get; set; }
        public DbSet<musicfest.Models.Pedido> DataPedido { get; set; }
        public DbSet<musicfest.Models.Detallepedido> DataDetallepedido { get; set; }
    }
}
