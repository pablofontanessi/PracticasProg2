using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Arbitro : Persona
    {
        public int TipoArbitro { get; set; } //1-principal, 2 linea, 3 cuarto
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
