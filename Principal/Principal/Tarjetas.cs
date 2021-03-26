using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Tarjetas : Incidencias
    {
        public int NroJugador { get; set; }
        public int Minuto { get; set; }
        public int TipoTarjeta { get; set; } //1 amarilla 2 roja
        public int TarjetaAsociada { get; set; } //Siempre va a tener 2 en caso de tener valor

        public Tarjetas(int nroJugador, int minuto, int tipoTarjeta, int tarjetaAsociada)
        {
            NroJugador = nroJugador;
            Minuto = minuto;
            TipoTarjeta = tipoTarjeta;
            TarjetaAsociada = tarjetaAsociada;
        }
    }
}
