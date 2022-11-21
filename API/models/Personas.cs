using System;
using System.ComponentModel.DataAnnotations;

namespace API.models
{
    public class Personas  
    {
        [Key]
        public int Identificador { get; set; } 
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Numero_de_identificacion { get; set; }
        public string Email { get; set; }
        public string Tipo_de_identificacion { get; set; }
        public DateTime Fecha_de_reacion { get; set; }


    }
}
