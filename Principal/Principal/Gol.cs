using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Gol : Incidencias
    {
        public int NroJugador { get; set; }
        public bool EsEnContra { get; set; }
        public int Minuto { get; set; }
        public int Arco { get; set; }

        public Gol(int nroJugador, bool esEnContra, int minuto, int arco)
        {
            NroJugador = nroJugador;
            EsEnContra = esEnContra;
            Minuto = minuto;
            Arco = arco;

        }
    }
}
