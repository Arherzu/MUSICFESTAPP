using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace musicfest.Models
{
    [Table("t_contacto")]
    public class Contacto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("nombrecompleto")]
        public string Nombre { get; set; }
        
        
        [Column("apellido_paterno")]
        public string Ape_paterno { get; set; }

        [Column("apellido_materno")]
        public string Ape_materno { get; set; }
        
        [EmailAddress]
        [Column("correo")]
        public string Correo { get; set; }

        [Column("celular")]
        public int Celular { get; set; }
     

        [Column("direccion")]
        public string Direccion { get; set; }

        [Column("distrito")]
        public string Distrito { get; set; }
        
        [Column("nacionalidad")]
        public string Nacionalidad { get; set; }

        [Column("mensaje")]
        public string Mensaje { get; set; }
        
        
     }
}