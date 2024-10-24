using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.modelos
{
    internal class Producto
    {
        public string Nombre { set; get; }
        public int Precio { set; get; }

        public Producto(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public Producto()
        {
        }
    }
}
