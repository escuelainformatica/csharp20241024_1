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

            // listado de clientes
            var clientes = new List<Cliente>();
            var texto = "hola";

            clientes.Add(new Cliente("John", "Doe", 22));
            clientes.Add(new Cliente("Anna", "Smith", 33));
            clientes.Add(new Cliente("Peter", "R", 22));
            clientes.Add(new Cliente("Susan", "T", 22));


            // ciclo:
            Console.WriteLine("for:");
            for(int i=0;i<clientes.Count;i++)
            {
                Console.WriteLine($"{clientes[i].Nombre} {clientes[i].Apellido} {clientes[i].Edad} ");
            }
            // ciclo for each
            Console.WriteLine("for each:");
            foreach (var cliente in clientes) // recorra todos los clientes que esta EN el listado clientes
            {
                Console.WriteLine($"{cliente.Nombre} {cliente.Apellido} {cliente.Edad} ");
            }
            Console.WriteLine("for each marcas:");
            var marcas = new List<string>() { "Samsung", "Apple", "Microsoft","Xiaomi","Huaweii" };
            foreach(var marca in marcas)
            {
                Console.WriteLine(marca);
            }



            Console.ReadKey();
        }
    }
}
