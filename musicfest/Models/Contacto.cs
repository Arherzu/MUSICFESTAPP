using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace musicfest.Models
{
   [Table("t_contactos")]
    public class Contacto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }
        
        [Column("nombrecompleto")]
        public string nombre { get; set; }
        
        
        [Column("apellido_paterno")]
        public string apellido_paterno { get; set; }

        [Column("apellido_materno")]
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

        [Column("correo")]
        public string Correo { get; set; }
        
        [Column("tecnologia")]
        public string tecnologia { get; set; }
     }
}