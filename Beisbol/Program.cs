using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = 
                new List<Equipo>();

            Equipo yaquis =
                new Equipo("Yaquis");
            yaquis.Entrenador = "Pedro";
            yaquis.CiudadOrigen = "Ciudad Obregón";

            yaquis.Jugador.Add(
                new Jugadores("Jugador 1", 5));
            yaquis.Jugador.Add(
                new Jugadores("Jugador 2", 9));
            yaquis.Jugador.Add(
                new Jugadores("Jugador 3", 32));
            yaquis.Jugador.Add(
                new Jugadores("Jugador 4", 55));
            yaquis.Jugador.Add(
                new Jugadores("Jugador 5", 21));
            yaquis.Jugador.Add(
                new Jugadores("Jugador 6", 60));
            yaquis.Jugador.Add(
                new Jugadores("Jugador 7", 44));
            yaquis.Jugador.Add(
                new Jugadores("Jugador 8", 56));

            Equipo aguilas =
                new Equipo("Equipo 2");

            equipos.Add(yaquis);
            equipos.Add(aguilas);


            foreach(Equipo equipo in equipos)
            {
                Console.WriteLine(
                    equipo.Nombre + " de " +
                    equipo.CiudadOrigen);
            }
            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("*" +
                    equipo.Nombre + " " +
                    equipo.CiudadOrigen);
            }

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("-" +
                    equipo.Nombre + " " +
                    equipo.CiudadOrigen);
            }
        }
    }
}
