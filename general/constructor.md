# Constructores

Los constructores son los métodos con los que creamos una instancia de una determinada Clase. Por ejemplo, de la Clase Random.

```cs
Random rnd = new Random();
```

En este fragmento de código estamos instanciando un objeto de la Clase Random para generación de números aleatorios con una semilla basada en el reloj del sistema operativo.

Pero también podemos hacer uso de otro constructor.

```cs
Random rnd = new Random(12);
```

En este caso, nosotros estamos dando la semilla para los números aleatorios. Este constructor es el que recibe diferentes parámetros dependiendo de nuestras necesidades, el constructor está sobrecargado porque es en realidad un método de la Clase con el mismo nombre de la Clase.

En el futuro próximo construiremos nuestras propias Clases y crearemos constructores para sobrecargarlos al gusto.
