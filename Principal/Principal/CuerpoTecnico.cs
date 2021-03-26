using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class CuerpoTecnico : Persona
    {
        public bool EsDT { get; set; }
        public int NroAyudante { get; set; } // 0 = DT, 1 primer ayudante, etc
        public override bool ProntoRetiro()
        {
            return base.ProntoRetiro();
        }
    }
}
