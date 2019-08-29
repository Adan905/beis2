using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }
        public string Entrenador { get; set; }
        public List<Jugadores> Jugador { get; set; }

        public Equipo()
        {
        Nombre= "Sin nombre";
            CiudadOrigen = "Sin Ciudad";
            Entrenador = "Sin Entrenador";
            Jugador = new List<Jugadores>();
        }

        public Equipo(string nombre);
        CiudadOrigen = "Sin ciudad";
        Entrenador = "Sin Entrenador";
        Jugador = new List<Jugadores>();


    }
}
