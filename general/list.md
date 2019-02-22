# Clase List

List es una Clase que representa a una colección de un tipo de dato concreto. Es dinámica, por lo que se adaptará a medida que la vayas llenando o quizás eliminando su contenido.

En esta Clase conoceremos la convencion `T`, ya sea entre `<>` o no, que será bastante común en la documentación de C#. Se refiere a un tipo de dato, al tipo de dato con el que es construido y que vivirá en toda la instancia.

## Constructores

Tiene tres constructores, dos de ellos más utilizados. El primero, vacío, y el segundo que toma un número entero para especificar una capacidad inicial en la instancia.

Una lista de números sin capacidad personalizada elegida:

```cs
List<int> listaNumeros = new List<int>();
```

Una lista de cadenas de texto, con capacidad inicial para 10 elementos:

```cs
List<string> listaNombres = new List<string>(10);
```

## Propiedades

* Count, que indica el número de elementos que contiene actualmente la lista.
* Capacity, número de elementos que caben en la instancia antes de cambiar de tamaño.

## Métodos

La lista de los métodos más frecuentes en el uso de la Clase List:

* `Add(T)`, añade al final de la lista el elemento especificado como parámetro.
* `Clear()`, limpia la lista, eliminando todos los elementos.
* `Contains(T)`, devuelve el índice, la posición, de la primera ocurrencia del elemento a buscar, que se especifica en el parámetro.
* `IndexOf(T)`, devuelve el índice, la posición, de la primera ocurrencia del elemento a buscar, que se especifica en el parámetro.
* `LastIndexOf(T)`, devuelve el índice, la posición, de la última ocurrencia del elemento a buscar, que se especifica en el parámetro.
* `Remove(T)`, elimina la primera ocurrencia o aparición del dato especificado como parámetro.
* `RemoveAt(int)`, que elimina el dato que se encuentra en la posición que se deterima en el parámetro.
* `RemoveRange(int, int)`, elimina todos los elementos en el rango especificado en los dos parámetros.
* `Reverse()`, invierte todos los elementos en la lista.
* `Sort()`, ordena todos los elementos bajo un criterio por defecto. Para listas con datos complejos, hay que especificar nuevos criterios.

## Listas con tipos complejos

Hemos explicado que las listas trabajan con tipos de datos, primitivos (como cadenas de texto y números enteros) o complejos (como Clases). El hecho de que se pueda utilizar con Clases da mucha potencia a la hora de trabajar con determinados datos de forma unificada. Lo veremos con un ejemplo.

Imaginemos que tenemos la Clase Personaje, que tiene dos Propiedades, Nombre y Nivel. Esta es la Clase ejemplo con la que vamos a explicar.

```cs
List<Personaje> listaPersonajes = new List<Personaje>();

listaPersonajes.Add(new Personaje("Ethan Thross", 14));
listaPersonajes.Add(new Personaje("Tirsa Ventar", 11));
```

Hemos construido dos personajes, usando el constructor que toma los dos parámetros para nombre y nivel, para añadir dos elementos a la lista que usa la Clase Personaje como tipo de dato. Y la Clase List, que tiene imbuida la funcionalidad de índices, nos permite acceder a los diferentes personajes a través de ellos. Lo veremos con un ejemplo:

```cs
string nombreDePersonajeDos = listaPersonajes[1].Nombre;
```

Y ahora el contenido de esta nueva variable es `Tirsa Ventar`, porque hemos seleccionado el segundo personaje de la lista y tomado el valor de su Propiedad Nombre.

## Operando con listas

### Método `ConvertAll()`

```cs
class First
{
    int id;
    string description;
    DateTime creation;
}

class Second
{
    int id;
    string fullInfo;
}

// moar código

List<First> firstList = new List();
List<Second> secondList;
firstList.AddRange(fictionalData);
secondList = firstList.ConvertAll(item => new Second {
    id = item.id,
    fullInfo = item.description + " " + item.creation.Year
} );
```
