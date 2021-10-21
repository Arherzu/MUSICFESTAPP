using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicfest.Models
{
   [Table("Contacto")]
    public class Contacto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        
        [Column("nombrecompleto")]
        public string nombre { get; set; }
        [Column("nombrecompleto")]
        public string nombre { get; set; }
        
        [Column("apellido paterno")]
        public string apellido_paterno { get; set; }

        [Column("apellido materno")]
        public string apellido_materno { get; set; }

        [EmailAddress]
        [Column("celular")]
        public int celular { get; set; }
     

        [Column("direccion")]
        public string direccion { get; set; }

        [Column("distrito")]
        public string distrito { get; set; }
        
        [Column("nacionalidad")]
        public string nacionalidad { get; set; }

     }
}