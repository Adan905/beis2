﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Jugadores
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugadores(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }

        public Jugadores(string nombre)
        {
            Nombre = nombre;
        }

        public Jugadores (string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero
        }
    }
}
