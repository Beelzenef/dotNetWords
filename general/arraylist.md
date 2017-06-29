# Clase ArrayList

La Clase ArrayList representa una colección que no tiene un comportamiento específico salvo el dinámico. Es decir, se ajustará al tamaño según se utilice pero no funciona como pila o como cola. Funciona con una lista pero con la particularidad de que no necesita especificación de tipo.

La misma instancia puede contener números enteros, strings, instancias de la Clase Persona... Para usarla, debes tener cuidado de no utilizar el mismo tratamiento para todos sus elementos. Realiza las comprobaciones necesarias o captura las posibles excepciones.

## Constructores

Tiene tres constructores, dos de ellos más utilizados. El primero, vacío, y el segundo que toma un número entero para especificar una capacidad inicial en la instancia.

Una lista sin capacidad personalizada elegida:

```cs
ArrayList listaNumeros = new ArrayList();
```

Una lista con capacidad inicial para 10 elementos:

```cs
ArrayList listaNombres = new ArrayList(10);
```

## Propiedades

* Count, que indica el número de elementos que contiene actualmente la lista.
* Capacity, número de elementos que caben en la instancia antes de cambiar de tamaño.

## Métodos

La lista de los métodos más frecuentes en el uso de la Clase List:

|Método| Tipo de dato | Explicacion|
|----|:----:|----|
| Add(O) |void | Añade al final de la lista el elemento especificado como parámetro|
|Clear() | void | Limpia la lista, eliminando todos los elementos. |
|Contains(O)|bool|Busca la primera ocurrencia del elemento a buscar, que se especifica en el parámetro.|
|IndexOf(O)|int| Devuelve el índice, la posición, de la primera ocurrencia del elemento a buscar, que se especifica en el parámetro.|
|LastIndexOf(O)|int| Devuelve el índice, la posición, de la última ocurrencia del elemento a buscar, que se especifica en el parámetro.|
|Remove(O)|void| Elimina la primera ocurrencia o aparición del dato especificado como parámetro.|
|RemoveAt(int)|void| Que elimina el dato que se encuentra en la posición que se deterima en el parámetro.|
|RemoveRange(int, int) |void| Elimina todos los elementos en el rango especificado en los dos parámetros.|
|Reverse() |void| Invierte todos los elementos en la lista.|
|Sort() |void| Ordena todos los elementos bajo un criterio por defecto. Para listas con datos complejos, hay que especificar nuevos criterios.|

## ArrayList con tipos complejos

Imaginemos que tenemos la Clase Personaje, que tiene dos Propiedades, Nombre y Nivel. Esta es la Clase ejemplo con la que vamos a explicar.

```cs
ArrayList listaGeneral = new ArrayList();

listaGeneral.Add(new Personaje("Ethan Thross", 14));
listaGeneral.Add(new Personaje("Tirsa Ventar", 11));
listaGeneral.Add(1);
```

Hemos construido dos personajes, usando el constructor que toma los dos parámetros para nombre y nivel, para añadir dos elementos a la lista que usa la Clase Personaje como tipo de dato. También hemos añadido un número. La instancia ya es de contenido mixto, por lo que necesitaremos hacer comprobaciones para, en bucle, imprimir en consola todos los nombres de aquellos elementos que sean instancias de la Clase Persona.

Y la Clase ArrayList, que tiene imbuida la funcionalidad de índices, nos permite acceder a los diferentes elementos a través de ellos. 

```cs
for (int i = 0; i < listaGeneral.Count - 1; i++)
{
    if (listaPersonajes[i] is Persona)
      Console.WriteLine(listaPersonajes[i].Nombre);
}
```
