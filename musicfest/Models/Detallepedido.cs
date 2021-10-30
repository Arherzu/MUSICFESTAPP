using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace musicfest.Models
{
    
    [Table("t_detalle_pedido")]
    public class Detallepedido
    {    
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public Producto Producto {get; set;}

        public int Cantidad{get; set;}
        public Decimal Precio { get; set; }
        public Pedido pedido {get; set;}

        
    }
}