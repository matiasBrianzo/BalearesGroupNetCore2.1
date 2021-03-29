using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApi.Models
{
    public class NegocioControl
    {
        public int id { get; set; }
        public string Negocio { get; set; }
        public string DiaDeLaSemana { get; set; }
        public string HorarioApertura { get; set; }
        public string HorarioCierre { get; set; }
    }
}
