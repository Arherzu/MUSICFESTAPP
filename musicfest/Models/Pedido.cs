using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace musicfest.Models
{
    [Table("t_pedido")]
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String UserID{ get; set; }

        public Decimal Total { get; set; }

        public Pago pago { get; set; }

        public String Estado { get; set; }

    }
}