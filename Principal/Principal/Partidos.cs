using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Partidos
    {
        public List<Arbitro> ListaArbitros { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaPartido { get; set; }
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public Gol GolLocal { get; set; }
        public Gol GolVisitante { get; set; }
        public int Minutos { get; set; }
        public List<Cambio> ListaCambios { get; set; }
        public List<Tarjetas> TarjetasAmarillas { get; set; }
        public List<Tarjetas> TarjetasRojas { get; set; }
        public List<Incidencias> ListaIncidencias { get; set; }

        public Partidos(List<Arbitro> ArbitrosDesignados, Equipo Equipo1, Equipo Equipo2, string CiudadElegida)
        {
            ListaArbitros = ArbitrosDesignados;
            EquipoLocal = Equipo1;
            EquipoVisitante = Equipo2;
            Ciudad = CiudadElegida;
        }

        public void CargarIncidencia(Incidencias incidencia)
        {
            ListaIncidencias.Add(incidencia);
            if (incidencia is Gol)
            {
                var obj = incidencia as Gol;
                string NombreEquipo = BuscarEquipoPorJugador(obj.NroJugador);
                if (EquipoLocal.Nombre == NombreEquipo)
                {
                    if (obj.EsEnContra == true)
                    {
                        GolVisitante = obj;
                    }
                    else
                    {
                        GolLocal = obj;
                    }
                }
            }
            else
            {
                if (incidencia is Cambio)
                {
                    var obj = incidencia as Cambio;
                    ListaCambios.Add(obj);
                }
                else
                {
                    var obj = incidencia as Tarjetas;
                    int cont = 0;
                    if (obj.TipoTarjeta == 1)
                    {
                        foreach (var tarjeta in TarjetasAmarillas)
                        {
                            if (obj.NroJugador == tarjeta.NroJugador)
                            {
                                cont += 1;

                            }
                        }
                        switch (cont)
                        {
                            case 0:
                                TarjetasAmarillas.Add(obj);
                                break;
                            case 1:
                                TarjetasAmarillas.Add(obj);
                                TarjetasRojas.Add(obj);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        TarjetasRojas.Add(obj);  
                    }
                        
                }
            }
        }

        public string BuscarEquipoPorJugador(int NroJugodor)
        {
            foreach (var jugador in EquipoLocal.ListaJugadores)
            {
                if (jugador.Numero == NroJugodor)
                {
                    return EquipoLocal.Nombre;
                }

            }
            return EquipoVisitante.Nombre;
        }

        public List<String> InformeIncidencias()
        {
            List<String> DescripcionIncidencias = new List<string>();
            foreach (var incidencia in ListaIncidencias)
            {
                if (incidencia is Gol)
                {
                    var gol = incidencia as Gol;
                    string NroJugador = gol.NroJugador.ToString();
                    string minuto = gol.Minuto.ToString();
                    string equipo = BuscarEquipoPorJugador(gol.NroJugador);

                }
            }
            
        }
    }
}
