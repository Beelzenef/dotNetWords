# Clase Queue

Queue es una Clase que representa a una colección de un tipo de dato concreto con un comportamiento concreto. Es dinámica, por lo que se adaptará a medida que la vayas llenando o quizás eliminando su contenido.

El comportamiento concreto es el de cola, una **queue**, donde el primero que entra es el primero que sale.

En esta Clase utiliza también utiliza la convención `T`, para referirse a un tipo de dato, al tipo de dato con el que es construido y que vivirá en toda la instancia.

## Constructores

Tiene tres constructores, dos de ellos más utilizados. El primero, vacío, y el segundo que toma un número entero para especificar una capacidad inicial en la instancia.

Una cola de números sin capacidad personalizada elegida:

```cs
Queue<int> colaNumeros = new Queue<int>();
```

Una cola de cadenas de texto, con capacidad inicial para 10 elementos:

```cs
Queue<string> colaNombres= new Queue<string>(10);
```

## Propiedades

* Count, que indica el número de elementos que contiene actualmente la lista.
* Capacity, número de elementos que caben en la instancia antes de cambiar de tamaño.

## Métodos

La lista de los métodos más frecuentes en el uso de la Clase Queue. Son limitados en número pues no funciona como una lista normal, se quiere mantener el comportamiento específico de FIFO (First in, First out):

| Método      | Tipo de dato | Explicacion  |
| ------------- |:--------------------:| -----|
|Clear()| void |Limpia la lista, eliminando todos los elementos |
|Contains(T)| bool |Devuelve un booleano comprobando si el elemento pasado como parámetro se encuentra o no en la cola.|
|Dequeue()|T|Elimina el primer elemento de la cola |
|Enqueue(T)| void |Añade al final de la cola el elemento especificado como parámetro|
|Peek()|T| Devuelve el primer elemento en la cola, lo muestra sin eliminarlo de la cola|
