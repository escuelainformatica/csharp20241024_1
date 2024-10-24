using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.modelos
{
    internal class Cliente
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Edad { set; get; }

        public Cliente(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public Cliente()
        {
        }
    }
}
