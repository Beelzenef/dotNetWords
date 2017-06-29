# Clase Stack

Queue es una Clase que representa a una colección de un tipo de dato concreto con un comportamiento concreto. Es dinámica, por lo que se adaptará a medida que la vayas llenando o quizás eliminando su contenido.

El comportamiento concreto es el de pila, un *stack*, donde el último que entra es el primero que sale.

En esta Clase utiliza también utiliza la convención T, para referirse a un tipo de dato, al tipo de dato con el que es construido y que vivirá en toda la instancia.

## Constructores

Tiene tres constructores, dos de ellos más utilizados. El primero, vacío, y el segundo que toma un número entero para especificar una capacidad inicial en la instancia.

Una pila de números sin capacidad personalizada elegida:

```cs
Stack<int> stackNumeros = new Stack<int>();
```

Una pila de cadenas de texto, con capacidad inicial para 10 elementos:

```cs
Stack<string> stackNombres= new Stack<string>(10);
```

## Propiedades

* Count, que indica el número de elementos que contiene actualmente la colección.
* Capacity, número de elementos que caben en la instancia antes de cambiar de tamaño.

## Métodos

La lista de los métodos más frecuentes en el uso de la Clase Stack. Son limitados en número pues no funciona como una lista normal, se quiere mantener el comportamiento específico de LIFO (Last in, First out):

| Método      | Tipo de dato | Explicacion  |
| ------------- |:--------------------:| -----|
|Clear()| void |Limpia la colección, eliminando todos los elementos |
|Contains(T)| bool |Devuelve un booleano comprobando si el elemento pasado como parámetro se encuentra o no en la cola.|
|Pop()|T|Elimina el último elemento de la pila |
|Push(T)| void |Añade al inicio de la pila el elemento especificado como parámetro|
|Peek()|T| Devuelve el primer elemento en la cola, lo muestra sin eliminarlo de la cola|
