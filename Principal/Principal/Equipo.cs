using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public int Puntos { get; set; }
        public List<Jugador> ListaJugadores { get; set; }
        public List<CuerpoTecnico> ListaCuerpoTecnico { get; set; }

    }
}
