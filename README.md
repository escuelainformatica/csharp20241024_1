# csharp20241024_1

## Arreglos

Un arreglo es un listado de datos finitos y que no se puede modificar datos

Se define de la siguiente manera:

```csharp
string[] paises = new string[3];
var paises = new string[3];
```

Donde **string** es el tipo de datos, y puede ser otro tipo de datos o clase de modelo.

Y el numero 3 indica la cantidad máxima de elementos.

Para usarlo, se hace asi

```c#
paises[0]="Chile"; // asigna un valor
Console.WriteLine(paises[0]); 
```

## Listado

Un listado puede contener una cantidad variables de elementos

Para definir un listado, se hace así:

```c#
List<string> paises=new List<String>();
var paises=new List<String>();
```

* Donde **string** puede ser un tipo de dato o una clase

Para ocupar un elemento de un listado, se hace así:

```c#
paises.Add("Chile"); // agregar
Console.WriteLine(paises[0]); // Chile
paises[0]="Argentina";
```

## Otros tipos de datos

* HashSet (son muy similares a las listas)
* Dictionary
* Stack
* Queue

## Ejemplo normal

```c#
// Supongamos el siguiente modelo Producto
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
// crear una lista de productos
var productos=new List<Producto>();
// agregar datos
var prod1 = new Producto("cocacola", 1500);
productos.Add(prod1); // agregue prod1 a la lista de productos
productos.Add(new Producto("fanta", 500));
productos.Add(new Producto { Nombre = "sprite", Precio = 2000 });

```

| Nombre (string) | Precio (int) |
| --------------- | ------------ |
| cocacola        | 1500         |
| fanta           | 500          |
| sprite          | 2000         |

### Ejemplo

Supongamos los siguientes datos:

| Nombre | Apellido | Edad |
| ------ | -------- | ---- |
| John   | Doe      | 22   |
| Anna   | Smith    | 33   |

* Crear clase de modelo

```c#
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
```

* Crear variable de lista

```c#
// listado de clientes
var clientes = new List<Cliente>();
```

* Agregar datos a la lista

```c#
clientes.Add(new Cliente("John", "Doe", 22));
clientes.Add(new Cliente("Anna", "Smith", 33));
```

# Ejercicio 1

En un proyecto nuevo

Genere un modelo llamado **Pelicula**, una variable de lista de **Pelicula** y agregue datos para tener los siguientes datos:

| id   | titulo           | precio | duracion | censura |
| ---- | ---------------- | ------ | -------- | ------- |
| 1    | ACADEMY DINOSAUR | 0,99   | 86       | PG      |
| 10   | ALADDIN CALENDAR | 4,99   | 63       | NC-17   |

# Ejercicio 2

Repita lo mismo con estos datos (modelo Actor)

| actor_id | first_name | last_name |
| -------- | ---------- | --------- |
| 1        | PENELOPE   | GUINESS   |
| 10       | CHRISTIAN  | GABLE     |