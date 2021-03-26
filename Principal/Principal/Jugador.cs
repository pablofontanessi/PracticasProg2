using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Jugador : Persona
    {
        public int Numero { get; set; }
        public bool EsTitular { get; set; }
        public int Posicion { get; set; }
        public string Equipo { get; set; }

        public override bool ProntoRetiro()
        {
            if (this.ObtenerEdad() >= 36)
            {
                return true;
            }
            else
                return false;            
        }
    }
}
