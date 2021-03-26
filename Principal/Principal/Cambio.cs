using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Cambio: Incidencias
    {
        public int NroJugadorEntra { get; set; }
        public int NroJugadorSale { get; set; }
        public int Minuto { get; set; }
    }
}
