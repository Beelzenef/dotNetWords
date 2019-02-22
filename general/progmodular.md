# Programación modular

Este tipo de programación se genera mediante funciones, métodos o módulos, que se encuentran dentro de una Clase. Todo método devuelve un valor que se especifica en la firma. Uno y solo un valor a devolver.

La única excepción se encuentra en los métodos que devuelven void, es decir, nada.

Como Main() es un método, las funciones han de ser escritas fuera de Main pero dentro de la Clase que tengamos.

Toda función puede recibir parámetros, desde cero a infinitos, que se especifican en la firma. Todas las funciones nombres que los identifican.

Las funciones se crean para tareas concretas, lo más concretas posibles, aunque también existen las más generales. Siempre deben cumplir el devolver un valor.
La programación estructurada y lo más adaptable posible no muestra datos directamente por pantalla, pues genera dependencia de la consola y no sirve para interfaz gráfica (Windows Forms).

Deben escribirse fuera de toda función, en el ámbito de la Clase.

Las funciones constan de tres partes:

* Documentación (explicación).
* Declaración (firma).
* Definición (código).

Para codificar una función, necesitamos:

* Ámbito (public, private o protected)
* Estática o de instancia (static o sin especificación de estática)
* Tipo de dato (void, int, string…)
* Nombre (al gusto)
* Código (algoritmo que resuelve)

Un ejemplo de una función con dos parámetros, no estática (de instancia) y pública.

```cs
public int SumaDePares(int x, int y)
{
    if (x % 2 == 0 && y % 2 == 0)
    {
        return x + y;
    }
    return 1;
}
```

Toda función es el valor que devuelve. ¿Cómo se entiende esto? Que podemos usar una función que devuelve bool en una estructura IF.

```cs
if (esPar(2))
{ Console.WriteLine(“Es par”); }
```

Las buenas prácticas indican que las funciones devuelven valores pero no los muestran por pantalla. Es mejor recoger los datos y almacenarlos en variables para otros usos.

Una función es un bloque de código con un identificador y una firma que ha de cumplir de un tipo especificado en la firma, pudiendo recibir parámetros o no y que puede ser invocada.

Los métodos han de ser lo más concretos posibles y ser independientes de cualquier interfaz gráfica. Devuelve valor pero no lo muestra, teniendo independencia de interfaz.

Las funciones se pueden sobrecargar, cambiando la lista de los parámetros que recibe, mientras que el valor que devuelve no varía. Si el valor que devuelve varía, no se considera una sobrecarga, se considera otro método.

Al añadir diferentes tipos de datos como parámetros de funciones:

* Los tipos de datos por valor, trabajan con copias de esos datos.
* Los tipos de datos por referencia, mantiene los cambios por métodos.

Para dar parámetros de datos por referencia se utilizan las palabras clave, a elegir, en la firma del método: ref y out.

Para los tipos por referencia, podemos recordar [este tweet](https://twitter.com/FrancescoC/status/738490412441145344/photo/1). Y si queremos utilizar un dato por referencia como parámetro para una función:

```cs
static void FuncionRandom (ref int numero) { … }
```
