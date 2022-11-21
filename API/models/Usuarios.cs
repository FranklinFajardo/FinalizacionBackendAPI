using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.models
{
    public class Usuarios
    {
        [Key]
        public int Identificador { get; set; }
        public string Usuario { get; set; }
        public string PassWord { get; set; }
        public DateTime Fecha_de_reacion { get; set; }
    }
}
