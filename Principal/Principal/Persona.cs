using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }

        public int ObtenerEdad()
        {
            return DateTime.Today.Year - FechaNacimiento.Year;
        }
        public string ObtenerNombreYNacionalidad()
        {
            return Nombre +" " + Nacionalidad;
        }

        public virtual bool ProntoRetiro()
        {
            return false;        
        }




    }
}
