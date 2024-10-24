using ConsoleApp9.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // los arreglos son finitos, no se puede aumentar o disminuir su tamaño.
            string[] paises = new string[3]; // un arreglo de 3 elementos.
            paises[0] = "Chile";
            paises[1] = "Argentina";
            paises[2] = "Peru";
            string[] paises2 = new string[] { "Chile", "Argentina", "Peru" };
            // Stack
            // Queue
            // Dictionary
            // HashSet = List

            // en la lista se pueden agregar o quitar elementos dinamicamente.
            // < > = platillo volador
            var paises3 = new List<string>(); // creando una lista de texto
            paises3.Add("Chile");
            paises3.Add("Argentina");
            paises3.Add("Peru");
            var paises4 = new List<string> { "Chile", "Argentina", "Peru" };
            var paises5 = new HashSet<string>();
            paises5.Add("Chile");
            paises5.Add("Argentina");
            paises5.Add("Peru");

            // listado de productos
            var productos = new List<Producto>();
            var prod1 = new Producto("cocacola", 1500);
            productos.Add(prod1);
            productos.Add(new Producto("fanta", 500));
            productos.Add(new Producto { Nombre = "sprite", Precio = 2000 });









        }
    }
}
