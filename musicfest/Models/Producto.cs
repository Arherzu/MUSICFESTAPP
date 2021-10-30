using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace musicfest.Models
{
    [Table("t_producto")]
    public class Producto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre {get; set;}

        [Column("descripcion")]
        public string Descripcion {get; set;}

        [Column("precio")]
        public Decimal Precio {get; set;}

        [Column("imagen")]
        public String Imagen { get; set; }

        [Column("estado")]
        public String Estado { get; set; }

    }
}